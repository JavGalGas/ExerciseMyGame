namespace Classes
{
    class ChessUtils
    {
        private int _movCount=0;
        public static bool CanKnightMoveTo(ChessFigure figure, int targetX, int targetY, List<ChessFigure> figuresOnBoard)
        {
            if(figure.GetFigureType() == FigureType.KNIGHT)
            {
                if(!IsOnBoard(targetX, targetY))
                    return false;

                return false;
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
        public bool HasBeenMoved()
        {
            return IsMoving() ? true : false;
        }
        public static bool IsMoving()
        {
            //_movCount++;
            //return GetMovementCount() > 0;
            return true;
        }
        public bool IsOnBoard(int x, int y)
        {
            return ((x>0 && x<=7) && (y>0 && y<=7));
        }

        //hacer funciones IsOnBoard, GetFigureAt, AllowKnightMove
    }     
}
