using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_FranckenLouis
{
    public struct appel
     {
        
        
        /// <summary>
        /// LireReel a pour but de vérifier que l'utilisateur n'est pas en train de faire crash le programme
        /// 
        /// question doit être non-vide
        /// </summary>
        /// <param name="question">String comportant la question</param>
        /// <param name="n">Entier comportant la réponse correcte</param>
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention, vous devez tapez un nombre réel...");
                nUser = Console.ReadLine();
            }
        }

        /// <summary>
        /// Créer une matrice comportant le triangle de Pascal avec une taille définie par l’utilisateur
        /// 
        /// n doit être non-vide et positif
        /// </summary>
        /// <param name="n">Entier qui est une demande de l’utilisateur définir la taille du triangle</param>
        /// <param name="matrice">Matrice qui comporte le triangle de Pascal avec les tailles définies par l’utilisateur</param>
        public void MatPas(int n, out int[,] matrice)
        {
            
            matrice = new int[n + 1, n + 1];
            for (int i = 0; i <= n; i++) // Boucle pour simplifier le raisonnement avec les calculs
            {
                for (int j = 0; j <= n; j++)
                {
                    matrice[i, j] = 0;
                }
            }

            for (int i = 0; i <= n; i++) // Boucle pour placer déja dans la première colonne, les 1
            {
                matrice[i, 0] = 1;
            }

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    matrice[i + 1, j + 1] = matrice[i, j] + matrice[i, j + 1];
                }
            }


        }

        /// <summary>
        /// n doit être non-vide et positif
        /// 
        /// matrice doit être positif et existante
        /// </summary>
        /// <param name="n">Entier qui est une demande de l’utilisateur définir la taille du triangle</param>
        /// <param name="matrice">Matrice qui comporte le triangle de Pascal avec les tailles définies par l’utilisateur</param>
        /// <param name="puissance">String comportant la chaîne de caractère contenant le développement correspondant à la puissance de la matrice</param>
        public void MatPui(int n, int[,] matrice, out string puissance)
        {
            int rows;           // Entier servant de stockage au nombre de ligne de la matrice
            int exposant;       // Entier servant de compteur pour les exposants de a
            int degré;          // Entier servant de compteur pour les exposants de b
            rows = matrice.GetLength(0);
            exposant = n;
            degré = 0;
            puissance = "0";

            for (int i = 0; i <= rows; i++)
            {
                puissance = matrice[rows, i] + "a^" + exposant + "b^" + degré;
                degré++;
                exposant--;
            }

        }




        /// <summary>
        /// Créer un tableau visuel reprenant toutes les valeurs de la matrice.
        /// matrice doit être remplie d'entiers entre 0 et 20
        /// </summary>
        /// <param name="matrice">Tableau de deux dimensions</param>
        /// <param name="tableau">String reprenant toutes les valeurs de la matrice</param>
        public void MatrCon(int[,] matrice, out string tableau)
        {
            int rows;       // Entier permettant de savoir combien il y a de lignes
            int column;     // Entier permettant de savoir combien il y a de colonnes
            tableau = "";
            rows = matrice.GetLength(0);
            column = matrice.GetLength(1);
            for (int a = 0; a < rows - 1; a++)
            {
                tableau = tableau + "———";
            }
            tableau = tableau + "\n";
            for (int i = 0; i < rows - 1; i++)
            {
                tableau = tableau + "|";
                for (int j = 0; j < column - 1; j++)
                {
                    if (matrice[i, j] == 0)
                    {
                        tableau = tableau + " |";
                    } else
                    {
                        tableau = tableau + matrice[i, j] + "|";
                    }
                    
                }
                tableau = tableau + "\n";
                for (int a = 0; a < rows - 1; a++)
                {
                    tableau = tableau + "———";
                }
                tableau = tableau + "\n";
            }

        }
    }

}
