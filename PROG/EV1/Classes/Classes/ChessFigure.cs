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
        ROOK,
        BISHOP,
        QUEEN,
        UNKWOWN,
    }
    class ChessFigure
    {
        private int _x, _y;
        private ColorType _color;
        private FigureType _figureType;

        private ChessFigure(ColorType color, FigureType figure)
        {
            _color = color;
            _figureType = figure;
        }

        public bool IsValid()
        {
            if(_color == ColorType.BLACK || _color == ColorType.WHITE)
            {
                switch(_figureType)
                {
                    case Classes.FigureType.PAWN:  return true;
                    case Classes.FigureType.KING:  return true;
                    case Classes.FigureType.ROOK: return true;
                    case Classes.FigureType.KNIGHT: return true;
                    case Classes.FigureType.BISHOP: return true;
                    case Classes.FigureType.QUEEN: return true;
                    default: return false;
                }
            }
            return false;
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
            return (IsValid()) ? _color : ColorType.UNKNOWN;
        }
        public FigureType FigureType()
        {
            return (IsValid()) ? _figureType : Classes.FigureType.UNKWOWN;
        }
        internal void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;
            return;
        }
        public void Promove(ChessFigure figure, FigureType typePromoved )
        {
            if(figure.FigureType()!=Classes.FigureType.PAWN)
            {
                return;
            }
            CreateFigure(figure.GetColor(), typePromoved);
            MoveTo(_x, _y);
            return;
        }
        /*public Rectangle GetRectangle()
        {
            
        }*/
        public static ChessFigure? CreateFigure(ColorType color, FigureType figure)
        {
            if(color != ColorType.WHITE || color!= ColorType.BLACK)
            {
                return null;
            }
            if (figure != Classes.FigureType.QUEEN)
                return null;
            if (figure != Classes.FigureType.KNIGHT)
                return null;
            if (figure != Classes.FigureType.KING)
                return null;
            if (figure != Classes.FigureType.BISHOP)
                return null;
            if (figure != Classes.FigureType.PAWN)
                return null;
            if (figure != Classes.FigureType.ROOK)
                return null;
            return new ChessFigure(color, figure);
        }


    }
    class Rectangle
    {
        private int _x;
        private int _y;
        Rectangle(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
