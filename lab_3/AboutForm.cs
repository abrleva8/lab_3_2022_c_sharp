using System;
using System.IO;
using System.Windows.Forms;

namespace lab_3 {
    public partial class AboutForm : Form {
        public bool IsAgain { get; set; }

        public AboutForm(bool isAgain) {
            this.IsAgain = isAgain;
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e) {

        }

        private void checkBoxShowAgain_CheckedChanged(object sender, EventArgs e) {
            IsAgain = !checkBoxShowAgain.Checked;
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e) {
            FileWorker.ChangeStartMessageFile(IsAgain, "check_box_info.txt");
        }
    }
}
