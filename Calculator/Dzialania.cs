using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Dzialania
    {

        public int dodawanie()
        {

            int wynik = x + y;
            return wynik;
        }
        public int odejmowanie()
        {

            int wynik = x - y;
            return wynik;
        }
        public int mnozenie()
        {
            int wynik = x * y;
            return wynik;
        }
        public float dzielenie()
        {
            if (y != 0)
            {
                float wynik = x / y;
                return wynik;
            }
            else
            {
                float zero = 9999999999;
                return zero;
            }
        }
        public int dzielenieModulo()
        {
            int wynik = x % y;
            return wynik;
        }
        public void Values()
        {
            Value values = new Value();
            values.x = int.Parse(Console.ReadLine());
            values.y = int.Parse(Console.ReadLine());
            
        }
    }
    public class Value
    {
        public int x;
        public int y;

    }
}
