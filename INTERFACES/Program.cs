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
    interface i1
    {
        void show1();
    }
    interface i2 : i1, IEmployee
    {
        void show2();
    }
    //class partTimeEmployee : IEmployee
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("This is a method of Interface IEmployee");
    //    }
    //}

    class Program : i2
    {
        public void show()
        {
            Console.WriteLine("This is a method of interface IEmployee");
        }
        public void show1()
        {
            Console.WriteLine("This is a method of interface i1");
        }
        public void show2() 
        {
            Console.WriteLine("This is a method of interface i2");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //partTimeEmployee partTimeEmployee = new partTimeEmployee();
            //partTimeEmployee.show();

            //..............




            //........
            i2 myInterface = new Program();

            myInterface.show();
            myInterface.show1();
            myInterface.show2();

        }
    }
}