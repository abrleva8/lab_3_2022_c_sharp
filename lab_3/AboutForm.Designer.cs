using System.IO;

namespace lab_3 {
    partial class AboutForm {
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.infoTextLabel_1 = new System.Windows.Forms.Label();
            this.infoTextLabel_2 = new System.Windows.Forms.Label();
            this.infoTextLabel_3 = new System.Windows.Forms.Label();
            this.checkBoxShowAgain = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // infoTextLabel_1
            // 
            this.infoTextLabel_1.AccessibleName = "infoTextLabel_1";
            this.infoTextLabel_1.AutoSize = true;
            this.infoTextLabel_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextLabel_1.Location = new System.Drawing.Point(43, 20);
            this.infoTextLabel_1.Name = "infoTextLabel_1";
            this.infoTextLabel_1.Size = new System.Drawing.Size(298, 20);
            this.infoTextLabel_1.TabIndex = 0;
            this.infoTextLabel_1.Text = "This is the first task of the third laboratory";
            // 
            // infoTextLabel_2
            // 
            this.infoTextLabel_2.AutoSize = true;
            this.infoTextLabel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextLabel_2.Location = new System.Drawing.Point(25, 65);
            this.infoTextLabel_2.Name = "infoTextLabel_2";
            this.infoTextLabel_2.Size = new System.Drawing.Size(347, 20);
            this.infoTextLabel_2.TabIndex = 1;
            this.infoTextLabel_2.Text = "Author Levon Abramyan, 2nd course, 404 group";
            // 
            // infoTextLabel_3
            // 
            this.infoTextLabel_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoTextLabel_3.AutoSize = true;
            this.infoTextLabel_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextLabel_3.Location = new System.Drawing.Point(54, 106);
            this.infoTextLabel_3.Name = "infoTextLabel_3";
            this.infoTextLabel_3.Size = new System.Drawing.Size(287, 20);
            this.infoTextLabel_3.TabIndex = 2;
            this.infoTextLabel_3.Text = "The program draws the Witch of Agnesi";
            this.infoTextLabel_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxShowAgain
            // 
            this.checkBoxShowAgain.AutoSize = true;
            this.checkBoxShowAgain.Location = new System.Drawing.Point(126, 148);
            this.checkBoxShowAgain.Name = "checkBoxShowAgain";
            this.checkBoxShowAgain.Size = new System.Drawing.Size(108, 17);
            this.checkBoxShowAgain.TabIndex = 3;
            this.checkBoxShowAgain.Text = "Don\'t show again";
            this.checkBoxShowAgain.UseVisualStyleBackColor = true;
            this.checkBoxShowAgain.CheckedChanged += new System.EventHandler(this.checkBoxShowAgain_CheckedChanged);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 204);
            this.Controls.Add(this.checkBoxShowAgain);
            this.Controls.Add(this.infoTextLabel_3);
            this.Controls.Add(this.infoTextLabel_2);
            this.Controls.Add(this.infoTextLabel_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoTextLabel_1;
        private System.Windows.Forms.Label infoTextLabel_2;
        private System.Windows.Forms.Label infoTextLabel_3;
        private System.Windows.Forms.CheckBox checkBoxShowAgain;
    }
}