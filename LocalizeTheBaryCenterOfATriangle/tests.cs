namespace LocalizeTheBaryCenterOfATriangle
{
    internal class tests
    {
        static void Main(string[] args)
        {
            double[] a = { 8.6667, 6.6667 };
            Console.WriteLine(a[0] == BarycenterOfTriangle.BarTriang(new double[] { 4, 6 }, new double[] { 12, 4 }, new double[] { 10, 10 })[0]); // True
            Console.WriteLine(a[1] == BarycenterOfTriangle.BarTriang(new double[] { 4, 6 }, new double[] { 12, 4 }, new double[] { 10, 10 })[1]); // True
        }

    }
}