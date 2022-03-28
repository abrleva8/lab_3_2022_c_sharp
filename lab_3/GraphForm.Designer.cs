using System.IO;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_a = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_left_border = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_right_border = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_step = new System.Windows.Forms.Label();
            this.button_draw_graph = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_show_table = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInputDataToolStripMenuItem,
            this.saveOutputDataToolStripMenuItem,
            this.saveDataToExcellToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveInputDataToolStripMenuItem
            // 
            this.saveInputDataToolStripMenuItem.Name = "saveInputDataToolStripMenuItem";
            this.saveInputDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveInputDataToolStripMenuItem.Text = "Save input data";
            // 
            // saveOutputDataToolStripMenuItem
            // 
            this.saveOutputDataToolStripMenuItem.Name = "saveOutputDataToolStripMenuItem";
            this.saveOutputDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveOutputDataToolStripMenuItem.Text = "Save output data";
            // 
            // saveDataToExcellToolStripMenuItem
            // 
            this.saveDataToExcellToolStripMenuItem.Name = "saveDataToExcellToolStripMenuItem";
            this.saveDataToExcellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDataToExcellToolStripMenuItem.Text = "Save data to excell";
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(322, 60);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(455, 361);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a.Location = new System.Drawing.Point(42, 145);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(18, 20);
            this.label_a.TabIndex = 2;
            this.label_a.Text = "a";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label_left_border
            // 
            this.label_left_border.AutoSize = true;
            this.label_left_border.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_left_border.Location = new System.Drawing.Point(13, 190);
            this.label_left_border.Name = "label_left_border";
            this.label_left_border.Size = new System.Drawing.Size(81, 20);
            this.label_left_border.TabIndex = 4;
            this.label_left_border.Text = "left border";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label_right_border
            // 
            this.label_right_border.AutoSize = true;
            this.label_right_border.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_right_border.Location = new System.Drawing.Point(13, 241);
            this.label_right_border.Name = "label_right_border";
            this.label_right_border.Size = new System.Drawing.Size(90, 20);
            this.label_right_border.TabIndex = 6;
            this.label_right_border.Text = "right border";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 289);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label_step
            // 
            this.label_step.AutoSize = true;
            this.label_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_step.Location = new System.Drawing.Point(30, 287);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(40, 20);
            this.label_step.TabIndex = 8;
            this.label_step.Text = "step";
            // 
            // button_draw_graph
            // 
            this.button_draw_graph.Location = new System.Drawing.Point(13, 377);
            this.button_draw_graph.Name = "button_draw_graph";
            this.button_draw_graph.Size = new System.Drawing.Size(90, 45);
            this.button_draw_graph.TabIndex = 11;
            this.button_draw_graph.Text = "Draw the graph";
            this.button_draw_graph.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(110, 377);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(90, 45);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // button_show_table
            // 
            this.button_show_table.Location = new System.Drawing.Point(206, 377);
            this.button_show_table.Name = "button_show_table";
            this.button_show_table.Size = new System.Drawing.Size(90, 45);
            this.button_show_table.TabIndex = 13;
            this.button_show_table.Text = "Show Table";
            this.button_show_table.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 72);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_show_table);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_draw_graph);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label_step);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_right_border);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_left_border);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphForm_FormClosing);
            this.Load += new System.EventHandler(this.GraphForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_left_border;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_right_border;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.Button button_draw_graph;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_show_table;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

