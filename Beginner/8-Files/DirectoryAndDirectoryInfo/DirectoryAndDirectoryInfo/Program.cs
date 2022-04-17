using System;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory
            var path = @"c:\...";
            Directory.CreateDirectory(path);

            var files = Directory.GetFiles(path, "*.sln", SearchOption.AllDirectories);
            
            foreach (var file in files)
            {
                //Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(path,"*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            if (Directory.Exists(path))
            {
                Console.WriteLine("Found");
            }

            //Directory Info
            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
