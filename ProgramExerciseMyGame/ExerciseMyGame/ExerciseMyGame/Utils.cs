namespace ExerciseMyGame
{
    internal class Utils
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

        public static bool Intersect(Characters r1,Characters r2)
        {
            if (r2.x > r1.x + r1.w)
                return false;
            if (r2.y < r1.y + r1.h)
                return false;
            if (r1.x > r2.x + r2.w)
                return false;
            if (r1.y > r2.y + r2.h)
                return false;
            return true;
        }
    }
    //funcion intrersect + funcion doble for para pasar  por la lista de personajes, funcion se sale del mundo
}
