namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DominoPiece f = new DominoPiece(1,2);
            
            Card carta1=new Card(2,Palo.HEARTS);
            carta1.IsValid();
            carta1.GetValue();
            carta1.GetPalo();
            carta1.GetColor();
            carta1.GetFigure();
            carta1.IsFigure();




        }

        //el nuevo símbolo visto el (30-10-2023), una relación con un cuadrado blanco al final es el símbolo de Agregación.
        //si el cuadrado es negro, es el símbolo de Composición.
        //Cuando se elimina la clase seleccionada por Agregación, NO se elimina la clase que la seleccionaba.
        //Cuando se elimina la clase seleccionada por Composición, SÍ se elimina la clase que la seleccionaba.
    }
}