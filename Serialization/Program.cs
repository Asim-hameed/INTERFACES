using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SERIALIZATION


            //string path = "C:\\Users\\ASIM HAMEED\\source\\repos\\INTERFACES\\Serialization\\sample.txt";
            //Employee employee =new Employee(365,"Asim");
            //FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(file, employee);
            //file.Close();
            //Console.WriteLine("File Created Successfully");
            //Console.ReadLine();

            // DE-SERIALIZATION

            string path = "C:\\Users\\ASIM HAMEED\\source\\repos\\INTERFACES\\Serialization\\sample.txt";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee employee = (Employee)formatter.Deserialize(file);
            Console.WriteLine("Employee id: "+employee.id);
            Console.WriteLine("Employee name: "+employee.name);
            file.Close();

        }
    }
}