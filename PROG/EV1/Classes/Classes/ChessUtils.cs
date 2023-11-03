namespace Classes
{
    class ChessUtils
    {
        private int _movCount = 0;
        public static bool CanKnightMoveTo(int x, int y, FigureType chessType, int targetX, int targetY)
        {
            if(chessType== FigureType.KNIGHT)
            {
                if((targetX == x+30 || targetX== x-30) && (targetY == y+10 || targetY == y + 10))
                    return true;
                else if((targetX == x + 10 || targetX == x - 10) && (targetY == y + 30 || targetY == y + 30))
                    return true;
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
        public bool IsMoving()
        {
            return GetMovementCount() > 0;
        }

    }     
}
