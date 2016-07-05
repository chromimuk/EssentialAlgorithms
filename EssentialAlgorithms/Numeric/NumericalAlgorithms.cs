using System;
using System.Collections.Generic;

namespace EssentialAlgorithms
{

    class NumericalAlgorithms
    {
        // Euclidean algorithm
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }


        public static List<int> FindPrimes(int max)
        {
            bool[] isComposite = new bool[max + 1];

            // cross out multiples of 2
            for (int i = 4; i < max; i = i + 2)
            {
                isComposite[i] = true;
            }

            int nextPrime = 3;
            int stopAt = (int) Math.Sqrt(max) + 1;

            while (nextPrime < stopAt)
            {
                // cross out multiple of this prime
                for (int i = nextPrime*2; i < max; i = i+nextPrime)
                {
                    isComposite[i] = true;
                }

                // move to the next prime, skipping even numbers
                nextPrime = nextPrime + 2;
                while (nextPrime <= max && isComposite[nextPrime])
                {
                    nextPrime = nextPrime + 2;
                }
            }

            // copy the primes in a list
            List<int> primes = new List<int>();
            for (int i=0; i<max; i++)
            {
                if (!isComposite[i])
                    primes.Add(i);
            }

            return primes;
        }


    }
}
