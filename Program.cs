using System.Transactions;

namespace LineComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Line Comparison Problems");

            Console.WriteLine("Enter the Co-Ordinates of Line1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());   
            int y2 = Convert.ToInt32(Console.ReadLine());
            
            double Points1 = Math.Pow((x2-x1), 2);
            double Points2 = Math.Pow((y2-y1), 2);
            double Length1 = Points1 + Points2;

            double LengthOfLine1 = Math.Sqrt(Points1+Points2);

            Console.WriteLine("Enter the Co-Ordinates of Line2");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            
            double Points3 = Math.Pow((a2 - a1), 2);
            double Points4 = Math.Pow((b2 - b1), 2);
            double Length2 = Points3 + Points4;
            double LengthOfLine2 = Math.Sqrt(Points3 + Points4);

            if (LengthOfLine1.CompareTo(LengthOfLine2) < 0)
                Console.WriteLine("Line2 is greater than Line1");

            else if (LengthOfLine1.CompareTo(LengthOfLine2) > 0)
                Console.WriteLine("Line1 is greater than Line2");

            else
                Console.WriteLine("Line1 is equal to Line2");
        }
    }
}