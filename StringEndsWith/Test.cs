namespace StringEndsWith
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringEndsWith.Solution("sumo", "omo"));
            Console.WriteLine(StringEndsWith.Solution("samurai", "ai"));
            Console.WriteLine(StringEndsWith.Solution("abc", "abcd"));
            Console.WriteLine(StringEndsWith.Solution("abc", "abc"));
            Console.WriteLine(StringEndsWith.Solution("!@#$%^&*() :-)", ":-)"));
            Console.WriteLine(StringEndsWith.Solution("abc\n", "abc"));

        }
    }
}