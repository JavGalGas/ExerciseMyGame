using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DominoDeck
    {
        private List<DominoPiece>? pieces;  /*Esto ya está escrito en la relación, cuando lo escribimos en Método relacional*/

        public DominoPiece ExtractPieceAt(int index)
        {

        }
        public DominoPiece ExtractPiece()
        {

        }
        public int GetPieceCount()
        {
            return pieces.count;
        }
        public void AddPiece(DominoPiece piece) //añade una pieza a la lista DominoPiece
        {
            for (int i = 1; i < 10; i++)
            {
                piece = new DominoPiece(GetRandom(1,6),GetRandom(1,6));
                pieces?.Add(piece);
            }
        }
        public DominoPiece? GetPieceAt(int index) //saca los valores de la ficha de la lista DominoPiece, de la posicion index
        {
            DominoPiece piece = pieces[index];
            piece?.GetValue1();
            piece?.GetValue2();
        }
        public void Shuffle() //cambia las posiciones de dos fichas de domino de la lista
        {
            
        }
        public static int GetRandom(int min, int max)
        {
            int dif = max - min + 1;
            return min + (Random % dif);
        }
    }
}
