using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Moneda
    {
        E_500,
        E_200,
        E_100,
        E_50,
        E_20,
        E_10,
        E_5,
        E_2,
        E_1,
        E_050,
        E_020,
        E_010,
        E_005,
        E_002,
        E_001,
    }
    public class CoinChange
    {
        public double ToNumber(Moneda coin)
        {
            if (coin == Moneda.E_500)
                return  50000;
            else if (coin == Moneda.E_200)
                return  20000;
            else if (coin == Moneda.E_100)
                return  10000;
            else if (coin == Moneda.E_50)
                return  5000;
            else if (coin == Moneda.E_20)
                return  2000;
            else if (coin == Moneda.E_10)
                return  1000;
            else if (coin == Moneda.E_5)
                return  500;
            else if (coin == Moneda.E_2)
                return  200;
            else if (coin == Moneda.E_1)
                return  100;
            else if (coin == Moneda.E_050)
                return  50;
            else if (coin == Moneda.E_020)
                return  20;
            else if (coin == Moneda.E_010)
                return  10;
            else if (coin == Moneda.E_005)
                return  5;
            else if (coin == Moneda.E_002)
                return  2;
            return  1;

        }

        public Moneda ToMoneda(int centims)
        {
            if (centims == 50000)
                return Moneda.E_500;
            else if (centims == 20000)
                return Moneda.E_200;
            else if (centims == 10000)
                return Moneda.E_100;
            else if (centims == 5000)
                return Moneda.E_50;
            else if (centims == 2000)
                return Moneda.E_20;
            else if (centims == 1000)
                return Moneda.E_10;
            else if (centims == 500)
                return Moneda.E_5;
            else if (centims == 200)
                return Moneda.E_2;
            else if (centims == 100)
                return Moneda.E_1;
            else if (centims == 50)
                return Moneda.E_050;
            else if (centims == 20)
                return Moneda.E_020;
            else if (centims == 10)
                return Moneda.E_010;
            else if (centims == 5)
                return Moneda.E_005;
            else if (centims == 2)
                return Moneda.E_002;
            return Moneda.E_001;
        }

        public List<Moneda> GetCoins(int centims) //hacer una lista con las monedas de cada tipo que necesitas en la conversión, repitiendose si necesitas más de una. Ej:429 son [200,200,20,5,2,2,1]
        {
            List<Moneda> list = new List<Moneda>();
             for()
        }
    }
}
