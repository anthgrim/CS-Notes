using System;
using System.IO;

namespace Paths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\Users\Anthg\Documents\CSharp\CS-Notes";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: {0}", Path.GetExtension(path));
            Console.WriteLine("File Name: {0}", Path.GetFileName(path));
            Console.WriteLine("File Name without extension: {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: {0}", Path.GetDirectoryName(path));
        }
    }
}
