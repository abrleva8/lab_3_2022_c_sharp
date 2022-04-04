using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;

namespace lab_3 {
    public partial class GraphForm : Form {
        private WitchOfAgnesi _witch;
        private readonly Dictionary<string, string> _dErrors = new Dictionary<string, string>() {
            ["textBoxA"] = "a",
            ["textBoxLeftBorder"] = "left border",
            ["textBoxRightBorder"] = "right border",
            ["textBoxStep"] = "step",
        };

        public GraphForm() {
            InitializeComponent();
            GreetingWorker();
        }

        private double TryConvert(TextBox textBox) {
            double num;
            try {
                num = double.Parse(textBox.Text);
            } catch (Exception) {
                throw new FormatException($"The {_dErrors[textBox.Name]} should be double!");
            }

            return num;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm(true);
            aboutForm.ShowDialog();
        }

        private void GraphForm_FormClosing(object sender, FormClosingEventArgs e) {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure to want to exit?",
                "Exit", buttons);
            e.Cancel = result != DialogResult.Yes;
        }

        private void button_draw_graph_Click(object sender, EventArgs e) {
            if ((CheckNumbers().Count != 4)) return;
            this.chartGraph.Series[0].Points.Clear();
            this.chartGraph.Series[1].Points.Clear();
            double a = double.Parse(textBoxA.Text);
            double step = double.Parse(textBoxStep.Text);
            Interval inter = null;
            try {
                inter = new Interval(double.Parse(textBoxLeftBorder.Text),
                    double.Parse(textBoxRightBorder.Text));

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
            int leftSide = (int) (inter.LeftBorder / step);
            int rightSide = (int) (inter.RightBorder / step);
            try {
                _witch = new WitchOfAgnesi(a, inter, step);
            } catch (FormatException fe) {
                MessageBox.Show(fe.Message);
                return;
            }
            _witch.SetValues();
            
            foreach (var pair in _witch.Pairs) {
                this.chartGraph.Series[0].Points.AddXY(pair.Key, pair.Value);
            }

            this.saveInputDataToolStripMenuItem.Enabled = true;
            this.button_show_table.Enabled = true;
            dataGridView.DataSource = null;
            this.saveOutputDataToolStripMenuItem.Enabled = false;
        }

        private List<double> CheckNumbers() {
            List<double> numbers = new List<double>();
            try {
                numbers.Add(TryConvert(textBoxA));
                numbers.Add(TryConvert(textBoxLeftBorder));
                numbers.Add(TryConvert(textBoxRightBorder));
                numbers.Add(TryConvert(textBoxStep));
            } catch (FormatException e) {
                MessageBox.Show(e.Message);
            }

            return numbers; 
        }

        private void button_clear_Click(object sender, EventArgs e) {
            foreach (var series in this.chartGraph.Series) {
                series.Points.Clear();
            }
            this.saveInputDataToolStripMenuItem.Enabled = false;
            this.button_show_table.Enabled = false;
            dataGridView.DataSource = null;
            this.saveOutputDataToolStripMenuItem.Enabled = false;
            this.saveDataToExcellToolStripMenuItem.Enabled = false;
        }

        private void readDataFromFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                InitialDirectory = @"D:\Documents\C#\lab_3\lab_3\lab_3\bin\Debug"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) {
                MessageBox.Show("File was not read!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            using (var sr = new StreamReader(openFileDialog.FileName)) {
                SetData(sr);
            }
        }

