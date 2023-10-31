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
        private List<DominoPiece> _pieceList = new List<DominoPiece>();  /*Esto ya está escrito en la relación, cuando lo escribimos en Método relacional*/

        public DominoPiece ExtractPieceAt(int index)
        {
            if(index < 0 || index >= GetPieceCount())
            {
                var p = _pieceList[index];
                _pieceList.RemoveAt(index);
                return p;
            }
            return null;
        }

        public DominoPiece ExtractPiece()
        {
            int random = GetRandomBetween(0, GetPieceCount() - 1);
            return ExtractPieceAt(random);
        }

        public int GetPieceCount()
        {
            return _pieceList.Count;
        }

        public void AddPiece(DominoPiece piece) //añade una pieza a la lista DominoPiece
        {
            if (ContainsPiece(piece) == false)
                _pieceList.Add(piece);
        }

        public DominoPiece? GetPieceAt(int index) //saca los valores de la ficha de la lista DominoPiece, de la posicion index
        {
            DominoPiece piece = _pieceList[index];
            piece?.GetValue1();
            piece?.GetValue2();
            return piece;
        }

        public void Swap(DominoPiece p1, DominoPiece p2) //cambia las posiciones de dos fichas de domino de la lista
        {
            DominoPiece aux = p1;
            p1= p2;
            p2= aux;

        }

        public void Shuffle() 
        {
            
        }

        public bool ContainsPiece(DominoPiece piece)
        {
            if(piece == null)
                return false;
            for(int i = 0; i < GetPieceCount(); i++)
            {
                if(_pieceList[i].IsEquals(piece))
                    return true;
            }
            return false;
        }

        public int IndexOf(DominoPiece piece)
        {
            if (piece == null)
                return -1;
            for (int i = 0; i < GetPieceCount()-1; i++)
            {
                if (piece.IsEquals(GetPieceAt(i)))
                    return i;
            }
            return -1;
        }


        private static Random r = new Random();
        public static int GetRandomBetween(int min, int max)
        {
            int dif = max - min + 1;
            return min + (r.Next() % dif);
        }

    }
}
