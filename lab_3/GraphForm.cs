using System;
using System.Windows.Forms;

namespace lab_3 {
    public partial class GraphForm : Form {
        public GraphForm() {
            InitializeComponent();
        }

        private void GraphForm_Load(object sender, System.EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
