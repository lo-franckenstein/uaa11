using System;
using System.Threading;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            double quitter;
            double modele;
            double hauteur;
            string resultat;
            string question;
            Thread.Sleep(2000);
            Console.WriteLine("Bienvenue");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenue sur le programme de dessin: 'DrawX'");
            Thread.Sleep(3000);
            do 
            {
                do
                {
                    Thread.Sleep(3000);
                    question = "Quel modèle de dessin voulez - vous obtenir ? (0 = Standard Square; 1 = Diagonal right; 2 = Diagonal left; 3 = Pyramid): ";
                    LireReel(question, out modele);
                
                        if (modele > 3 || modele < 0)
                        {
                            Thread.Sleep(2000);
                            Console.WriteLine("Aucun numéro de modèle existe avec votre numéro cité... Merci de prendre un numéro valable.");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                } while (modele > 3 || modele < 0);


                Thread.Sleep(1000);
                question = "Votre carré d'X doit posséder combien de X en hauteur: ";
                LireReel(question, out hauteur);
                Thread.Sleep(3000);
                Console.WriteLine("");


                if (modele == 0)
                {
                    if (hauteur >= 1)
                    {
                        Carrestandard(hauteur, out resultat);
                        Console.WriteLine(resultat);
                    }
                    else
                    {
                        Console.WriteLine("Votre hauteur doit être égale ou supérieur à 1 sinon cela ne marchera pas...");
                    }
                }

                if (modele == 1)
                {
                    if (hauteur >= 1)
                    {
                        Diagonaleright(hauteur, out resultat);
                        Console.WriteLine(resultat);
                    }
                    else
                    {
                        Console.WriteLine("Votre hauteur doit être égale ou supérieur à 1 sinon cela ne marchera pas...");
                    }
                }

                if (modele == 2)
                {
                    if (hauteur >= 1)
                    {
                        Diagonaleleft(hauteur, out resultat);
                        Console.WriteLine(resultat);
                    }
                    else
                    {
                        Console.WriteLine("Votre hauteur doit être égale ou supérieur à 1 sinon cela ne marchera pas...");
                    }
                }

                if (modele == 3)
                {
                    if (hauteur >= 1)
                    {
                        Pyramid(hauteur, out resultat);
                        Console.WriteLine(resultat);
                    }
                    else
                    {
                        Console.WriteLine("Votre hauteur doit être égale ou supérieur à 1 sinon cela ne marchera pas...");
                    }
                }
                
                

                do {
                    Thread.Sleep(1000);
                    question = "Souhaitez - vous refaire un petit tour dans le programme DrawX? (0 = Oui    1 = Non): ";
                    LireReel(question, out quitter);
                    if (quitter < 0 || quitter > 1)
                    {

                        Thread.Sleep(1000);
                        Console.WriteLine("Merci de donner une réponse correspondant à 0 ou 1...");
                        Thread.Sleep(1000);
                        Console.WriteLine("");
                    }
                } while (quitter != 0 && quitter != 1);
            

            } while (quitter != 1);



        }

        static void Carrestandard(double hauteur, out string resultat)
        {
            double compteur;
            double minicompteur;
            compteur = 0;
            resultat = "";
            do
            {
                minicompteur = 0;
                do
                {
                    resultat = resultat + "X";
                    minicompteur = minicompteur + 1;
                } while (hauteur != minicompteur);
                resultat = resultat + "\n";
                compteur = compteur + 1;
            } while (hauteur != compteur);

        }

        static void Diagonaleright(double hauteur, out string resultat)
        {
            resultat = "";
            double compteurA;
            compteurA = 0;
            double compteurB;

            do
            {
                compteurB = 0;
                do
                {
                    
                    if (compteurA == compteurB)
                    {
                        resultat = resultat + "O";
                    } else
                    {
                        resultat = resultat + "X";
                    }
                    compteurB = compteurB + 1;
               

                } while (compteurB != hauteur);
                resultat = resultat + "\n";
                compteurA = compteurA + 1;
            } while(compteurA != hauteur);
        }

        static void Diagonaleleft(double hauteur, out string resultat)
        {
            resultat = "";
            double compteurA;
            compteurA = 0;
            double compteurB;

            do
            {
                compteurB = 0;
                do
                {

                    if (compteurA + compteurB == hauteur - 1)
                    {
                        resultat = resultat + "O";
                    }
                    else
                    {
                        resultat = resultat + "X";
                    }
                    compteurB = compteurB + 1;


                } while (compteurB != hauteur);
                resultat = resultat + "\n";
                compteurA = compteurA + 1;
            } while (compteurA != hauteur);
        }

        static void Pyramid(double hauteur, out string resultat)
        {
            double col;

            resultat = "";

            col = 2 * hauteur - 1;
        
            for (int compteurA = 1; compteurA <= hauteur; compteurA++)
            {
                for (int compteurB = 1; compteurB <= col; compteurB++)
                {
                    if (compteurB <= hauteur - compteurA || compteurB >= hauteur + compteurA)
                    {
                        resultat = resultat + "0";
                    } else
                    {
                        resultat = resultat + "X";
                    }
                }
                resultat = resultat + "\n";
            }
            
        }

        static void LireReel(string question, out double n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!double.TryParse(nUser, out n))
            {
                Console.WriteLine("");
                Console.WriteLine("Vous avez fait une erreur, merci de respecter la question...");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.Write(question);
                nUser = Console.ReadLine();
            }
        }

        

        
    }
}
