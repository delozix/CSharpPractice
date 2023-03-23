namespace BandNameGenerator
{
    internal class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Knife" == BandNameGenerator.BandNameGen("knife"));
            Console.WriteLine("Tartart" == BandNameGenerator.BandNameGen("tart"));
            Console.WriteLine("Sandlesandles" == BandNameGenerator.BandNameGen("sandles"));
            Console.WriteLine("The Bed" == BandNameGenerator.BandNameGen("bed"));
        }
    }
}