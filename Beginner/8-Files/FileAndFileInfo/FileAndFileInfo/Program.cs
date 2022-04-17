using System.IO;
namespace FileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\example.jpg";

            //File Class
            //Copy
            File.Copy(path, @"d:\temp\myfile.jpg", true);

            //Delete
            File.Delete(path);

            //If exists
            if (File.Exists(path))
            {
                //Code
            }

            //Read
            var content = File.ReadAllText(path);

            //FileInfo
            var fileInfo = new FileInfo(path);

            //CopyTo
            fileInfo.CopyTo("...");

            //Delete
            fileInfo.Delete();

            //If exists
            if (fileInfo.Exists)
            {
                //Code
            }
        }
    }
}
