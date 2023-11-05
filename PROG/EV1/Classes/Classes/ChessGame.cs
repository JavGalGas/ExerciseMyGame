namespace Classes
{
    public class ChessGame
    {
        private List<ChessFigure>  FigureList = new List<ChessFigure>();

        public void AddFigureInList()
        {
            ChessFigure? f1 = ChessFigure.CreateFigure(0,0, ColorType.WHITE, FigureType.KNIGHT);
            if(ChessUtils.IsOnBoard(f1.GetX(), f1.GetY()))
            {
                FigureList.Add(f1);
            }
            return;
        }
        public int GetFigureCount()
        {
            return FigureList.Count;
        }
    }
}
