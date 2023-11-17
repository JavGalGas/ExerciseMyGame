namespace BigNumbers
{
    public class BigNumber
    {
        private List<int> _list= new List<int>();

        public BigNumber(long value)
        {
            Set(value);
        }
        public BigNumber (string value)
        {
            Set (value);
        }

        public void Set(long value)
        {
            while (value / 10 != 0)
            {
                _list.Add((int)(value % 10));
            }
        }
        public void Set(string value)
        {
            for (int i = value.Length-1; i > 0; i--)
            {
                char c = value[i];
                int n = c - '0';
                _list.Add(n);
            }
        }
        public string DigitToString()
        {
            string result = "";
            for(int i=GetDigitCount()-1; i>0; i--);
            {
                result = result + ToString();

            }
        }

        public static BigNumber Add(BigNumber n1, BigNumber n2) //sumar dos números, si pasa del 9 suma al siguiente dígito
        {
            BigNumber number = new BigNumber();
            return number;
        }
        public static BigNumber Substract(BigNumber n1, BigNumber n2) // restar 2 numeros
        {
            BigNumber number = new BigNumber();
            return number;
        }
        public static BigNumber Multiply(BigNumber n1, BigNumber n2) // multiplicar 2 números
        {
            BigNumber number = new BigNumber();
            return number;
        }
        public static BigNumber Divide(BigNumber n1, BigNumber n2) // dividir 2 numeros <-- Module
        {
            BigNumber number = new BigNumber();
            return number;
        }
        public static BigNumber Module(BigNumber n1, BigNumber n2) // conseguir el resto de la división de 2 numeros --> Divide
        {
            BigNumber number = new BigNumber();
            return number;
        }
        public int GetDigitCount()
        {
            return _list.Count();
        }
        public int GetDigitAt(int index)
        {
            return _list[index];
        }
        public void Clone()
        {

        }
    }
}
