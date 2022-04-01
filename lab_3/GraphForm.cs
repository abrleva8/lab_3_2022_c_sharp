using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace lab_3 {
    public partial class GraphForm : Form {

        public GraphForm() {
            InitializeComponent();
            GreetingWorker();
        }

        private void GraphForm_Load(object sender, EventArgs e) {
            
        }

        private double TryConvert(TextBox textBox) {
            double num = 0.0;
            try {
                num = double.Parse(textBox.Text);
            } catch (Exception) {
                throw new FormatException($"The {textBox.Name}  should be double!");
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

        private void chart1_Click(object sender, EventArgs e) {

        }

        private void button_draw_graph_Click(object sender, EventArgs e) {
            if ((CheckNumbers().Count != 4)) return;
            this.chartGraph.Series[0].Points.Clear();
            this.chartGraph.Series[1].Points.Clear();
            double a = double.Parse(textBoxA.Text);
            double step = double.Parse(textBoxStep.Text);
            
            Interval inter = new Interval(double.Parse(textBoxLeftBorder.Text),
                double.Parse(textBoxRightBorder.Text));
            int leftSide = (int) (inter.LeftBorder / step);
            int rightSide = (int) (inter.RightBorder / step);
            WitchOfAgnesi witch = new WitchOfAgnesi(a, inter, step);
            for (int i = leftSide; i <= rightSide; i++) {
                double x = step * i;
                this.chartGraph.Series[0].Points.AddXY(x, witch.Calculate(x));
            }

            if (witch.IsSpecialSituation()) {
                this.chartGraph.Series[1].Points.AddXY(0.000001, 0);
            }

            this.saveInputDataToolStripMenuItem.Enabled = true;
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
        }

        private void readDataFromFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                InitialDirectory = @"D:\Documents\C#\lab_3\lab_3\lab_3\bin\Debug"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
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
                    MessageBox.Show("File has incorrect data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            textBoxA.Text = data[0].ToString(CultureInfo.CurrentCulture);
            textBoxLeftBorder.Text = data[1].ToString(CultureInfo.InvariantCulture);
            textBoxRightBorder.Text = data[2].ToString(CultureInfo.InvariantCulture);
            textBoxStep.Text = data[3].ToString(CultureInfo.InvariantCulture);
        }

        private void saveInputDataToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    sr.WriteLine(textBoxA.Text);
                    sr.WriteLine(textBoxLeftBorder.Text);
                    sr.WriteLine(textBoxRightBorder.Text);
                    sr.WriteLine(textBoxStep.Text);
                }
                MessageBox.Show("File was saved!", "Saving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("File was not saved!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}