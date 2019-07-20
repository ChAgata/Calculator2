using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Dzialania
    {
        public int x;
        public int y;
        public int dodawanie()
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            int wynik = x + y;
            return wynik;
        }
        public int odejmowanie()
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            int wynik = x - y;
            return wynik;
        }
        public int mnozenie()
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            int wynik = x * y;
            return wynik;
        }
        public string dzielenie()
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            if (y != 0)
            {
                int wynik = x / y;
                return wynik.ToString();
            }
            string error = "Nie dziel przez 0!!!";
            return error;
        }
        public int dzielenieModulo()
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            int wynik = x % y;
            return wynik;
        }
    }
}
