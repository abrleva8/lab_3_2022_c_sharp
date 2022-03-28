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
            using (StreamReader file = new StreamReader(filename)) {
                if (int.Parse(file.ReadLine()) == 1) {
                    return true;
                }
            }

            return false;
        }
     }
}
