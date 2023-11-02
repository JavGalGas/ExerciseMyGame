namespace Classes
{
    public enum ColorType
    {
        BLACK,
        WHITE,
        UNKNOWN,
    }
    public enum FigureType
    {
        KNIGHT,
        PAWN,
        KING,
        TOWER,
        BISHOP,
        QUEEN,
    }
    class ChessFigure
    {
        private int _x, _y;
        private ColorType _color;
        private FigureType _figureType;

        public bool IsValid()
        {

        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
        public ColorType GetColor()
        {
            return _color;
        }
        public FigureType FigureType()
        {
            return _figureType;
        }
        internal void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;

        }
        public ? Promove()
        {

        }
        public Rectangle GetRectangle()
        {

        }



    }
}
