namespace INTERFACES
{
    interface IEmployee
    {
        // All the members are public by default
        // Inteface should have signature not body
        // We cannot have an object of interface but canbe inherited to classes and other interfaces
        // It cannot contain fields and cannot use acces modifier


        void show();
    }
    class partTimeEmployee : IEmployee
    {
        public void show()
        {
            Console.WriteLine("This is a method of Interface IEmployee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            partTimeEmployee partTimeEmployee = new partTimeEmployee();
            partTimeEmployee.show();

        }
    }
}