using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowCommon
{
    public class FileHelper
    {
        public static bool CheckExistsFile(string filePath) {
            return File.Exists(filePath);
        }

        public static bool CheckExistsDir(string dirPath) {
            return Directory.Exists(dirPath);
        }

        public static bool CreateFile(string filePath, string fileContent, bool isAppend = false) {
            try {
                if (CheckExistsFile(filePath) && !isAppend) {
                    File.Delete(filePath);
                }
                FileMode fileMode = FileMode.OpenOrCreate;
                if (isAppend) {
                    fileMode = FileMode.Append;
                }
                using (StreamWriter sw = new StreamWriter(new FileStream(filePath, fileMode, 
                    FileAccess.Write, FileShare.Write), Encoding.GetEncoding(MacroDefine.ENCODING_STR))) {
                    sw.WriteLine(fileContent);
                }
            }
            catch (Exception ex) {
                return false;
            }
            return true;
        }
    }
}
