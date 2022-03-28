using System;
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
    }
}