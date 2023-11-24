using System.Runtime.CompilerServices;

namespace BigNumbers
{
    public class BigNumber
    {
        private List<int> _list= new List<int>();

        public BigNumber()
        {

        }

        public BigNumber(long value)
        {
                Set(value);
        }
        public BigNumber (string value)
        {
            if(StringIsValid(value))
                Set (value);
            Correct();
        }

        public void Set(long value)
        {
            while (Math.Abs(value) / 10 > 0)
            {
                _list.Add((int)(Math.Abs(value) % 10));
                value /= 10;
            }
            _list.Add((int) value);
            
        }
        public void Set(string value)
        {
            for (int i = value.Length-1; i >= 0; i--)
            {
                char c = value[i];
                if (c == '-' && i==0)
                {
                    _list[_list.Count - 1] *=-1 ;
                }
               else
               {
                    int n = c - '0';
                    _list.Add(n);
               }
            }

        }
        public bool StringIsValid(string value)
        {
            for (int i = 1; i < value.Count(); i++)
            {
                char c = value[i];
                int n = c - '0';
                if (n < 0 || n > 9)
                    return false;
            }
            return true;
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

        public void Correct()
        {
            int i = _list.Count-1 ;
            while (GetDigitAt(i)==0)
            {
                _list.RemoveAt(i--);
            }
                
        }

        public static BigNumber Add(BigNumber n1, BigNumber n2) //sumar dos números, si pasa del 9 suma al siguiente dígito
        {
            BigNumber result = new BigNumber();
            int aux = 0;

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
                result._list.Add(sum);
            }
            if (aux != 0)
                result._list.Add(aux);
            return result;
        }
        public static BigNumber Substract(BigNumber n1, BigNumber n2) // restar 2 numeros
        { //modificar
            BigNumber result = new BigNumber();
            int aux = 0;

            for (int i = n1.GetDigitCount(); i < n2.GetDigitCount(); i++)
            {
                n1._list.Add(0);
            }
            for (int i = n2.GetDigitCount(); i < n1.GetDigitCount(); i++)
            {
                n2._list.Add(0);
            }
            for (int i = 0; i < n2.GetDigitCount(); i++)
                n2._list[i] *= -1;
            for (int i = 0; i < n1.GetDigitCount(); i++)
            {
                int sum = n1.GetDigitAt(i) + n2.GetDigitAt(i) + aux;
                aux = sum / 10;
                sum %= 10;
                result._list.Add(sum);
            }
            if (aux != 0)
                result._list.Add(aux);
            return result;
        }
        public static BigNumber Multiply(BigNumber n1, BigNumber n2) // multiplicar 2 números
        { //modificar (incluye doble for y creación de varios BigNumber, además de añadir ceros en la última posición de la lista y utilizar la función Add)
            BigNumber list1 = new BigNumber();
            BigNumber list2 = new BigNumber();
            int aux = 0;
            int count = 0;
            for (int i = n2.GetDigitCount()-1; i >=0; i--)
            {
                list1._list.Clear();
                for(int j = n1.GetDigitCount()-1; j >= 0; j--)
                {
                    int mul = n1.GetDigitAt(j) * n2.GetDigitAt(i) + aux;
                    if (mul > 9)
                    {
                        aux = mul / 10;
                        mul%= 10;
                    }
                    list1._list.Add(mul);

                }
                for (int k=count; k>0; k--)
                {
                    list1._list.Add(0);
                }
                list1._list.Reverse();
                list2 = Add(list2, list1);
                count++;
                
            }
            if (aux != 0)
                list2._list.Add(aux);
            return list2;
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
        public BigNumber Clone()
        {
            return this.Clone();
        }
        public static BigNumber Clone(BigNumber number)
        {
            BigNumber clone = new BigNumber();

            for(int i =0; i< number._list.Count; i++)
                clone._list.Add(number._list[i]);
            return clone;
        }
    }
}
