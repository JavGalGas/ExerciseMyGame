namespace Classes
{
    class ChessUtils
    {
        public static int _movCount;

        public static void IncrementMoveCount()
        {
            _movCount++;
        }
        public static bool CanKnightMoveTo(ChessFigure figure, int targetX, int targetY, List<ChessFigure> figuresOnBoard)
        {
            if(!IsOnBoard(targetX, targetY))
                return false;
            return figure.GetFigureType() == FigureType.KNIGHT && AllowedKnightMove(figure, targetX, targetY); 
        }
        public static bool CanPawnMoveTo(int x, int y, FigureType chessType, int targetX, int targetY)
        {
            if (chessType == FigureType.PAWN)
            {

            }
        }
        public static bool CanKingMoveTo(ChessFigure figure, int targetX, int targetY, List<ChessFigure> figuresOnBoard)
        {
            return figure.GetFigureType() == FigureType.KING && AllowedKingMove(figure, targetX, targetY) && IsOnBoard(targetX, targetY);
        }
        public static bool CanQueenMoveTo(int x, int y, FigureType chessType, int targetX, int targetY)
        {
            if (chessType == FigureType.QUEEN)
            {

            }
        }
        public static bool CanRookMoveTo(int x, int y, FigureType chessType, int targetX, int targetY)
        {
            if (chessType == FigureType.ROOK)
            {

            }
        }
        public static bool CanBishopMoveTo(int x, int y, FigureType chessType, int targetX, int targetY)
        {
            if (chessType == FigureType.BISHOP)
            {

            }
        }

        public int GetMovementCount()
        {
            return _movCount;
        }
        public static bool HasBeenMoved()
        {
            return _movCount > 0;
        }
       
        public static bool IsOnBoard(ChessFigure figures, int x, int y)
        {
            if(figures == null)
                return false;
            return ((x>0 && x<=7) && (y>0 && y<=7)) && GetFigureAt(x, y, figures) ;
        }

        public static ChessFigure? GetFigureAt(int x, int y, List<ChessFigure> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                ChessFigure figure = list[i];
                if(x==figure.GetX() && y==figure.GetY())
                {
                    return figure;
                }
            }
            return null;
        }
        public static bool AllowedKnightMove(ChessFigure figure, int targetX, int targetY)
        {
            int x=figure.GetX(), y=figure.GetY();
            if(targetX==x+2 || targetX==x-2)
                return (targetY == y++ || targetY == y--) ? true : false;
            if(targetX==x++ || targetX==x--)
                return (targetY == y+2 || targetY==y-2) ? true : false;
            return false;

        }
        public static bool AllowedKingMove(ChessFigure figure, int targetX, int targetY)
        {
            int x = figure.GetX(), y = figure.GetY();
            for(int i = x-1; i<x+1;i++)
            {
                for (int j = y - 1; j < y + 1; j++)
                {
                    if (i == x && j == y)
                        continue;
                    if(i==targetX && j == targetY)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        public static bool AllowedRookMove(ChessFigure figure, int targetX, int targetY)
        {
            int x = figure.GetX(), y = figure.GetY();
        }

        public static Random r = new Random();
        public static int GetRandom()
        {
            return r.Next();
        }
        public static int GetRandomBetween(int min, int max)
        {
            return r.Next(min,max);
        }

        //hacer funciones IsOnBoard, GetFigureAt, AllowedKnightMove
    }     
}
