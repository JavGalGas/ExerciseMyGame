namespace Classes
{
    public class ChessGame
    {
        private static List<ChessFigure>  FigureList = new List<ChessFigure>();

        public void AddFigureInList()
        {
            ChessFigure? f1 = ChessFigure.CreateFigure(0,0, ColorType.WHITE, FigureType.KNIGHT);
            if(ChessUtils.IsOnBoard(f1.GetX(), f1.GetY()))
            {
                FigureList.Add(f1);
            }
            return;
        }
        public static int GetFigureCount()
        {
            return FigureList.Count;
        }
        private static void DeleteFigure(int index)
        {
            FigureList.RemoveAt(index);
        }
    }
}
