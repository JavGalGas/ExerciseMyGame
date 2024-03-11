using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public static string? ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("|  Elige una operación a realizar: |");
            Console.WriteLine("|  1-Buscar Producto               |");
            Console.WriteLine("|  2-Buscar Productos              |");
            Console.WriteLine("|  3-Añadir Producto               |");
            Console.WriteLine("|  4-Eliminar Producto             |");
            Console.WriteLine("|  5-Actualizar Producto           |");
            Console.WriteLine("|  6-Cerrar Programa               |");
            Console.WriteLine(" ---------------------------------- ");
            string? option = Console.ReadLine();
            return option;
        }
        public static void CaseGetProduct(ITPV tpv)
        {
            Console.Write("Seleccione el id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            Product? p= tpv.GetProductWithId(id);
            if (p == null)
            {
                return;
            }
            Console.WriteLine(" ------------------------------------------------------------ ");
            Console.WriteLine("| ID   Name        Description         Price   Stock   IVA   |");
            Console.Write("| " + p.Id);
            for(int i=0; i<8-p.Id.ToString().Length)+ "    " + p.Name + "       " + p.Description + "       " + p.Price + "       " + p.Stock + "       " + p.IVA);
            Console.WriteLine("  |");
            Console.WriteLine("|                                                            |");
            Console.WriteLine(" ------------------------------------------------------------ ");
            Console.ReadLine();
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
            Console.Write("Diga cuánto es el IVA: ");
            double IVA = Convert.ToDouble(Console.ReadLine());
            Product product = new Product()
            {
                Id = id,
                Name = name,
                Description = description,
                Price = price,
                Stock = stock,
                IVA = IVA
            };
            Console.WriteLine("Producto añadido correctamente. El id es : " + tpv.AddProduct(product));
            Console.ReadLine();
        }

        public static void CaseUpdateProduct(ITPV tpv)//modificar
        {
            Console.Write("Seleccione el id: ");
            long id = Convert.ToInt64(Console.ReadLine());
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
            Console.Write("Diga cuánto es el IVA: ");
            double IVA = Convert.ToDouble(Console.ReadLine());
            Product product = new Product()
            {
                Id = id,
                Name = name,
                Description = description,
                Price = price,
                Stock = stock,
                IVA = IVA
            };
            tpv.UpdateProductWithId(id, product);
            Console.WriteLine("Producto actualizado.");
            Console.ReadLine();
        }

        public static void CaseRemoveProduct(ITPV tpv)
        {
            //var product = Console.ReadLine();
            //tpv.RemoveProduct(product);
        }

        public static void CaseExit(ITPV tpv, out bool runProgram)
        {
            Console.WriteLine("Hasta luego.");
            Console.ReadLine();
            Console.WriteLine("Cerrando programa...");
            runProgram = false;
        }

        public static void ShowProduct(ITPV tpv)
        {
            throw new NotImplementedException();
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
