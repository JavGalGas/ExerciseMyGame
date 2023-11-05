namespace Classes
{
    class ChessUtils
    {
        private int _movCount=0;
        public static bool CanKnightMoveTo(ChessFigure figure, int targetX, int targetY, List<ChessFigure> figuresOnBoard)
        {
            if(figure.GetFigureType() == FigureType.KNIGHT)
            {
                if (!IsOnBoard(targetX, targetY))
                {
                    return false;
                }
                return true;
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
            return x!=0 ? true : false;
        }
       
        public static bool IsOnBoard(int x, int y)
        {
            return ((x>0 && x<=7) && (y>0 && y<=7));
        }

        public void GetFigureAt(int x, int y)
        {
            for (int i = 0;i < ChessGame.GetFigureCount();i++) { }
        }
        public bool AllowKnightMove(int x, int y)
        {

        }
        //hacer funciones IsOnBoard, GetFigureAt, AllowKnightMove
    }     
}
