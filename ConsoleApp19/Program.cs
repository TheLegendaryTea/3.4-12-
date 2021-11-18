using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                for (double x = 1; x <= 3; x+=0.2)
                {
                    double y = 0;
                    double S = 0;
                    if (x <= 2)
                    {
                       
                        S = x * x - (x + 1 / 3 - x);
                        y = S;
                    }
                    else if(x>2)
                    {
                        S = Math.Pow(Math.Sin(Math.Pow(x - 1, 2)), 3);
                        y = S;
                    }
                    y = Math.Exp(S);
                    Console.WriteLine("|{0,13:F2}|{1,14:F2}|", x, y);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
