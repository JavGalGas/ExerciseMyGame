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
            _list.Add ((int)(value));
        }
        public void Set(string value)
        {
            for (int i = value.Length-1; i >= 0; i--)
            {
                char c = value[i];
                int n = c - '0';
                _list.Add(n);
            }
        }
        public string ConvertToString()
        {
            string result = "";
            for(int i=GetDigitCount()-1; i>=0; i--)
            {
                result = result + GetDigitAt(i).ToString();
            }
            return result;
        }

        public static BigNumber Add(BigNumber n1, BigNumber n2) //sumar dos números, si pasa del 9 suma al siguiente dígito
        {
            BigNumber result = new BigNumber(0);
            int aux = 0;
            List<int> list = new List<int>();

            for(int i = n1.GetDigitCount(); i < n2.GetDigitCount(); i++)
            {
                n1._list.Add(0);
            }
            for (int i = n2.GetDigitCount(); i < n1.GetDigitCount(); i++)
            {
                n2._list.Add(0);
            }
            for (int i = 0; i<n1.GetDigitCount(); i++)
            {
                int sum = n1.GetDigitAt(i) + n2.GetDigitAt(i) + aux;
                aux = sum/10;
                sum %= 10;
                list.Add(sum);
            }
            if (aux != 0)
                list.Add(aux);
            result._list = list;
            return result;
        }
        public static BigNumber Substract(BigNumber n1, BigNumber n2) // restar 2 numeros
        { //modificar
            BigNumber result = new BigNumber(0);
            int aux = 0;
            List<int> list = new List<int>();

            for (int i = n1.GetDigitCount(); i < n2.GetDigitCount(); i++)
            {
                n1._list.Add(0);
            }
            for (int i = n2.GetDigitCount(); i < n1.GetDigitCount(); i++)
            {
                n2._list.Add(0);
            }
            for (int i = 0; i<n1.GetDigitCount(); i++)
            {
                int sub = n1.GetDigitAt(i)  - n2.GetDigitAt(i) - aux;
                aux = sub / 10;
                sub += 10;
                list.Add(sub);
            }
            if (aux != 0)
                list.Add(aux);
            result._list = list;
            return result;
        }
        public static BigNumber Multiply(BigNumber n1, BigNumber n2) // multiplicar 2 números
        { //modificar (incluye doble for y creación de varios BigNumber, además de añadir ceros en la última posición de la lista y utilizar la función Add)
            BigNumber result = new BigNumber(0);
            int aux = 0;
            List<int> list = new List<int>();

            for (int i = n1.GetDigitCount(); i < n2.GetDigitCount(); i++)
            {
                n1._list.Add(0);
            }
            for (int i = n2.GetDigitCount(); i < n1.GetDigitCount(); i++)
            {
                n2._list.Add(0);
            }
            for (int i = 0; i < n1.GetDigitCount(); i++)
            {
                int sum = n1.GetDigitAt(i) + n2.GetDigitAt(i) + aux;
                if (sum > 9)
                {
                    aux = sum / 10;
                    sum %= 10;
                }
                list.Add(sum);
            }
            if (aux != 0)
                list.Add(aux);
            result._list = list;
            return result;
        }
        //public static BigNumber Divide(BigNumber n1, BigNumber n2) // dividir 2 numeros <-- Module
        //{
        //    BigNumber number = new BigNumber();
        //    return number;
        //}
        //public static BigNumber Module(BigNumber n1, BigNumber n2) // conseguir el resto de la división de 2 numeros --> Divide
        //{
        //    BigNumber number = new BigNumber();
        //    return number;
        //}
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
