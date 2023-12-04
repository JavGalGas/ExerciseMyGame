namespace EmGame
{
    public class EmGame
    {
        public EmGame(int x, int y )
        {
            EmGame emGame = new EmGame(x,y);
            emGame.Start(50,10,80,12);
            emGame.GetWinner();
        }
        public void Start(int x, int y, int z, int a)
        {
        }
        public TeamType GetWinner()
        {
           
        }

        public void PlayTurn(WarZone warZone)
        {

        }

        public static Random r = new Random();
        
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
}
