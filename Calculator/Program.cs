using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                int dzialanie = Menu();
                Dzialania klasa = new Dzialania();
                switch (dzialanie)
                {
                    case 1:
                        Console.WriteLine("Wybrałeś Dodawanie. Wprowadz dwie liczby.");
                        int wynikDodawania = klasa.dodawanie();
                        Console.WriteLine(wynikDodawania);
                        break;
                    case 2:
                        Console.WriteLine("Wybrałeś Odejmowanie Wprowadz dwie liczby.");
                        int wynikOdejmowania = klasa.odejmowanie();
                        Console.WriteLine(wynikOdejmowania);
                        break;
                    case 3:
                        Console.WriteLine("Wybrałeś Mnożenie");
                        int wynikMnozenia = klasa.mnozenie();
                        Console.WriteLine(wynikMnozenia);
                        break;
                    case 4:
                        Console.WriteLine("Wybrałeś Dzielenie");
                        int wynikDzielenia = klasa.dzielenie();
                        Console.WriteLine(wynikDzielenia);
                        break;
                    case 5:
                        Console.WriteLine("Wybrałeś Dzielenie Modulo");
                        int wynikModulo = klasa.dzielenieModulo();
                        Console.WriteLine(wynikModulo);
                        break;
                    default:
                        Console.WriteLine("Wybrałeś numer spoza zakresu. Wybierz jeszcze raz.");
                        break;
                }               
                Console.ReadLine();
            }
            while (true);  
        }
        private static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz numer działania:\n 1. Dodawanie \n 2. Odejmowanie \n 3. Mnożenie \n 4. Dzielenie \n 5. Modulo");
            int dzialanie = Int32.Parse(Console.ReadLine());
            return dzialanie;
        }
    }
}
