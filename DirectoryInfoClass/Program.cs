using System.IO;
namespace DirectoryInfoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ASIM HAMEED\source\repos\INTERFACES\DirectoryInfoClass\My Directory";
            string path2 = @"C:\Users\ASIM HAMEED\source\repos\INTERFACES\DirectoryInfoClass\My Directory 2";

            DirectoryInfo dir = new DirectoryInfo(path);
            //dir.Create();
            //dir.CreateSubdirectory("SubDirectory");

            dir.MoveTo(path2);
            Console.WriteLine("Directory Created");
        }
    }
}