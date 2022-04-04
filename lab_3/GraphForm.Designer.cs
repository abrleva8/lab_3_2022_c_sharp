namespace lab_3 {
    partial class GraphForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void GreetingWorker() {
            bool isAgain = FileWorker.ReadStartMessageFile("check_box_info.txt"); ;
            
            AboutForm aboutForm = new AboutForm(isAgain);
            if (aboutForm.IsAgain) {
                aboutForm.Show();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readDataFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_a = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxLeftBorder = new System.Windows.Forms.TextBox();
            this.label_left_border = new System.Windows.Forms.Label();
            this.textBoxRightBorder = new System.Windows.Forms.TextBox();
            this.label_right_border = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.label_step = new System.Windows.Forms.Label();
            this.button_draw_graph = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_show_table = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_clear_table = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readDataFromFileToolStripMenuItem,
            this.saveInputDataToolStripMenuItem,
            this.saveOutputDataToolStripMenuItem,
            this.saveDataToExcellToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readDataFromFileToolStripMenuItem
            // 
            this.readDataFromFileToolStripMenuItem.Name = "readDataFromFileToolStripMenuItem";
            this.readDataFromFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readDataFromFileToolStripMenuItem.Text = "Read data from file";
            this.readDataFromFileToolStripMenuItem.Click += new System.EventHandler(this.readDataFromFileToolStripMenuItem_Click);
            // 
            // saveInputDataToolStripMenuItem
            // 
            this.saveInputDataToolStripMenuItem.Enabled = false;
            this.saveInputDataToolStripMenuItem.Name = "saveInputDataToolStripMenuItem";
            this.saveInputDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveInputDataToolStripMenuItem.Text = "Save input data";
            this.saveInputDataToolStripMenuItem.Click += new System.EventHandler(this.saveInputDataToolStripMenuItem_Click);
            // 
            // saveOutputDataToolStripMenuItem
            // 
            this.saveOutputDataToolStripMenuItem.Enabled = false;
            this.saveOutputDataToolStripMenuItem.Name = "saveOutputDataToolStripMenuItem";
            this.saveOutputDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveOutputDataToolStripMenuItem.Text = "Save output data";
            this.saveOutputDataToolStripMenuItem.Click += new System.EventHandler(this.saveOutputDataToolStripMenuItem_Click);
            // 
            // saveDataToExcellToolStripMenuItem
            // 
            this.saveDataToExcellToolStripMenuItem.Enabled = false;
            this.saveDataToExcellToolStripMenuItem.Name = "saveDataToExcellToolStripMenuItem";
            this.saveDataToExcellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDataToExcellToolStripMenuItem.Text = "Save data to excell";
            this.saveDataToExcellToolStripMenuItem.Click += new System.EventHandler(this.saveDataToExcellToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chartGraph
            // 
            chartArea1.CursorX.Interval = 0.01D;
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            this.chartGraph.Location = new System.Drawing.Point(359, 12);
            this.chartGraph.Name = "chartGraph";
            this.chartGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "graph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.MarkerColor = System.Drawing.Color.White;
            series2.MarkerSize = 10;
            series2.Name = "pointToDelete";
            series2.YValuesPerPoint = 2;
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Series.Add(series2);
            this.chartGraph.Size = new System.Drawing.Size(455, 361);
            this.chartGraph.TabIndex = 1;
            this.chartGraph.Text = "chart1";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a.Location = new System.Drawing.Point(42, 188);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(18, 20);
            this.label_a.TabIndex = 2;
            this.label_a.Text = "a";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(110, 188);
            this.textBoxA.MaxLength = 7;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(176, 20);
            this.textBoxA.TabIndex = 3;
            this.textBoxA.Text = "2";
            // 
            // textBoxLeftBorder
            // 
            this.textBoxLeftBorder.Location = new System.Drawing.Point(110, 233);
            this.textBoxLeftBorder.MaxLength = 7;
            this.textBoxLeftBorder.Name = "textBoxLeftBorder";
            this.textBoxLeftBorder.Size = new System.Drawing.Size(176, 20);
            this.textBoxLeftBorder.TabIndex = 5;
            this.textBoxLeftBorder.Text = "-5";
            // 
            // label_left_border
            // 
            this.label_left_border.AutoSize = true;
            this.label_left_border.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_left_border.Location = new System.Drawing.Point(13, 233);
            this.label_left_border.Name = "label_left_border";
            this.label_left_border.Size = new System.Drawing.Size(81, 20);
            this.label_left_border.TabIndex = 4;
            this.label_left_border.Text = "left border";
            // 
            // textBoxRightBorder
            // 
            this.textBoxRightBorder.Location = new System.Drawing.Point(110, 284);
            this.textBoxRightBorder.MaxLength = 7;
            this.textBoxRightBorder.Name = "textBoxRightBorder";
            this.textBoxRightBorder.Size = new System.Drawing.Size(176, 20);
            this.textBoxRightBorder.TabIndex = 7;
            this.textBoxRightBorder.Text = "5";
            // 
            // label_right_border
            // 
            this.label_right_border.AutoSize = true;
            this.label_right_border.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_right_border.Location = new System.Drawing.Point(13, 284);
            this.label_right_border.Name = "label_right_border";
            this.label_right_border.Size = new System.Drawing.Size(90, 20);
            this.label_right_border.TabIndex = 6;
            this.label_right_border.Text = "right border";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(110, 332);
            this.textBoxStep.MaxLength = 7;
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(176, 20);
            this.textBoxStep.TabIndex = 9;
            this.textBoxStep.Text = "0,01";
            // 
            // label_step
            // 
            this.label_step.AutoSize = true;
            this.label_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_step.Location = new System.Drawing.Point(30, 330);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(40, 20);
            this.label_step.TabIndex = 8;
            this.label_step.Text = "step";
            // 
            // button_draw_graph
            // 
            this.button_draw_graph.Location = new System.Drawing.Point(388, 393);
            this.button_draw_graph.Name = "button_draw_graph";
            this.button_draw_graph.Size = new System.Drawing.Size(90, 45);
            this.button_draw_graph.TabIndex = 11;
            this.button_draw_graph.Text = "Draw the graph";
            this.button_draw_graph.UseVisualStyleBackColor = true;
            this.button_draw_graph.Click += new System.EventHandler(this.button_draw_graph_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(704, 393);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(90, 45);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_show_table
            // 
            this.button_show_table.Enabled = false;
            this.button_show_table.Location = new System.Drawing.Point(901, 393);
            this.button_show_table.Name = "button_show_table";
            this.button_show_table.Size = new System.Drawing.Size(90, 45);
            this.button_show_table.TabIndex = 13;
            this.button_show_table.Text = "Show Table";
            this.button_show_table.UseVisualStyleBackColor = true;
            this.button_show_table.Click += new System.EventHandler(this.button_show_table_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 73);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button_clear_table
            // 
            this.button_clear_table.Location = new System.Drawing.Point(1059, 393);
            this.button_clear_table.Name = "button_clear_table";
            this.button_clear_table.Size = new System.Drawing.Size(90, 45);
            this.button_clear_table.TabIndex = 16;
            this.button_clear_table.Text = "Clear";
            this.button_clear_table.UseVisualStyleBackColor = true;
            this.button_clear_table.Click += new System.EventHandler(this.button_clear_table_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(901, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(243, 361);
            this.dataGridView.TabIndex = 17;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_clear_table);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_show_table);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_draw_graph);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.label_step);
            this.Controls.Add(this.textBoxRightBorder);
            this.Controls.Add(this.label_right_border);
            this.Controls.Add(this.textBoxLeftBorder);
            this.Controls.Add(this.label_left_border);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInputDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToExcellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxLeftBorder;
        private System.Windows.Forms.Label label_left_border;
        private System.Windows.Forms.TextBox textBoxRightBorder;
        private System.Windows.Forms.Label label_right_border;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.Button button_draw_graph;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_show_table;
        private System.Windows.Forms.ToolStripMenuItem readDataFromFileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_clear_table;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

