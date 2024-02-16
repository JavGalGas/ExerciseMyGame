using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib
{
    internal class UI
    {
        public static void Case1(ITPV tpv)
        {
            Console.Write("Seleccione el id: ");
            long id = StringToLong(Console.ReadLine());
            tpv.GetProductWithId(id);
        }
        public static void Case2(ITPV tpv)
        {
            Console.Write("Seleccione el id de inicio: ");
            int offset = StringToInt(Console.ReadLine());
            Console.Write("Seleccione el id final: ");
            int limit = StringToInt(Console.ReadLine());
            tpv.GetProducts(offset, limit);
        }
        public static void Case3(ITPV tpv)
        {
            
            //Product product = Console.ReadLine();
            //tpv.AddProduct(product);
        }

        internal static void Case4(ITPV tpv)
        {
            //Product product = Console.ReadLine();
            //tpv.UpdateProduct(product);
        }

        public static void Case5(ITPV tpv)
        {
            //var product = Console.ReadLine();
            //tpv.RemoveProduct(product);
        }

        public static void Case6(ITPV tpv, out bool runProgram)
        {
           runProgram = false;
        }



        public static long StringToLong(string? value)
        {
            if (value == null)
                return long.MinValue;

            long result = 0;
            int count = value.Length;
            for (int i = 0; i < count; i++)
            {
                long n = (long)(value[i] * Math.Pow(10, count - i));
                result += n;
            }
            return result;
        }

        public static int StringToInt(string? value)
        {
            if (value == null)
                return int.MinValue;

            int result = 0;
            int count = value.Length;

            for (int i = 0; i < count; i++)
            {
                int n = (int)(value[i] * Math.Pow(10, count - i));
                result += n;
            }
            return result;
        }
    }
}
