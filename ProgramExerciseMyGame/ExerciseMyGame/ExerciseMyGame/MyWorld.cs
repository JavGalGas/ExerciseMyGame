using System.Collections.Generic;
using System.Reflection;
using UDK;
using static UDK.IFont;

namespace ExerciseMyGame
{
    public class Rectangle
    {
        public double x;
        public double y;
        public double width = 10;
        public double height = 10;

        public double red, blue, green, alpha;

        public void Draw(ICanvas canvas)
        {
            canvas.FillShader.SetColor(red, green, blue, alpha);
            canvas.DrawRectangle(x, y, width, height);
        }
        public double GetRight()
        {
            return x + width;
        }
        public double GetLeft()
        {
            return x;
        }
        public double GetUp()
        {
            return y + height;
        }
        public double GetDown()
        {
            return y;
        }

        public bool IsIntersecting(Rectangle r1)
        {
            Rectangle r2 = MyWorld.GetCharacterAt(1);
            if (r1.GetLeft() < r2.GetRight()) 
                return false;
            else if (r1.GetUp() < r2.GetDown())
                return false;
            else if (r1.GetRight() < r2.GetLeft())
                return false;
            else if (r1.GetUp() < r2.GetDown())
                return false;
            return true;
        }
    }
    public class MyWorld
    {
        private List<Rectangle> Characters = new List<Rectangle>();


        public void CreateCharacters()
        {
            Characters.Clear();
            Rectangle? pj0 = new Rectangle();
            pj0.red = 0.0;
            pj0.blue = 0.0;
            pj0.green = 0.0;
            pj0.alpha = 1.0;
            pj0.x = 0;
            pj0.y = 0;
            Characters.Add(pj0);

            for (int i = 1; i < 10; i++)
            {
                Rectangle? pj1 = new Rectangle();
                pj1.red = Utils.GetRandomBetween(0.1, 1);
                pj1.blue = Utils.GetRandomBetween(0.1, 1);
                pj1.green = Utils.GetRandomBetween(0.1, 1);
                pj1.alpha = 1.0;
                pj1.x = Utils.GetRandomBetween(1, 19);
                pj1.y = Utils.GetRandomBetween(1, 19);
                pj1.width = Utils.GetRandomBetween(1, pj0.width-1);
                pj1.height = Utils.GetRandomBetween(1, pj0.height - 1);
                Characters.Add(pj1);
            }
        }

        public Rectangle? GetCharacterAt(int index)
        {
            if (index < 0 || index >= Characters.Count)
                return null;
            return Characters[index];
        }

        public int GetCharacterCount() 
        { 
            return Characters.Count;
        }

       
        public static void OutOfWorld(Rectangle r2)
        {
            Rectangle r1 = GetCharacterAt(0);
            if (r1.GetLeft() > r2.GetLeft())
                r2.x += r1.GetLeft() - r2.GetLeft();
            else if (r1.GetUp() < r2.GetUp())
                r2.y -= r2.GetUp() - r1.GetUp();
            else if (r1.GetRight() < r2.GetRight())
                r2.x-= r2.GetRight() - r1.GetRight();
            else if (r1.GetDown() > r2.GetDown())
                r2.y+= r1.GetDown() - r2.GetDown();
        }

       
    }
}
