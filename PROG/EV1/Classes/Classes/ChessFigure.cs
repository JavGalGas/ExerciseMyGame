namespace Classes
{
    public enum ColorType
    {
        BLACK,
        WHITE,
    }
    public enum FigureType
    {
        KNIGHT,
        PAWN,
        KING,
        ROOK,
        BISHOP,
        QUEEN,
    }
    class ChessFigure
    {
        private int _x, _y;
        private ColorType _color;
        private FigureType _figureType;

        private ChessFigure(int x, int y, ColorType color, FigureType figure)
        {
            _x = x;
            _y = y;
            _color = color;
            _figureType = figure;
        }

        private ChessFigure() 
        { 
        
        }

        /*public bool IsValid()
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
        }*/
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
            //return (IsValid()) ? _color : ColorType.UNKNOWN;
            return _color;
        }
        public FigureType GetFigureType()
        {
            //return (IsValid()) ? _figureType : Classes.FigureType.UNKWOWN;
            return _figureType;
        }
        public void MoveTo(int x, int y)
        {
            if(ChessUtils.IsOnBoard(x,y))
            _x = x;
            _y = y;
            ChessUtils.IncrementMoveCount();
        }
        public void Promove(ChessFigure figure, FigureType typePromoved)
        {
            if(figure.GetFigureType()==FigureType.PAWN && figure.GetY()==8)
            {
                CreateFigure(figure.GetX(), figure.GetY(), figure.GetColor(), typePromoved);
                Swap();
                DeleteFigure(ChessGame.GetFigureCount()-1);
            }
        }



        public static ChessFigure? CreateFigure(int x, int y, ColorType color, FigureType figure)
        {
            /*if(color != ColorType.WHITE || color!= ColorType.BLACK)
            {
                return null;
            }*/
            if(!ChessUtils.IsOnBoard(x,y))
                return null;
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
            return new ChessFigure(x, y, color, figure);
        }


    }
    class Rectangle
    {
        private int _x;
        private int _y;
        public Rectangle(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public Rectangle GetRectangle()
        {
            Rectangle rectangle = new Rectangle(_x, _y);
            return rectangle;
        }
    }
}
