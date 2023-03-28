using System;

namespace TriAglo_Louis
{
    public struct appel
    {

        /// <summary>
        /// GenereTableau permet de générer un tableau. [element], [intervallemin], [intervallemax] doivent être des entiers non-vides.
        /// </summary>
        /// <param name="element">[element] est un entier qui permet de nous dire combien de "cases" dans le tableau qui va être généré</param>
        /// <param name="intervallemin">[intervallemin] est un entier qui permet de nous dire à partir de quel nombre on peut générer pour le [tableau]</param>
        /// <param name="intervallemax">[intervallemax] est un entier qui permet de nous dire jusqu'à quel nombre on peut générer pour le [tableau]</param>
        /// <param name="tableau">[tableau] est un tableau repenant les valeurs générés par ce morceau de programme</param>
        public void GenereTableau(int element, int intervallemin, int intervallemax, out int[] tableau)
        {
            Random alea = new Random();         // Permet de générer un nombre aléatoirement
            tableau = new int[element];         // Voir <param>
            for (int i = 0; i < element; i++)   // Variable qui permet de servir de compteur
            {
                tableau[i] = alea.Next(intervallemin, intervallemax);
            };
        }






        /// <summary>
        /// Le morceau de programme Concatenation permet de transformer un tableau en chaîne de caractère. [tableau] doit donc être non-vide.
        /// </summary>
        /// <param name="tableau">[tableau] est un tableau qui va être trié/est déja trié</param>
        /// <param name="chaine">[chaine] est un string qui comportera toutes les valeurs dans [tableau] sous forme de string</param>
        public void Concatenation(int[] tableau, out string chaine)
        {
            chaine = ""; // Voir <param>
            for (int i = 0; i < tableau.Length; i++)    // Variable qui permet de servir de compteur
            {
                chaine = chaine + "[" + tableau[i] + "]  ";
            }
        }






        /// <summary>
        /// Le morceau de programme TriBulle permet d'appliquer le tri bulle sur un tableau
        /// </summary>
        /// <param name="tableau">[tableau] est un tableau dont on va lui appliquer cette méthode de tri</param>
        public void TriBulle(ref int[] tableau)
        {
            int passage;        // Calcule le nombre de passage effectué
            int n;              // Nombre d'éléments dans le tableau
            bool permut;        // Vrai si on a fait au moins une permutation lors du parcours du tableau
            int temporaire;     // Variable qui permet de stocker temporairement afin d'échanger les valeurs de deux variables
            passage = 0;
            n = tableau.Length;
            do
            {
                permut = false;
                for (int i = 0; i < n - 1 - passage; i++)   // Variable qui permet de servir de compteur  
                {
                    if (tableau[i] > tableau[i + 1])
                    {
                        temporaire = tableau[i];
                        tableau[i] = tableau[i + 1];
                        tableau[i + 1] = temporaire;

                        permut = true;
                    }
                    
                }
                passage++;
            } while (permut == true);
            
        }



        /// <summary>
        /// Le morceau de programme TriEncastrement permet d'appliquer le tri par encastrement sur un tableau
        /// </summary>
        /// <param name="tableau">[tableau] est un tableau dont on va lui appliquer cette méthode de tri</param>
        public void TriEncastrement(ref int[] tableau)
        {
            int n;          // Nombre d'éléments dans le tableau
            int x;          // Zone Tampon
            int i;          // pointe
            bool bpp;       // Vrai si on a atteint la première place
            n = tableau.Length;
            for (int j = 1; j <= n - 1; j++)    // Variable qui permet de servir de compteur
            {
                x = tableau[j];
                i = j - 1;
                bpp = false;
                do
                {
                    tableau[i + 1] = tableau[i];
                    if (i == 0)
                    {
                        bpp = true;
                    }
                    else
                    {
                        i--;
                    };

                } while (x < tableau[i] && !bpp);
                if (bpp == true)
                {
                    tableau[0] = x;
                } else
                {
                    tableau[i + 1] = x;
                }
            }

        }



        /// <summary>
        /// Le morceau de programme TriIntuitif permet d'appliquer le tri par intuitif sur un tableau
        /// </summary>
        /// <param name="tableau">[tableau] est un tableau dont on va lui appliquer cette méthode de tri</param>
        public void TriIntuitif(ref int[] tableau)
        {
            int n;          // Nombre d'élements dans le tableau
            int temporaire; // Variable qui permet de stocker temporairement afin d'échanger les valeurs de deux variables 
            n = tableau.Length;
            for (int i = 0; i <= n - 1; i++)    // Variable qui permet de servir de compteur
            {
                for (int j = 0; j < i + 1; j++) // Variable qui permet de servir de compteur
                {
                    if (tableau[j] < tableau[i])
                    {
                        temporaire = tableau[i];
                        tableau[i] = tableau[j];
                        tableau[j] = temporaire;
                    }
                }
            }

        }



        /// <summary>
        /// Le morceau de programme TriSelection permet d'appliquer le tri par sélection sur un tableau
        /// </summary>
        /// <param name="tableau">[tableau] est un tableau dont on va lui appliquer cette méthode de tri</param>
        public void TriSelection(ref int[] tableau)
        {
            int n;          // Nombre d'élements dans le tableau
            int p;          // Place de l'élement à échanger en fin de tour
            int temporaire; // Variable qui permet de stocker temporairement afin d'échanger les valeurs de deux variables
            n = tableau.Length;
            for (int i = 0; i < n - 1; i++) // Variable qui permet de servir de compteur
            {
                p = i;
                for (int j = i + 1; j < n; j++) // Variable qui permet de servir de compteur
                {
                    if (tableau[j] < tableau[p])
                    {
                        p = j;
                    }
                }
                if (p != i)
                {
                    temporaire = tableau[p];
                    tableau[p] = tableau[i];
                    tableau[i] = temporaire;
                }
            }
        }





        /// <summary>
        /// Le morceau de programme TriShell permet d'appliquer le tri par shell sur un tableau
        /// </summary>
        /// <param name="tableau">[tableau] est un tableau dont on va lui appliquer cette méthode de tri</param>
        public void TriShell(ref int[] tableau)
        {
            int n;          // Nombre d'élements dans le tableau
            bool permut;    // Vrai si onfait au moins une permutation lors du parcours du tableau
            int temporaire; // Variable qui permet de stocker temporairement afin d'échanger les valeurs de deux variables
            int ec;         // Ecart
            n = tableau.Length;
            ec = n / 2;
            do
            {
                do
                {
                    permut = false;
                    for (int i = 0; i < n - ec; i++)    // Variable qui permet de servir de compteur
                    {
                        if (tableau[i] > tableau[i + ec])
                        {
                            temporaire = tableau[i + ec];
                            tableau[i + ec] = tableau[i];
                            tableau[i] = temporaire;
                            permut = true;
                        }
                    }
                } while (permut == true);
                ec = ec / 2;
            } while (ec >= 1);

        }


        /// <summary>
        /// Le morceau de programme  LireReel permet de vérifier les entrées de l'utilisateur afin d'être certain que cela fonctionnera bien avec de ce qu'il a mis...
        /// </summary>
        /// <param name="question">[question] est le string comportant la question à laquelle l'utilisateur doit répondre.</param>
        /// <param name="n">[n] est l'entier qui est vérifié par ce morceau de programme</param>
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question + " ");
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.Write("Merci de respecter la consigne et de taper un nombre réel: ");
                nUser = Console.ReadLine();
            }
        }











    }
}
