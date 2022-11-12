using System.Transactions;

namespace LineComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To the Line Comparison Program");
            Console.WriteLine("Enter the Co-Ordinates of the Line1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());   
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
          
            Double Points1 = Math.Pow((x2 - x1), 2);
            Double Points2 = Math.Pow((y2 - y1), 2);
            Double TotalLengthOfLine1 = Math.Sqrt(Points1 + Points2);

            Console.WriteLine("Enter the Co-Ordinates of the Line2");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            Double Points3 = Math.Pow((a2-a1),2);
            Double Points4 = Math.Pow((b2-b1),2);   
            Double TotalLengthOfLine2 = Math.Sqrt(Points3 + Points4);

            if (TotalLengthOfLine1.CompareTo(TotalLengthOfLine2) < 0) 
            Console.WriteLine("Line2 is longer than Line1");
            else if (TotalLengthOfLine1.CompareTo(TotalLengthOfLine2) > 0) 
            Console.WriteLine("Line1 is longer than line2");
            else
            Console.WriteLine("Line1 is equal to Line2");
            
           
           


          













        }
    }
}