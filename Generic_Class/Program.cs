namespace Generic_Class
{
    class Example<T>
    {
        T box;

        public T Box 
        {
            set 
            { 
                this.box = value;
            }
            get { return this.box; }

        }
        //public Example(T b) 
        //{
        //    this.box = b;
        //}
        //public T getBox() { return box; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Example<int> example = new Example<int>(20);
            //Console.WriteLine(example.getBox());

            //Example<string> example1 = new Example<string>("Asim");
            //Console.WriteLine(example1.getBox());

            //..................

            Example<int>example = new Example<int>();   
            example.Box = 1;
            Console.WriteLine(example.Box);
        }
    }
}