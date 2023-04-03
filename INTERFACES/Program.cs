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
        void show();
    }
    interface i2 : i1
    {
        void show();
    }
    //..............

    abstract class myClass
    {
        public abstract void show1();
    }
    class Example : myClass, i1
    {
        public void show()
        {
            Console.WriteLine("This is method of Inteface");
        }

        public override void show1()
        {
            Console.WriteLine("This is method of abstract class");

        }
    }

    ///.............
    //interface i2 
    //{
    //    void show();
    //}

    //...............
    //class MyClass : i1, i2
    //{
    //    void i1.show()
    //    {
    //        Console.WriteLine("This is method of Interface 1") ;
    //    }

    //    void i2.show()
    //    {
    //        Console.WriteLine("This is method of Interface 2");
    //    }
    //}
    //.................
    //class partTimeEmployee : IEmployee
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("This is a method of Interface IEmployee");
    //    }
    //}

    class Program 
    {
        //public void show()
        //{
        //    Console.WriteLine("This is a method of interface IEmployee");
        //}
        //public void show1()
        //{
        //    Console.WriteLine("This is a method of interface i1");
        //}
        //public void show2() 
        //{
        //    Console.WriteLine("This is a method of interface i2");
        //}
        //................
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //partTimeEmployee partTimeEmployee = new partTimeEmployee();
            //partTimeEmployee.show();

            //..............




            //........
            //i2 myInterface = new Program();

            //myInterface.show();
            //myInterface.show1();
            //myInterface.show2();

            //..............

            //MyClass myClass = new MyClass();
            //((i1)myClass).show();
            //((i2)myClass).show();

            //i1 my1 = new MyClass();
            //my1 .show();

            //i2 my2 = new MyClass();
            //my2 .show();

            //...............

            Example example = new Example();
            example.show();
            example.show1();
        }
    }
}