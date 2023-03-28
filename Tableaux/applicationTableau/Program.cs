using System;
using System.Threading;

namespace applicationTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionTableau appel = new OptionTableau();
            bool leave = false;
            bool demande = false;
            string question;
            Random alea2 = new Random();
            int[] tableau;
            int n;






            Console.WriteLine("Bonjour à vous, bienvenue sur le programme de tableaux. Je vais vous proposer plusieurs choses que je peux faire pour vous, et vous devrez en sélectionner un!");
            do
            {
                Console.WriteLine("Voici ce que je peux faire pour vous:");
                Console.WriteLine("\n 1) Dupliquer et afficher un tableau sous forme de String");
                Console.WriteLine("\n 2) Depuis 2 tableaux, le premier possédant une série de chiffre qui désigne le nombre de jours par mois, le deuxième qui liste tout les mois de l'année, je peux les combiner sous cette forme (Mois + Nombre de jours + Mois + Nombres de jours + Mois + etc)");
                Console.WriteLine("\n 3) Générer des nombres aléatoires entre deux intervalles données par vous et le nombre de nombre à générer est définie également par vous");
                Console.WriteLine("\n 4) Séparer depuis un tableau composé de nombres aléatoires, dans deux tableaux, les nombres paires ainsi que les nombres impaires. Bien sûr, pour compléter mes tableaux, j'ajoute des zéros");
                question = "Quel tâche vous souhaitez que je réalise?";
                appel.LireEntier(question, out n);

                if(n == 1)
                {
                    Thread.Sleep(2000);
                    Console.Clear();
                    Thread.Sleep(200);
                    Console.WriteLine("________               .__  .__               __  .__               ");
                    Console.WriteLine("\\______ \\  __ ________ |  | |__| ____ _____ _/  |_|__| ____   ____  ");
                    Console.WriteLine(" |    |  \\|  |  \\____ \\|  | |  |/ ___\\__  \\   __\\  |/  _ \\ /    \\ ");
                    Console.WriteLine(" |    \\`   \\  |  /  |_> >  |_|  \\  \\___ / __ \\|  | |  (  <_> )   |  \\");
                    Console.WriteLine("/_______  /____/|   __/|____/__|\\___  >____  /__| |__|\\____/|___|  /");
                    Console.WriteLine("        \\/      |__|                \\/     \\/                    \\/ ");
                    Console.WriteLine("                                                                    \n\n\n");
                    Thread.Sleep(750);
                    question = "Combien de chiffres dans votre tableau souhaitez-vous?";
                    appel.LireEntier(question, out n);


                    Console.WriteLine("Souhaitez-vous générer aléatoirement le tableau à dupliquer? (True - False)");
                    bool a = bool.Parse(Console.ReadLine());
                    
                    if (a == true)
                    {

                    }

                    appel.duplication(tableau1, out tableau2);
                    appel.affichage(applicationTableau, out aff);
                    demande = true;
                } else if (n == 2)





                {
                    appel.systemmojo(tJours, tMois, out mojo);
                    demande = true;
                } else if (n == 3)






                {
                    appel.randommm(number, intervallemin, intervallemax, out tableau);
                    demande = true;
                } else if (n == 4)





                {
                    for (int i = 1; i < 20; i++)
                    {
                        tableaupairimpaire[i] = alea2.Next(); 
                    }
                    appel.paireimpaire(tableaupairimpaire, out int[] pair, out int[] impaire);
                    demande = true;
                    Thread.Sleep(500);
                    Console.WriteLine("Voici le tableau pour les nombres paires");
                    for (int i = 1; i < 20; i++)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine(pair[i]);
                        
                    }
                    for (int i = 1; i < 20; i++)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine(impaire[i]);

                    }
                } else
                {
                    Console.WriteLine("Bon... Vous n'avez pas été sérieux, votre réponse doit être entre 1 et 4 inclus... Recommençons donc!");
                    demande = false;
                }


                if(demande == true)
                {
                    Console.WriteLine("Souhaitez-vous quitter? (oui = true --- non = false)");
                    bool e = bool.Parse(Console.ReadLine());
                    if (e == false)
                    {
                        leave = true;
                    } 
                }

            } while (leave == false);

            Thread.Sleep(500);
            Console.WriteLine("\n \n Merci d'avoir essayer l'une ou plusieurs de mes tâches! \n A bientôt!");



        }
    }
}
