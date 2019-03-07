using System;

public class BouncingBall
{
    public int bouncingBall(double h, double bounce, double window)
    {
        // if any of these are true, exit the program with a -1
        // this means the given numbers are in some way invalid
        int total = -1;

        if (h < 0 && window >= h && bounce <= 0 && bounce >= 1)
        {
            return total;
        }
        // count how many times the ball passed by window
        // each time the height is > window, add 2 to total
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
