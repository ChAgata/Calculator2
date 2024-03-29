﻿using System;
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
                try
                {
                    int wybor = int.Parse(Menu());
                    Dzialania klasa = new Dzialania();
                    switch (wybor)
                    {
                        case 1:
                            Console.WriteLine("Wybrałeś Dodawanie. Wprowadddz dwie liczby.");
                            int wynikDodawania = klasa.Dodawanie();
                            Console.WriteLine(wynikDodawania);
                            break;
                        case 2:
                            Console.WriteLine("Wybrałeś Odejmowanie. Wprowadddz dwie liczby.");
                            int wynikOdejmowania = klasa.Odejmowanie();
                            Console.WriteLine(wynikOdejmowania);
                            break;
                        case 3:
                            Console.WriteLine("Wybrałeś Mnożenie. Wprowadddz dwie liczby.");
                            int wynikMnozenia = klasa.Mnozenie();
                            Console.WriteLine(wynikMnozenia);
                            break;
                        case 4:
                            Console.WriteLine("Wybrałeś Dzielenie. Wprowadddz dwie liczby.");

                            try
                            {
                                float wynikDzielenia = klasa.Dzielenie();
                                Console.WriteLine(wynikDzielenia);
                            }
                            catch (DivideByZeroException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Wybrałeś Dzielenie Modulo. Wprowadddz dwie liczby.");
                            int wynikModulo = klasa.DzielenieModulo();
                            Console.WriteLine(wynikModulo);
                            break;
                        case 0:
                            Console.Clear();
                            return;
                        default:
                            Console.WriteLine("Wybrałeś numer spoza zakresu. Wybierz jeszcze raz.");
                            break;
                    }
                    Console.ReadLine();
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Podaj odpowiednią liczbę!");
                    Console.ReadLine();
                }
            }
            while (true);
            
        }
        private static string Menu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz numer działania:\n 1. Dodawanie \n 2. Odejmowanie \n 3. Mnożenie \n 4. Dzielenie \n 5. Modulo \n 0. Wyjście");
                string dzialanie = Console.ReadLine();
                return dzialanie;
        }
    }
}
