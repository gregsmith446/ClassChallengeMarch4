using System;

namespace CodeChallengeMarch4
{
    class Program
    {
        static void Main(string[] args)
        {
            BouncingBall dropTheBall = new BouncingBall();

            // test different cases here by changing inputs
            int result = dropTheBall.bouncingBall(3, 0.66, 1.5);

            // uncomment to see the result in the console
            // Console.WriteLine(result);
        }
    }
}
