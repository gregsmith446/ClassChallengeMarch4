using System;

namespace CodeChallengeMarch4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dropTheBall = new BouncingBall();

            // int result = dropTheBall.bouncingBall(3, 0.66, 1.5);

            int result = dropTheBall.bouncingBall(3, 1, 1.5);

            Console.WriteLine(result);
        }
             
        public class BouncingBall
        {
            public int bouncingBall(double h, double bounce, double window)
            {
                int total = 0;

                // if any of these are true, exit the program with a -1
                // this means the numbers are invalid
                if (h < 0)
                {
                    Console.WriteLine("height invalid");
                    return -1;
                }
                else if (window >= h)
                {
                    Console.WriteLine("window height invalid");
                    return -1;
                }
                else if (bounce <= 0)
                {
                    Console.WriteLine("bounce rate invalid");
                    return -1;
                }
                else if (bounce >= 1)
                {
                    Console.WriteLine("bounce rate invalid");
                    return -1;
                }
                else
                {
                    return total;
                }
            }
        }

    }
}
