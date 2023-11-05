namespace Classes
{
    class ChessUtils
    {
        public int _movCount;
        public static bool CanKnightMoveTo(ChessFigure figure, int targetX, int targetY, List<ChessFigure> figuresOnBoard)
        {
            if(figure.GetFigureType() == FigureType.KNIGHT && AllowedKnightMove(figure, targetX, targetY))
            {
                return !IsOnBoard(targetX, targetY) ? false : true;
            }
            return false;
        }
        /*public static bool CanPawnMoveTo(int x, int y, FigureType chessType, int targetX, int targetY)
        {
            if (chessType == FigureType.PAWN)
            {

            }
        }
        public static bool CanKingMoveTo(int x, int y, FigureType chessType, int targetX, int targetY)
        {
            if (chessType == FigureType.KING)
            {

            }
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
        }*/

        public int GetMovementCount()
        {
            return _movCount;
        }
        public static bool HasBeenMoved(int x, int y)
        {
            if(x < x || y < y)
            {
                _movCount++;
                return true;
            }
                
            return false;
        }
       
        public static bool IsOnBoard(int x, int y)
        {
            return ((x>0 && x<=7) && (y>0 && y<=7));
        }

        public void GetFigureAt(int x, int y)
        {
            for (int i = 0;i < ChessGame.GetFigureCount();i++) { }
        }
        public bool AllowedKnightMove(ChessFigure figure, int targetX, int targetY)
        {
            int x=figure.GetX(), y=figure.GetY();
            if(targetX==x+2 || targetX==x-2)
                return (targetY == y++ || targetY == y--) ? true : false;
            if(targetX==x++  || targetX==x--)
                return (targetY == y+2 || targetY==y-2) ? true : false;
            return false;

        }
        //hacer funciones IsOnBoard, GetFigureAt, AllowedKnightMove
    }     
}
