namespace GUID
{
    internal class Program
    {
        
        // 128 bit(16 bytes)
        // Unique Value genrator
        // Use to avoid redundancy

        static void Main(string[] args)
        {
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid.ToString().Replace("-",string.Empty));
            Console.WriteLine(guid.ToString("N").Substring(0,11));
        }
    }
}