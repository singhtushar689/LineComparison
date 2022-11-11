namespace LineComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison");
            Console.WriteLine("Enter the Co-ordinates of the Line");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Double Line1 = Math.Pow((x2 - x1), 2);
            Double Line2 = Math.Pow((y2 - y1), 2);
            Double TotalLength = Line1 + Line2;
            TotalLength = Math.Sqrt(Line1 + Line2);
            Console.WriteLine("The Total Length of the Line is :" + TotalLength);



        }
    }
}