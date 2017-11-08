using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lib1
{
    public class Prime
    {
        public static bool IsSquare(int candidate)
        {
            double temp;
            temp = Math.Sqrt(candidate);
            if (Math.Floor(temp) == temp)
                return true;
            else return false;
        }
        public static bool IsPrime(int candidate)
        {
            //return false;
            int divisor;
            if (candidate < 0) return false; //ERROR
            if (candidate < 3) return true; //is prime!
            bool isDivisible = false;
            for (divisor = candidate / 2; divisor >= 2; divisor--)
            {
                if (candidate % divisor == 0) isDivisible = true;
            }
            return !isDivisible;
            
        }

        public static string ListPrimesLTEQ(int highvalue) //Lists primes LessThanEqualTo
        {
            string s="";
            int i;
            for (i = highvalue; i > 0; i--)
            {
                if (IsPrime(i))
                {
                    //is prime, add to the string
                    if (s.Length == 0)
                        s = "Primes found: " + i;
                    else
                        s = s + ", " + i;
                }
            }
            return s;
        }





    }
}
