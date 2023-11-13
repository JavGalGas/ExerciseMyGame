namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DominoPiece f = new DominoPiece(1,2);

            //Card carta1=new Card(13,Palo.CLOVER);
            //carta1.IsValid();
            //carta1.GetValue();
            //carta1.GetPalo();
            //carta1.GetColor();
            //carta1.GetFigure();
            //carta1.IsFigure();
            DateTime time = new DateTime(0, 0, 0, 1, 3, 1857);
            time.GetDayOfWeek();




        }

        //el nuevo símbolo visto el (30-10-2023), una relación con un cuadrado blanco al final es el símbolo de Agregación.
        //si el cuadrado es negro, es el símbolo de Composición.
        //Cuando se elimina la clase seleccionada por Agregación, NO se elimina la clase que la seleccionaba.
        //Cuando se elimina la clase seleccionada por Composición, SÍ se elimina la clase que la seleccionaba.
    }
}