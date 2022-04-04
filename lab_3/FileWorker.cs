using System;
using System.IO;

namespace lab_3 {
    public class FileWorker {
        public static void ChangeStartMessageFile(bool IsAgain, string filename) {
            if (IsAgain) {
                using (StreamWriter file = new StreamWriter(filename, false)) {
                    file.WriteLine(1);
                }
            } else {
                using (StreamWriter file = new StreamWriter(filename, false)) {
                    file.WriteLine(0);
                }
            }
        }


        public static bool ReadStartMessageFile(string filename) {
            if (!File.Exists(filename)) {
                using (FileStream fs = File.Create(filename)) {
                    fs.WriteByte(48);
                }
            }
            int number = 0;
            using (StreamReader file = new StreamReader(filename)) {
                try {
                    number = int.Parse(file.ReadLine() ?? string.Empty);
                } catch (FormatException) {
                    return false;
                }
            }

            return number == 1;
        }
    }
}
