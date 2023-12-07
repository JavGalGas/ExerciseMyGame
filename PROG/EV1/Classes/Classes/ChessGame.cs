namespace Classes
{
    public class ChessGame
    {
        private static List<ChessFigure>  FigureList = new List<ChessFigure>();


        public static void AddFigureInList(ChessFigure? f1)
        {
            if(f1 == null)
                return;
            //ChessFigure? f1 = ChessFigure.CreateFigure(ChessUtils.GetRandomBetween(0,8), ChessUtils.GetRandomBetween(0, 8), ColorType.WHITE, FigureType.KNIGHT);
            if(ChessBoard.IsOnBoard(f1.GetX(), f1.GetY()))
            {
                FigureList.Add(f1);
            }
            return;
        }

        public bool IsThereFigureAt(int x, int y) 
        { 
            for(int i = 0; i < GetFigureCount(); i++)
            {
                if(GetFigureAt(i).GetX()==x && GetFigureAt(i).GetY() == y)
                    return true;
            }
            return false;
        }
        public static bool IsInList(ChessFigure figure)
        {
            for(int i = 0; i < GetFigureCount(); i++)
            {
                if (figure == FigureList[i])
                    return true;
            }
            return false;
        }
        public static void ClearFigures() 
        { 
            FigureList.Clear();
        }

        public static int GetFigureCount()
        {
            return FigureList.Count;
        }
        public static ChessFigure GetFigureAt(int index)
        { 
            return FigureList[index];
        }
        public static void DeleteFigure(int index)
        {
            FigureList.RemoveAt(index);
        }
        public static void Swap(ChessFigure? f1, ChessFigure? f2)
        {
            if(f1 == null || f2 == null)
                return;
            ChessFigure aux = f1.Clone();
            f1 = f2;
            f2 = aux;
        }
        

    }
}
