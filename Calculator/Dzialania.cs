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
            Value values = Values();
            int wynik = values.x + values.y;
            return wynik;
        }
        public int odejmowanie()
        {
            Value values = Values();
            int wynik = values.x - values.y;
            return wynik;
        }
        public int mnozenie()
        {
            Value values = Values();
            int wynik = values.x * values.y;
            return wynik;
        }
        public float dzielenie()
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
        public int dzielenieModulo()
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
