using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LA_1200_2_raviraj
{
    class Program
    {

        static void Main(string[] args)
        {

            //Variabeln
            bool run = true;
            int maxTrys = 30;
            Random random = new Random();

            // Regeln
            while (run)
            {
                int rnd = random.Next(1, 100);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("Willkomen zum Ratenspiel! \nIch habe eine Zahl zwischen 1 - 100 und Sie müssen es erraten! \nIhre Telepathe wird bewertet \nSie haben nur 30 Versuche übrig");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.Write("\nTippen Sie hier ihre Zahl: ");
                Console.ResetColor();

                // Anweisung
                int trys = 0;
                bool solved = false;
                while (!solved && trys < maxTrys)
                {
                    trys++;
                    int guess;
                    bool numericGuess;
                    do
                    {
                        numericGuess = int.TryParse(Console.ReadLine(), out guess);
                        if (!numericGuess)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine();
                            Console.Write("Bitte geben Sie eine Zahl zwischen 1 - 100 ein: ");
                            Console.ResetColor();
                        }
                    } while (!numericGuess);

                    // Tipps
                    if (guess > rnd)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        Console.Write(string.Format("Meine Nummer ist kleiner als {0}\nVersuchen Sie es nochmal: ", guess));
                        Console.ResetColor();
                    }
                    else if (guess < rnd)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        Console.Write(string.Format("Meine Nummer ist grösser als {0}\nVersuchen Sie es nochmal: ", guess));
                        Console.ResetColor();
                    }

                    // genügende Bewertung
                    else if (guess == rnd)
                    {
                        if (trys <= 15)
                        {
                            solved = true;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(string.Format("Sie haben gewonnen und haben nur {1} Versuche gebraucht", rnd, trys));

                            if (trys == 0)
                            {
                                Console.WriteLine("Ihre Note ist eine 6");
                            }
                            else if (trys == 1)
                            {
                                Console.WriteLine("Ihre Note ist eine 6");
                            }
                            else if (trys == 2)
                            {
                                Console.WriteLine("Ihre Note ist eine 6");
                            }
                            else if (trys == 3)
                            {
                                Console.WriteLine("Ihre Note ist eine 6");
                            }
                            else if (trys == 4)
                            {
                                Console.WriteLine("Ihre Note ist eine 5.8");
                            }
                            else if (trys == 5)
                            {
                                Console.WriteLine("Ihre Note ist eine 5.6");
                            }
                            else if (trys == 6)
                            {
                                Console.WriteLine("Ihre Note ist eine 5.5");
                            }
                            else if (trys == 7)
                            {
                                Console.WriteLine("Ihre Note ist eine 5.3");
                            }
                            else if (trys == 8)
                            {
                                Console.WriteLine("Ihre Note ist eine 5.1");
                            }
                            else if (trys == 9)
                            {
                                Console.WriteLine("Ihre Note ist eine 5");
                            }
                            else if (trys == 10)
                            {
                                Console.WriteLine("Ihre Note ist eine 4.8");
                            }
                            else if (trys == 11)
                            {
                                Console.WriteLine("Ihre Note ist eine 4.6");
                            }
                            else if (trys == 12)
                            {
                                Console.WriteLine("Ihre Note ist eine 4.5");
                            }
                            else if (trys == 13)
                            {
                                Console.WriteLine("Ihre Note ist eine 4.3");
                            }
                            else if (trys == 14)
                            {
                                Console.WriteLine("Ihre Note ist eine 4.1");
                            }
                            else if (trys == 15)
                            {
                                Console.WriteLine("Ihre Note ist eine 4");
                            }

                            // Gewinn-Musik
                            Console.ResetColor();
                            Console.Beep(264, 125);
                            Thread.Sleep(250);
                            Console.Beep(264, 125);
                            Thread.Sleep(125);
                            Console.Beep(297, 500);
                            Thread.Sleep(125);
                            Console.Beep(264, 500);
                            Thread.Sleep(125);
                            Console.Beep(352, 500);
                            Thread.Sleep(125);
                            Console.Beep(330, 1000);
                            Thread.Sleep(2250);
                        }


                        // ungenügende Bewertung
                        else if (trys > 15)
                        {
                            solved = true;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(string.Format("Sie haben leider verloren und haben {1} Versuche gebraucht", rnd, trys));
                            if (trys == 16)
                            {
                                Console.WriteLine("Ihre Note ist eine 3.8");
                            }
                            else if (trys == 17)
                            {
                                Console.WriteLine("Ihre Note ist eine 3.6");
                            }
                            else if (trys == 18)
                            {
                                Console.WriteLine("Ihre Note ist eine 3.5");
                            }
                            else if (trys == 19)
                            {
                                Console.WriteLine("Ihre Note ist eine 3.3");
                            }
                            else if (trys == 20)
                            {
                                Console.WriteLine("Ihre Note ist eine 3.1");
                            }
                            else if (trys == 21)
                            {
                                Console.WriteLine("Ihre Note ist eine 3");
                            }
                            else if (trys == 22)
                            {
                                Console.WriteLine("Ihre Note ist eine 2.8");
                            }
                            else if (trys == 23)
                            {
                                Console.WriteLine("Ihre Note ist eine 2.6");
                            }
                            else if (trys == 24)
                            {
                                Console.WriteLine("Ihre Note ist eine 2.5");
                            }
                            else if (trys == 25)
                            {
                                Console.WriteLine("Ihre Note ist eine 2.3");
                            }
                            else if (trys == 26)
                            {
                                Console.WriteLine("Ihre Note ist eine 2.1");
                            }
                            else if (trys == 27)
                            {
                                Console.WriteLine("Ihre Note ist eine 2");
                            }
                            else if (trys == 28)
                            {
                                Console.WriteLine("Ihre Note ist eine 1");
                            }
                            else if (trys == 29)
                            {
                                Console.WriteLine("Ihre Note ist eine 1");
                            }
                            Console.ResetColor();
                            Thread.Sleep(3000);
                        }

                    }



                }

                // alle Versuche verbraucht, Kursempfehlung und Programmschliessung
                if (trys == 30)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine(string.Format("\nSie haben es nicht geschafft. Sie müssen unbedingt einen Kurs besuchen \nKommen Sie wieder zurück wenn Sie Ihre Leistung verbessert haben!"));
                    Console.ResetColor();
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine("Ich wünsche Ihnen viel Erfolg beim Kurs!");
                    Console.ResetColor();
                    Thread.Sleep(2500);
                    Environment.Exit(-1);
                }

                // fragen ob der User erneut Spielen wil
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Möchten das Spiel erneut spielen?");
                Console.WriteLine("Tippen Sie 'ja' wenn sie weiter spielen wollen oder drücken Sie die Enter-Taste, wenn Sie das Programm schliessen möchten");
                Console.ResetColor();
                string rerun = Console.ReadLine();

                if (!rerun.Equals("ja"))
                {
                    run = false;
                }

            // Programm schliessen
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Danke fürs Spielen!");
            Console.WriteLine("Das Programm wird beendet...");
            Console.ResetColor();
            Environment.Exit(-1);
        }
    }
}