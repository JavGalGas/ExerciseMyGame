using System.Collections.Generic;
using System.Reflection;
using UDK;

namespace ExerciseMyGame
{
    public class MyWorld
    {
        class Rectangle
        {
            public int x;
            public int y;
            public double w;
            public double h;
        }

        private List<Character> Characters = new List<Character>();
        //Map map = new Map();

        public void CreateCharacters(int characterCount)
        {
            Characters.Clear();
            for (int i = 0; i < characterCount; i++)
            {
                Character pj1 = new Character();
                pj1.red = Utils.GetRandomBetween(0.1, 1);
                pj1.blue = Utils.GetRandomBetween(0.1, 1);
                pj1.green = Utils.GetRandomBetween(0.1, 1);
                pj1.alpha = 1.0;
                pj1.x = Utils.GetRandomBetween(1, 19);
                pj1.y = Utils.GetRandomBetween(1, 19);
                Characters.Add(pj1);
            }
        }

        public Character? GetCharacterAt(int index)
        {
            if (index < 0 || index >= Characters.Count)
                return null;
            return Characters[index];
        }

       
        public static void OutOfWorld()
        {

        }
    }
}
