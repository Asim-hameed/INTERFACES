namespace PartialClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentPartial studentPartial = new StudentPartial();
            studentPartial.firstName = "Asim";
            studentPartial.LastName = "Hameed";
            Console.WriteLine(studentPartial.GetCompleteName());
        }
    }
}