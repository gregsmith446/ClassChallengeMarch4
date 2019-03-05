using System;

namespace CodeChallengeMarch4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dropTheBall = new BouncingBall();

            int result = dropTheBall.bouncingBall(3, 0.66, 1.5);

            // int result = dropTheBall.bouncingBall(3, 1, 1.5);

            Console.WriteLine(result);
        }
             
        public class BouncingBall
        {
            public int bouncingBall(double h, double bounce, double window)
            {
                // if any of these are true, exit the program with a -1
                // this means the given numbers are in some way invalid
                int total = -1;

                if (h < 0)
                {
                    Console.WriteLine("height invalid");
                    return total;
                }
                else if (window >= h)
                {
                    Console.WriteLine("window height invalid");
                    return total;
                }
                else if (bounce <= 0 || bounce >= 1)
                {
                    Console.WriteLine("bounce rate invalid");
                    return total;
                }
                // count how many times the ball passed by window
                // each time the height is > window, add 2 to totat
                // first bounce will count as positive 1 since the total is initially set to -1
                else
                {
                    while (h >= window)
                    {
                        h = h * bounce;
                        total = total + 2;
                    }
                    return total;
                }
            }
        }

    }
}
