using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM1
{
    public class Utils
    {
        public static Random r = new Random();

        public static int Random()
        { 
            int result = r.Next();
            return result;
        }

        public static int GetRandomBetween(int min, int max)
        {
            return r.Next(min, max);
        }
        public static double GetDoubleRandomBetween(double min, double max)
        {
            double result= r.NextDouble()*(max-min)+min;
            return result;
        }
        public static int GetGreaterOfTwo(int a, int b)
        {
            return a > b ? a : b;
        }
        public static int GetGreaterOfThree(int a, int b, int c) 
        {
            return GetGreaterOfTwo(a, GetGreaterOfTwo(b, c));
        }
        public static void Swap(Runner a, Runner b) 
        { 
            Runner aux = new Runner();
            aux = a;
            a = b;
            b = aux;
        }
    }
}
