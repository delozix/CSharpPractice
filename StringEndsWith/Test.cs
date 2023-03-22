namespace StringEndsWith
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringStartsWith.Solution("sumo", "omo"));
            Console.WriteLine(StringStartsWith.Solution("samurai", "ai"));
            Console.WriteLine(StringStartsWith.Solution("abc", "abcd"));
            Console.WriteLine(StringStartsWith.Solution("abc", "abc"));
            Console.WriteLine(StringStartsWith.Solution("!@#$%^&*() :-)", ":-)"));
            Console.WriteLine(StringStartsWith.Solution("abc\n", "abc"));

        }
    }
}