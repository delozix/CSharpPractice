namespace MultipleOf3Or5
{
    internal class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine(23 == MultipleOfTwoNums.MultipleOf3or5(10));
            Console.WriteLine(0 == MultipleOfTwoNums.MultipleOf3or5(0));
            Console.WriteLine(0 == MultipleOfTwoNums.MultipleOf3or5(1));
            Console.WriteLine(0 == MultipleOfTwoNums.MultipleOf3or5(-10));
        }
    }
}