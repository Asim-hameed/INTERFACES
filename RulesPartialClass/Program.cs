namespace RulesPartialClass
{
    public class MyClass
    {
        public void show()
        {
            Console.WriteLine("I am Show");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ExamplePartial partial = new ExamplePartial();
            //partial.show();
        }
    }

    public interface ImyInterface1
    {
        void show1();
    }
    public interface ImyInterface2
    {
        void show2();
    }
}