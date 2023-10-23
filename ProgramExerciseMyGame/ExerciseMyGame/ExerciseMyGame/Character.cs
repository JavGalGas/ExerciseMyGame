using UDK;

namespace ExerciseMyGame
{
    public class Character
    {
        public double x;
        public double y;

        public double w;
        public double h;

        public double red, blue, green, alpha;
    }
    public static void Draw(ICanvas canvas)
    {
        canvas.FillShader.SetColor(red, green, blue, alpha);
        canvas.DrawRectangle(x, y, w, h);
    }
}
