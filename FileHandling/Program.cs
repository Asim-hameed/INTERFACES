using System.IO;
namespace FileHandling
{
    // Copying files to files and also file to directory files
    // First version given above does not allow to overwrite data
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ASIM HAMEED\source\repos\INTERFACES\FileHandling\data.txt";
            string path2= @"C:\Users\ASIM HAMEED\source\repos\INTERFACES\FileHandling\data1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("Yes File exists");
                string data=File.ReadAllText(path);
                Console.WriteLine(data);
                File.Copy(path, path2,true);
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }
    }
}