using TPVLib;

namespace TPV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tpv = ITPV.CreateNewTPV();
            Controllers.RunMainMenu(tpv);




           


            Console.ReadLine();/*==> string*/
            //Crear la clase UI y crear una función que muestre las principales opciones del menú principal
            //Al crear UI, está TERMINANTEMENTE PROHIBIDO utilizar Console.WriteLine ni Console.ReadLine en Program
            //Crear la clase Controllers, y crear la función RunMainMenu 
            //MVC
            //M modelo
            //V vista
            //C controlador (en el Main)

        }
    }
}