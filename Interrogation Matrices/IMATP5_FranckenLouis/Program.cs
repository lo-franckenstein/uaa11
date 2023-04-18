using System;
using System.Threading;

namespace IMATP5_FranckenLouis
{
    class Program
    {
        static void Main(string[] args)
        {
            appel mp = new appel();
            string question;
            int n;
            bool verif;
            bool view;
            bool leave;

            {

                Console.WriteLine("Bonjour");
                Thread.Sleep(500);
                Console.WriteLine("Bienvenue dans le programme de génération de Triangle de Pascal");
                Thread.Sleep(500);

                do // Boucle pour forcer l'utilisateur a encoder le bon nombre (Supérieur à 0)
                {
                    question = "Quel est la taille du triangle Pascal souhaitée?";
                    mp.LireReel(question, out n);
                    if (n > 0)
                    {
                        verif = true;
                    }
                    else
                    {
                        verif = false;
                    }

                } while (verif == false);

                Thread.Sleep(500);
                Console.WriteLine("Bien reçu!");
                Thread.Sleep(500);
                Console.Write("Nous sommes en train de construire votre tableau");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.WriteLine(".");

                Console.WriteLine("");
                Thread.Sleep(100);
                mp.MatPas(n, out int[,] matrice);
                Console.WriteLine("Génération terminée !");
                Thread.Sleep(500);


                Console.Write("Nous sommes en train de l'afficher");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.WriteLine(".");

                mp.MatrCon(matrice, out string tableau);
                Thread.Sleep(100);
                Console.WriteLine("Voici le tableau:");
                Console.WriteLine("");
                Thread.Sleep(250);
                Console.WriteLine(tableau);

                do
                {
                    Console.WriteLine("");
                    question = "Souhaitez-vous afficher une chaîne de caractères contenant le développement correspondant à la puissance N de votre matrice? (0 = oui, 1 = Non)";
                    mp.LireReel(question, out n);
                    if (n == 0)
                    {
                        verif = true;
                        view = true;
                    }
                    else if (n == 1)
                    {
                        view = false;
                        verif = true;
                    }
                    else
                    {
                        verif = false;
                        view = false;
                        Thread.Sleep(500);
                        Console.WriteLine("Vous avez mal répondu à la question");
                    }
                } while (verif == false);

                if (view == true)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Bien reçu!");
                    Thread.Sleep(500);
                    Console.Write("Nous sommes en train de le réaliser");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.WriteLine(".");

                    Console.WriteLine("");
                    Thread.Sleep(100);
                    mp.MatPui(n, matrice, out string puissance);
                    Console.WriteLine("Génération terminée !");
                    Thread.Sleep(500);


                    Console.Write("Nous sommes en train de l'afficher");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(250);
                    Console.WriteLine(".");
                    Thread.Sleep(0);
                    Console.WriteLine("");
                    Console.WriteLine(puissance);
                }
                do
                {
                    Console.WriteLine("");
                    question = "Souhaitez-vous quitter? (0 = oui, 1 = Non)";
                    mp.LireReel(question, out n);
                    if (n == 0)
                    {
                        verif = true;
                        leave = true;
                    }
                    else if (n == 1)
                    {
                        verif = false;
                        leave = false;
                        Console.Clear();
                    }
                    else
                    {
                        verif = false;
                        leave = false;
                        Thread.Sleep(500);
                        Console.WriteLine("Vous avez mal répondu à la question");
                    }
                } while (verif == false);



            } while (leave == false);





        }
    }
}
