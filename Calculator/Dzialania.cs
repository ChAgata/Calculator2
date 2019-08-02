using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Dzialania
    {
        
        public int Dodawanie()
        {
            Value values = Values();
            int wynik = values.x + values.y;
            return wynik;
        }
        public int Odejmowanie()
        {
            Value values = Values();
            int wynik = values.x - values.y;
            return wynik;
        }
        public int Mnozenie()
        {
            Value values = Values();
            int wynik = values.x * values.y;
            return wynik;
        }
        public float Dzielenie()
        {
            Value values = Values();
            if (values.y != 0)
            {
                float wynik = values.x / values.y;
                return wynik;
            }
            else
            {                
                float zero = 9999999999;
                return zero;
            }
        }
        public int DzielenieModulo()
        {
            Value values = Values();
            int wynik = values.x % values.y;
            return wynik;
        }
        public Value Values()
        {
            Value values = new Value();
            values.x = int.Parse(Console.ReadLine());
            values.y = int.Parse(Console.ReadLine());
            return values;

        }
    }
    public class Value
    {
        public int x;
        public int y;
        
    }
}
