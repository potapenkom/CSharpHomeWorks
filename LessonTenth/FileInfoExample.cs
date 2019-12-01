using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LessonTenth
{
    public static class FileInfoExample
    {
        public static void ShowFileInfo()
        {
            string path = @"C:\Project\MySolution\HomeVideoCourse\ShowFileInfo.txt";
            var fileInfo = new FileInfo(path);
            try
            {
                if (!fileInfo.Exists)
                {
                    fileInfo.Create();
                    Console.WriteLine($"File {fileInfo.FullName} was successfully created");
                }
                else
                    Console.WriteLine(fileInfo.FullName);
            }
            catch (Exception ex)
            {
                var pathToFile = Path.GetDirectoryName(path);
                var directory = new DirectoryInfo(pathToFile);
                Console.WriteLine(ex.Message);
                directory.Create();
                ShowFileInfo();
                Console.WriteLine($"Directory {directory.FullName} was created.");
            }
        }
    }
}
