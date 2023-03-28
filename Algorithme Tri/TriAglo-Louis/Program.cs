using System;
using System.Threading;
using System.Diagnostics;

namespace TriAglo_Louis
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;
            bool verification;
            int n;
            int element;
            int intervallemin;
            int intervallemax;
            Stopwatch chrono = new Stopwatch();
            long millisec;
            int quitter;
            int repeat;

            quitter = 0;
            question = "";
            verification = true;
            repeat = 0;


            appel mp = new appel();

            do
            {
                Console.WriteLine("Bonjour");
                Thread.Sleep(600);
                Console.WriteLine("Je suis un programme qui permet d'effectuer des tris sous plusieurs méthodes avec un tableau qui va être généré selon vos conditions");
                Thread.Sleep(600);
                Console.WriteLine("Je vais vous poser des questions dans 5 secondes, et vous devrez y répondre afin de générer correctement le tableau.");
                Thread.Sleep(7000);
                Console.Clear();
                do
                {
                    question = "-> Vous souhaitez combien d'élements dans le tableau qui va être généré?";
                    mp.LireReel(question, out n);
                    if (n < 1)
                    {
                        Console.WriteLine("Le tableau doit contenir au minimum 2 élements...");
                        verification = false;
                    } else
                    {
                        verification = true;
                    }
                } while (verification == false);
                element = n;
                Thread.Sleep(600);
                question = "A partir de quel nombre je peux générer dans le tableau qui va être généré?";
                mp.LireReel(question, out n);
                intervallemin = n;
                Thread.Sleep(600);
                verification = true;
                do
                {
                    question = "Jusqu'à quel nombre je peux générer dans le tableau qui va être généré?";
                    mp.LireReel(question, out n);
                    if (intervallemin > n)
                    {
                        Thread.Sleep(600);
                        Console.WriteLine("L'intervalle maximale doit être supérieur à l'intervalle minimale");
                        verification = false;
                    } else
                    {
                        verification = true;
                    }
                } while (verification == false);
                intervallemax = n;
                Thread.Sleep(600);
                Console.Clear();
                Thread.Sleep(600);
                Console.WriteLine("Génération du tableau en cours...");
                chrono = Stopwatch.StartNew();
                mp.GenereTableau(element, intervallemin, intervallemax, out int[] tableau);
                chrono.Stop();
                millisec = chrono.ElapsedMilliseconds;
                Thread.Sleep(600);
                Console.WriteLine($"Génération terminée... ({millisec}ms)");
                Console.WriteLine("Voici le tableau:");
                Thread.Sleep(300);
                mp.Concatenation(tableau, out string chaine);
                Console.WriteLine(chaine);
                do
                {
                    Console.WriteLine("\n \n \n");
                    Thread.Sleep(600);
                    Console.WriteLine("Dans 10 secondes, la console se reintialisera et vous proposera des options de tris.");
                    Thread.Sleep(10000);
                    // Console.Clear();
                    Console.WriteLine("Voici les nombreuses options de tris:\n");
                    Thread.Sleep(300);
                    Console.WriteLine("[+] Tri à bulle (1)\n");
                    Thread.Sleep(300);
                    Console.WriteLine("[+] Tri par insertion (2)\n");
                    Thread.Sleep(300);
                    Console.WriteLine("[+] Tri par intuitif (3)\n");
                    Thread.Sleep(300);
                    Console.WriteLine("[+] Tri par sélection (4)\n");
                    Thread.Sleep(300);
                    Console.WriteLine("[+] Tri par Shell (5)\n");
                    Thread.Sleep(300);
                    Console.WriteLine("[+] Tout les tris (6)\n \n");
                    Thread.Sleep(600);
                    do
                    {
                        verification = true;
                        question = "Quel option souhaitez-vous prendre? (Dites le numéro de l'option) ";
                        mp.LireReel(question, out n);
                        if (n < 1 || n > 6)
                        {
                            Thread.Sleep(300);
                            Console.WriteLine($"Aucune option n'existe avec ce que vous avez écrit({n}), merci de réécrire ici: ");
                            verification = false;
                        }
                        else
                        {
                            verification = true;
                        }
                    } while (verification == false);

                    if (n == 1)
                    {
                        chrono = Stopwatch.StartNew();
                        mp.TriBulle(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(600);
                        verification = false;
                        do
                        {
                            question = "Souhaitez-vous afficher le tableau (0 = non/1 = oui)? (Le tableau a été généré en " + millisec + "ms) ";
                            mp.LireReel(question, out n);
                            if (n == 1)
                            {
                                mp.Concatenation(tableau, out chaine);
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                verification = true;
                                Console.WriteLine(chaine);
                            }
                            else if (n == 1)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                Console.WriteLine("Pas de soucis!");
                                verification = true;
                            }
                        } while (verification == false);

                    }
                    else if (n == 2)
                    {
                        chrono = Stopwatch.StartNew();
                        mp.TriEncastrement(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(600);
                        verification = false;
                        do
                        {
                            question = "Souhaitez-vous afficher le tableau (0 = non/1 = oui)? (Le tableau a été généré en " + millisec + "ms) ";
                            mp.LireReel(question, out n);
                            if (n == 1)
                            {
                                mp.Concatenation(tableau, out chaine);
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                verification = true;
                                Console.WriteLine(chaine);
                            }
                            else if (n == 1)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                Console.WriteLine("Pas de soucis!");
                                verification = true;
                            }
                        } while (verification == false);
                    }
                    else if (n == 3)
                    {
                        chrono = Stopwatch.StartNew();
                        mp.TriIntuitif(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(600);
                        verification = false;
                        do
                        {
                            question = "Souhaitez-vous afficher le tableau (0 = non/1 = oui)? (Le tableau a été généré en " + millisec + "ms) ";
                            mp.LireReel(question, out n);
                            if (n == 1)
                            {
                                mp.Concatenation(tableau, out chaine);
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                verification = true;
                                Console.WriteLine(chaine);
                            }
                            else if (n == 1)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                Console.WriteLine("Pas de soucis!");
                                verification = true;
                            }
                        } while (verification == false);
                    }
                    else if (n == 4)
                    {
                        chrono = Stopwatch.StartNew();
                        mp.TriSelection(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(600);
                        verification = false;
                        do
                        {
                            question = "Souhaitez-vous afficher le tableau (0 = non/1 = oui)? (Le tableau a été généré en " + millisec + "ms) ";
                            mp.LireReel(question, out n);
                            if (n == 1)
                            {
                                mp.Concatenation(tableau, out chaine);
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                verification = true;
                                Console.WriteLine(chaine);
                            }
                            else if (n == 1)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                Console.WriteLine("Pas de soucis!");
                                verification = true;
                            }
                        } while (verification == false);
                    }
                    else if (n == 5)
                    {
                        chrono = Stopwatch.StartNew();
                        mp.TriShell(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(600);
                        verification = false;
                        do
                        {
                            question = "Souhaitez-vous afficher le tableau (0 = non/1 = oui)? (Le tableau a été généré en " + millisec + "ms) ";
                            mp.LireReel(question, out n);
                            if (n == 1)
                            {
                                mp.Concatenation(tableau, out chaine);
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                verification = true;
                                Console.WriteLine(chaine);
                            }
                            else if (n == 1)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("\n");
                                Console.WriteLine("Pas de soucis!");
                                verification = true;
                            }
                        } while (verification == false);
                    }
                    else if (n == 6)
                    {
                        chrono = Stopwatch.StartNew();
                        mp.TriEncastrement(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(100);
                        Console.WriteLine("[+] Tri par bulle - " + millisec + "ms;");

                        chrono = Stopwatch.StartNew();
                        mp.TriEncastrement(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(100);
                        Console.WriteLine("[+] Tri par insertion - " + millisec + "ms;");

                        chrono = Stopwatch.StartNew();
                        mp.TriIntuitif(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(100);
                        Console.WriteLine("[+] Tri par intuitif - " + millisec + "ms;");

                        chrono = Stopwatch.StartNew();
                        mp.TriSelection(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(100);
                        Console.WriteLine("[+] Tri par sélection - " + millisec + "ms;");

                        chrono = Stopwatch.StartNew();
                        mp.TriShell(ref tableau);
                        chrono.Stop();
                        millisec = chrono.ElapsedMilliseconds;
                        Thread.Sleep(100);
                        Console.WriteLine("[+] Tri par shell - " + millisec + "ms;");


                        


                    }

                    Thread.Sleep(500);
                    verification = true;
                    do
                    {
                        question = "Souhaitez-vous quitter? (0 - Non; 1 - Oui)";
                        mp.LireReel(question, out n);
                        if (n < 0 || n > 1)
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("J'attends une réponse similaire à 1 ou 0, rien d'autres...");
                            verification = false;
                            Thread.Sleep(100);
                        }
                        else
                        {
                            verification = true;
                        }


                    } while (verification == false);

                    if (n == 0)
                    {
                        Thread.Sleep(500);
                        verification = true;
                        do
                        {
                            Console.WriteLine("Souhaitez-vous reprendre le même tableau? (0 - non; 1 - oui");
                            mp.LireReel(question, out n);
                            if (n < 0 || n > 1)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("J'attends une réponse similaire à 1 ou 0, rien d'autres...");
                                verification = false;
                                Thread.Sleep(100);
                            }
                            else
                            {
                                verification = true;
                            }
                        } while (verification == false);
                        if (n == 0)
                        {
                            repeat = 0;
                        } else if (n == 1) {
                            repeat = 1;
                        }
                    else if (n == 1)
                    {
                        quitter = n;
                        repeat = 0;
                    }

                } while (repeat == 1);

                

            } while (quitter == 0);





        }
    }
}
