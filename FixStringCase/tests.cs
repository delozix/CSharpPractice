namespace FixStringCase
{
    internal class tests
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fixstring.FixStringCase("case")); // case
            Console.WriteLine(fixstring.FixStringCase("CAse")); // case
            Console.WriteLine(fixstring.FixStringCase("CASe")); // CASE
            Console.WriteLine(fixstring.FixStringCase("Case")); // case
        }
    }
}