using System;
using System.IO;
using System.Windows.Forms;

namespace lab_3 {
    public partial class GraphForm : Form {

        public GraphForm() {
            InitializeComponent();
            GreetingWorker();
        }

        private void GraphForm_Load(object sender, System.EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            //bool isAgain = FileWorker.ReadStartMessageFile("check_box_info.txt");
            bool isAgain = true;
            AboutForm aboutForm = new AboutForm(isAgain);
            aboutForm.ShowDialog();
        }
    }
}