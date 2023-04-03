namespace Multpile_Inheritance
{
    class Person
    {
        public void show1()
        {
            Console.WriteLine("This is a method of person class");
        }
    }
    interface Employee
    {
        void show2();
    }

    // Multpile interfaces can be implemented with inheritance

    class Teacher : Person, Employee
    {
        public void show2()
        {
            Console.WriteLine("This is a method of Employee Interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Teacher teacher = new Teacher();
            teacher.show1();
            teacher.show2();
        }
    }
}