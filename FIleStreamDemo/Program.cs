using System.IO;
using System.Text;

namespace FIleStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\ASIM HAMEED\\source\\repos\\INTERFACES\\FIleStreamDemo\\myFile.txt";
            using (FileStream file = new FileStream(path, FileMode.Append,FileAccess.Write)
)
            {
                //file.WriteByte(65);
                //file.WriteByte(67);

                string data = "Welcome to learning";
                byte[] write_data=Encoding.UTF8.GetBytes(data);
                file.Write(write_data, 0, data.Length);
                //Console.WriteLine("File Append successfully");
                // using block to avoid closing of file
            }
            //fileStream.Close();
        }
    }
}