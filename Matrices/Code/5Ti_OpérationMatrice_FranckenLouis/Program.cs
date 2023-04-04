using System;
using System.Threading;
using System.Diagnostics;

namespace _5Ti_OpérationMatrice_FranckenLouis
{
    class Program
    {
        static void Main(string[] args)
        {
            appel mp = new appel();
            int rows;
            int column;
            string question;
            int n;
            int[,] matrice;
            string tableau;
            Stopwatch chrono = new Stopwatch();
            long millisec;
            bool verif;
            bool sousverif;
            int[,] matrice1;
            int[,] matrice2;

            do
            {

                Thread.Sleep(2000);
                Console.WriteLine("Bienvenue sur le programme dédiée aux matrices");
                Thread.Sleep(1000);
                Console.WriteLine("Avant de commencer une addition ou une multiplication, je vous propose de générer deux matrices selon vos envies");
                Thread.Sleep(500);
                Console.WriteLine("");
                Console.WriteLine("[1] Commençons avec la première matrice:");
                Thread.Sleep(200);


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Construction & affichage Première matrice
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                do
                {
                    question = "     [1] Combien de ligne(s) souhaitez-vous voir sur la première matrice? ";
                    mp.LireReel(question, out rows);
                    if (rows > 0)
                    {
                        verif = true;
                    }
                    else
                    {
                        verif = false;
                        Console.WriteLine("Vous devez mettre choisir un nombre strictement positif. Je répète donc: \n");
                    }
                } while (verif == false);
                Thread.Sleep(100);
                do
                {
                    question = "     [1] Combien de colonne(s) souhaitez-vous voir sur la première matrice? ";
                    mp.LireReel(question, out column);
                    if (column > 0)
                    {
                        verif = true;
                    }
                    else
                    {
                        verif = false;
                        Console.WriteLine("Vous devez mettre choisir un nombre strictement positif. Je répète donc: \n");
                    }
                } while (verif == false);
                Thread.Sleep(100);
                Console.Clear();
                chrono = Stopwatch.StartNew();
                Console.WriteLine("Génération en cours");
                mp.MatrGen(rows, column, out matrice1);
                chrono.Stop();
                millisec = chrono.ElapsedMilliseconds;
                Console.WriteLine($"La génération est terminée... ({millisec} ms)");
                Thread.Sleep(500);
                Console.WriteLine("Affichage de la première matrice dans quelques instants...");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(500);
                mp.MatrCon(matrice1, out tableau);
                Console.WriteLine(tableau);
                do
                {
                    Console.WriteLine("Appuyez sur enter pour continuer et faire la deuxième matrice...");
                } while (Console.ReadKey().Key != ConsoleKey.Enter);
                Console.Clear();






                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Construction & affichage Deuxième matrice
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("");
                Console.WriteLine("[1] Commençons avec la première matrice:");
                Thread.Sleep(200);
                
                do
                {
                    question = "     [1] Combien de ligne(s) souhaitez-vous voir sur la deuxième matrice? ";
                    mp.LireReel(question, out rows);
                    if (rows > 0)
                    {
                        verif = true;
                    }
                    else
                    {
                        verif = false;
                        Console.WriteLine("Vous devez mettre choisir un nombre strictement positif. Je répète donc: \n");
                    }
                } while (verif == false);
                Thread.Sleep(100);
                do
                {
                    question = "     [1] Combien de colonne(s) souhaitez-vous voir sur la deuxième matrice? ";
                    mp.LireReel(question, out column);
                    if (column > 0)
                    {
                        verif = true;
                    }
                    else
                    {
                        verif = false;
                        Console.WriteLine("Vous devez mettre choisir un nombre strictement positif. Je répète donc: \n");
                    }
                } while (verif == false);
                Thread.Sleep(100);
                Console.Clear();
                chrono = Stopwatch.StartNew();
                Console.WriteLine("Génération en cours");
                mp.MatrGen(rows, column, out matrice2);
                chrono.Stop();
                millisec = chrono.ElapsedMilliseconds;
                Console.WriteLine($"La génération est terminée... ({millisec} ms)");
                Thread.Sleep(500);
                Console.WriteLine("Affichage de la deuxième matrice dans quelques instants...");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(500);
                mp.MatrCon(matrice2, out tableau);
                Console.WriteLine(tableau);
                do
                {
                    Console.WriteLine("Appuyez sur enter pour continuer et faire la deuxième matrice...");
                } while (Console.ReadKey().Key != ConsoleKey.Enter);
                Console.Clear();


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Opérations
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                Console.WriteLine("Voici deux types d'opérations, à vous de choisir!");
                Thread.Sleep(500);
                Console.WriteLine("     [1] Addition de deux matrices");
                Thread.Sleep(50);
                Console.WriteLine("     [2] Multiplication de deux matrices");
                Thread.Sleep(500);

                // Choix de l'opération
                do
                {
                    Console.WriteLine("");
                    question = "Que choississez-vous? ";
                    Thread.Sleep(500);
                    mp.LireReel(question, out n);
                    if (n == 1 || n == 2)
                    {
                        verif = true;
                    }
                    else
                    {
                        verif = false;
                        Console.WriteLine("Vous devez mettre 1 ou 2, pas autre chose... Je répète donc: \n");
                    }
                } while (verif == false);
                Console.Clear();
                Thread.Sleep(500);
                Console.Write("Calcul en cours: /");
                for (int i = 0; i < 21; i++)
                {
                    Console.Write("\\");
                    Thread.Sleep(50);
                    Console.Write("/");
                    Thread.Sleep(50);
                }


                if (n == 1) // Addition
                {
                    mp.MatrAdd(matrice1, matrice2, out matrice, out verif);
                    Console.Write("> || ");
                    Console.WriteLine("Calcul terminé! ||");
                    Thread.Sleep(500);
                    Console.WriteLine("");
                    if (verif == true)
                    {
                        do
                        {
                            Console.WriteLine("Appuyez sur enter pour voir le résultat...");
                        } while (Console.ReadKey().Key != ConsoleKey.Enter);
                        Console.Clear();
                        mp.MatrCon(matrice, out tableau);
                        Console.WriteLine(tableau);
                    }
                    else
                    {
                        Console.WriteLine("Le calcul est impossible!");
                    }

                    do
                    {
                        Console.WriteLine("Appuyez sur enter pour continuer");
                    } while (Console.ReadKey().Key != ConsoleKey.Enter);

                }
                else if (n == 2) // Multiplication
                {
                    mp.MatrMul(matrice1, matrice2, out matrice, out verif);
                    Console.Write("> || ");
                    Console.WriteLine("Calcul terminé! ||");
                    Thread.Sleep(500);
                    Console.WriteLine("");
                    if (verif == true)
                    {
                        do
                        {
                            Console.WriteLine("Appuyez sur enter pour voir le résultat...");
                        } while (Console.ReadKey().Key != ConsoleKey.Enter);
                        Console.Clear();
                        mp.MatrCon(matrice, out tableau);
                        Console.WriteLine(tableau);
                    }
                    else
                    {
                        Console.WriteLine("Le calcul est impossible!");
                    }

                    do
                    {
                        Console.WriteLine("Appuyez sur enter pour continuer");
                    } while (Console.ReadKey().Key != ConsoleKey.Enter);
                }
                Console.Clear();

                do // DEmande de quitter
                {
                    question = "Souhaitez-vous quitter? (0 - oui/1 - non) ";
                    mp.LireReel(question, out n);

                    if (n == 0) // NON
                    {
                        verif = true;
                        sousverif = true;
                        Console.Clear();
                    }
                    else if (n == 1) // OUI
                    {
                        verif = false;
                        sousverif = true;
                        Console.Clear();
                    }
                    else // Erreur
                    {
                        sousverif = false;
                    }
                } while (sousverif == false);

            } while (verif == false);



        

            












        }
    }
}
