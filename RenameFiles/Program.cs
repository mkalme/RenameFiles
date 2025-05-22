using System;
using System.IO;

namespace RenameFiles
{
    class Program
    {
        private static string folderPath = @"D:\Backup\Pictures & Videos on Phone\Ceļojumi\Ceļojums-Itālija 2017\Bildes & Video\number2";

        static void Main(string[] args)
        {

            renameAllFiles();

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        static void renameAllFiles() {
            string[] filePaths = Directory.GetFiles(folderPath);

            for (int i = 0; i < filePaths.Length; i++) {
                renameOneFile(filePaths[i], Path.GetDirectoryName(filePaths[i]) + @"\" + (i + 2000) + Path.GetExtension(filePaths[i]));
            }
        }

        static void renameOneFile(string oldPath, string newPath) {
            File.Move(oldPath, newPath);
        }
    }
}
