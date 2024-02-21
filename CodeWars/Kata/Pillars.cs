using System;

namespace CodeWars.Kata
{
    public class Pillars
    {
        public static int PillarDistance(int numPill, int dist, int width)
        { 
            if (numPill < 2)
            {
                return 0;   
            }
            int sumOfPillarWidth = (numPill * width) - (2 * width);
            int sumOfDistances = ((numPill - 1) * dist) * 100;

            return sumOfDistances + sumOfPillarWidth;
        }

    }
}
