using System.Drawing;

namespace ExerciseMyGame
{
    public class Utils
    {
        private static Random r = new Random();

        public static double GetRandom()
        {
            return r.NextDouble();
        }

        public static double GetRandomBetween(double min, double max)
        {
            //return (r.NextDouble() * (max - min)) + min;
            double r = GetRandom();
            double v = r * (max - min);
            return v + min;
        }

        
    }
    //funcion intersect + funcion doble for para pasar  por la lista de personajes, funcion se sale del mundo
}
