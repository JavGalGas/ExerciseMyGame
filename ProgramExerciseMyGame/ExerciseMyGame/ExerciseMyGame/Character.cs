using UDK;

namespace ExerciseMyGame
{
    public class Character
    {
        public double x = 0;
        public double y = 0;

        public double width = 0;
        public double height = 0;

        public double red = 1, blue = 1, green = 1, alpha = 1;
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
        public double GetArea()
        {
            return width * height;
        }
    }  
}