        private void SetData(StreamReader sr) {
            List<double> data = new List<double>();
            for (int i = 0; i < 4; i++) {
                try {
                    data.Add(double.Parse(sr.ReadLine() ?? string.Empty));
                } catch (Exception) {
                    MessageBox.Show("The file has incorrect data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            textBoxA.Text = data[0].ToString(CultureInfo.CurrentCulture);
            textBoxLeftBorder.Text = data[1].ToString(CultureInfo.InvariantCulture);
            textBoxRightBorder.Text = data[2].ToString(CultureInfo.InvariantCulture);
            textBoxStep.Text = data[3].ToString(CultureInfo.InvariantCulture);
            MessageBox.Show("The file was read!", "Reading!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveInputDataToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                InitialDirectory = @"D:\Documents\C#\lab_3\lab_3\lab_3\bin\Debug",
                Filter = @"Text files(*.txt) | *.txt | All files(*.*) | *.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var streamWriter = new StreamWriter(saveFileDialog.FileName)) {
                    streamWriter.WriteLine(textBoxA.Text);
                    streamWriter.WriteLine(textBoxLeftBorder.Text);
                    streamWriter.WriteLine(textBoxRightBorder.Text);
                    streamWriter.WriteLine(textBoxStep.Text);
                }
                MessageBox.Show("File was saved!", "Saving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("File was not saved!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_show_table_Click(object sender, EventArgs e) {
            DataTable dotTable = new DataTable();
            dotTable.Columns.Add("X", typeof(double));
            dotTable.Columns.Add("Y", typeof(double));
            foreach (var pair in _witch.Pairs) {
                dotTable.Rows.Add(pair.Key, pair.Value);
            }
            dataGridView.DataSource = dotTable;
            this.saveOutputDataToolStripMenuItem.Enabled = true;
            this.saveDataToExcellToolStripMenuItem.Enabled = true;
        }

        private void button_clear_table_Click(object sender, EventArgs e) {
            dataGridView.DataSource = null;
            this.saveOutputDataToolStripMenuItem.Enabled = false;
            this.saveDataToExcellToolStripMenuItem.Enabled = false;
        }

        private void saveOutputDataToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                InitialDirectory = @"D:\Documents\C#\lab_3\lab_3\lab_3\bin\Debug",
                Filter = @"Text files(*.txt) | *.txt | All files(*.*) | *.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var streamWriter = new StreamWriter(saveFileDialog.FileName)) {
                    foreach (var pair in _witch.Pairs) {
                        streamWriter.WriteLine($"{pair.Key}  -  {pair.Value}");
                    }
                }
                MessageBox.Show("The output data was saved!", "Saving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("The output data was not saved!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveDataToExcellToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                InitialDirectory = @"D:\Documents\C#\lab_3\lab_3\lab_3\bin\Debug",
                Filter = @"Excel files (*.xlsx)|*.xlsx|All files (*.xlsx)|*.xlsx"
            };

            string filename = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                filename = saveFileDialog.FileName;
            } else {
                MessageBox.Show("The output data was not saved!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage();
            ExcelWorksheet sheet = package.Workbook.Worksheets.Add("Graph");
            sheet.Cells["B2"].Value = "Witch of Agnesi";
            sheet.Cells["D1"].Value = "X";
            sheet.Cells["E1"].Value = "Y";
            sheet.Cells["B3"].Value = "a";
            sheet.Cells["C3"].Value = _witch.A;
            sheet.Cells["B4"].Value = "left border";
            sheet.Cells["C4"].Value = _witch.GraphInterval.LeftBorder;
            sheet.Cells["B5"].Value = "right border";
            sheet.Cells["C5"].Value = _witch.GraphInterval.RightBorder;
            sheet.Cells["B6"].Value = "step";
            sheet.Cells["C6"].Value = _witch.Step;

            for (int i = 0; i < _witch.Pairs.Count; i++) {
                sheet.Cells[i + 2, 4].Value = _witch.Pairs[i].Key;
                sheet.Cells[i + 2, 5].Value = _witch.Pairs[i].Value;
            }

            ExcelChart chartGraph = sheet.Drawings.AddChart("Witch of Agnesi", eChartType.Line);
            chartGraph.Title.Text = "Witch of Agnesi";
            chartGraph.Legend.Remove();
            chartGraph.SetPosition(10, 0, 10, 0);
            chartGraph.Series.Add(sheet.Cells["E2:E" + (_witch.Pairs.Count + 1)],
                    sheet.Cells["D2:D" + (_witch.Pairs.Count + 1)]);

            try {
                File.WriteAllBytes(filename, package.GetAsByteArray());
            } catch (IOException) {
                MessageBox.Show("The data was not saved! Maybe the file is opened", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("The data was saved!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}