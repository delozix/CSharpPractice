namespace CSharpPractice
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 == DivCon.DivConq(new object[] { 9, 3, "7", "3" }));
            Console.WriteLine(-3 == DivCon.DivConq(new object[] {-3, "-2", "2" }));
            Console.WriteLine(0 == DivCon.DivConq(new object[] { 0, "0" }));
            Console.WriteLine(-1 == DivCon.DivConq(new object[] { "1" }));
            Console.WriteLine(28 == DivCon.DivConq(new object[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(-28 == DivCon.DivConq(new object[] { "1", "2", "3", "4", "5", "6", "7" }));
        }
    }
}