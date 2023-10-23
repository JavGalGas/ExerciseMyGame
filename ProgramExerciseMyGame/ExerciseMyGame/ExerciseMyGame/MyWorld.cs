using System.Collections.Generic;
using System.Reflection;
using UDK;

namespace ExerciseMyGame
{
    public class MyWorld
    {
        class Rectangle
        {
            public int x=0;
            public int y=0;
            public double w=10.0;
            public double h=10.0;
        }

        internal List<Character> Characters = new List<Character>();
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

        public int GetCharacterCount() 
        { 
            return Characters.Count;
        }

       
        public static void OutOfWorld()
        {

        }
    }
}
