using System;
using System.IO;

namespace lesson_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\GeekBrains_Lessons\HomeWork";

            PrintDirectories(path);
        }

        private static void PrintDirectories(string path, string prefix = "", string txtFilePath = @"D:\GeekBrains_Lessons\HomeWork\lesson-5\lesson-5.4\DirectoryTree.txt")
        {
            var startDir = new DirectoryInfo(path);
            var treeItems = startDir.GetFileSystemInfos();

                for (int i = 0; i < treeItems.Length; i++)
                {
                    var treeItem = treeItems[i];
                    if (i == treeItems.Length - 1)
                    {
                        File.AppendAllText(txtFilePath, prefix + "└── " + treeItem.Name + "\n", encoding:System.Text.Encoding.Unicode);

                        if ((treeItem.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                        {
                            PrintDirectories(treeItem.FullName, prefix + "      ");
                        }
                    }
                    else
                    {
                        File.AppendAllText(txtFilePath, prefix + "├── " + treeItem.Name + "\n", encoding: System.Text.Encoding.Unicode);

                        if ((treeItem.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                        {
                            PrintDirectories(treeItem.FullName, prefix + "|    ");
                        }
                    }

            }
        }
    }
}
