

namespace Classes
{
    class DominoPiece
    {
       
        private int value1;
        private int value2;

        private DominoPiece(int v1, int v2)
        {
            /*this.*/value1 = v1;
            /*this.*/value2 = v2;
        }

        public int GetValue1()
        {
            return value1;
        }

        public int GetValue2()
        {
            return value2;
        }

        public int GetTotalValue()
        {
            return value1 + value2;
        }

        public bool IsDouble()
        {
            if(value1 == value2)
                return true;
            return false;
        }


        public static DominoPiece? CreatePiece(int v1, int v2)
        {
            if (v1 > 6 || v1 < 0)
                return null;
            else if (v2 > 6 || v2 < 0)
                return null;
            return new DominoPiece(v1, v2);
        }
    }
}
