namespace List_Generic_Collection
{
    // List is Generic while ArrayList is Non-Generic Collection
    //List is type safe
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Name = "Test",
                Designation = "officer",
                Id = 1
            };
            Employee emp2 = new Employee()
            {
                Name = "Asim",
                Designation = "officer",
                Id = 2
            };
            Employee emp3 = new Employee()
            {
                Name = "Babar",
                Designation = "officer",
                Id = 3
            };

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            Console.WriteLine(employees.Exists(emp => emp.Name.StartsWith("A")));

            foreach (Employee emp in employees)
            {
                Console.WriteLine("Employee name is {0} ID is {1} Designation is {2}", emp.Name, emp.Id, emp.Designation);
            }

            Employee empp = employees.Find(emp1 => empp.Id > 20);


            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);
            //ints.Add(5);
            //ints.Add(6);
            //Console.WriteLine(ints.Capacity);
            //Console.WriteLine(ints.Count);

            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> list = new List<string>();
            //list.Add("Asim");
            //list.Add("Adil");
            //list.Add("Asim");
            //list.Add(null);
            //list.Add("Talha");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Sort();

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}