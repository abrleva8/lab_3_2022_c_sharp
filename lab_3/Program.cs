﻿using System;
using System.Windows.Forms;

namespace lab_3 {
    internal static class Program {
        
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GraphForm());
        }
    }
}
