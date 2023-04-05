namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter A String");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            string reverse = new string(arr);

            if(str == reverse)
            {
                Console.WriteLine("Palindrome of each other");
            }
            else
            {
                Console.WriteLine("Not a Plaindrome");
            }
        }
    }
}