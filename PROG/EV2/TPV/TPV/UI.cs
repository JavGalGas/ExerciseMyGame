using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib
{
    internal class UI
    {
        //public static int ReadOption()
        //{
        //    string input = Console.ReadLine();
        //    if (input == null)
        //        return -1;
        //    if (int.TryParse(input, out int option))
        //        return option;
        //    else
        //        Console.WriteLine("Not a valid entry.");
        //    return 0;
        //}

        public static int ShowMainMenu()
        {
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("|  Elige una operación a realizar: |");
            Console.WriteLine("|  1-Buscar Producto               |");
            Console.WriteLine("|  2-Buscar Productos              |");
            Console.WriteLine("|  3-Añadir Producto               |");
            Console.WriteLine("|  4-Eliminar Producto             |");
            Console.WriteLine("|  5-Actualizar Producto           |");
            Console.WriteLine("|  6-Cerrar Programa               |");
            Console.WriteLine(" ---------------------------------- ");
            var option = Console.Read();
            return option;
        }
        public static void CaseGetProduct(ITPV tpv)
        {
            Console.Write("Seleccione el id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            tpv.GetProductWithId(id);
        }
        public static void CaseGetProducts(ITPV tpv)
        {
            Console.Write("Seleccione el id de inicio: ");
            int offset = Convert.ToInt32(Console.ReadLine());
            Console.Write("Seleccione el id final: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            tpv.GetProducts(offset, limit);
        }
        public static void CaseAddProduct(ITPV tpv)
        {
            Product product = new Product();
            Console.Write("Diga el id del producto: ");
            long id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Diga el nombre del producto: ");
            string? name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ponga una descripción al producto: ");
            string? description = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ponga un precio al producto: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Diga cuánto es el stock del producto: ");
            int stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Diga cuánto es el stock del producto: ");
            double IVA = Convert.ToDouble(Console.ReadLine());
            product.Id = id;
            product.Name = name;
            product.Description = description;
            product.Price = price;
            product.Stock = stock;
            product.IVA = IVA;
            tpv.AddProduct(product);

        }

        public static void CaseUpdateProduct(ITPV tpv)
        {
            //Product product = Console.ReadLine();
            //tpv.UpdateProduct(product);
        }

        public static void CaseRemoveProduct(ITPV tpv)
        {
            //var product = Console.ReadLine();
            //tpv.RemoveProduct(product);
        }

        public static void CaseExit(ITPV tpv, out bool runProgram)
        {
           runProgram = false;
        }



        //public static long StringToLong(string? value)
        //{
        //    if (value == null)
        //        return long.MinValue;

        //    long result = 0;
        //    int count = value.Length;
        //    for (int i = 0; i < count; i++)
        //    {
        //        long n = (long)(value[i] * Math.Pow(10, count - i));
        //        result += n;
        //    }
        //    return result;
        //}

        //public static int StringToInt(string? value)
        //{
        //    if (value == null)
        //        return int.MinValue;

        //    int result = 0;
        //    int count = value.Length;

        //    for (int i = 0; i < count; i++)
        //    {
        //        int n = (int)(value[i] * Math.Pow(10, count - i));
        //        result += n;
        //    }
        //    return result;
        //}
    }
}
