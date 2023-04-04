using System;
using System.Collections.Generic;
using System.Text;

namespace _5Ti_OpérationMatrice_FranckenLouis
{
    public struct appel
    {

        /// <summary>
        /// Ce morceau de programme permet de vérifier les entrées de l'utilisateur et de s'assurer que tout est de type int.
        /// La question doit être écrite correctement et sous string
        /// </summary>
        /// <param name="question">String comportant la question</param>
        /// <param name="n">Int comportant la réponse vérifié de l'utilisateur</param>
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
        /// Générer des nombres aléatoires dans un tableau deux dimensions dont le nombre de colonnes et de lignes est défini par l’utilisateur.
        /// rows & column doivent être des entiers non-vides
        /// </summary>
        /// <param name="rows">Entier donné par l'utilisateur afin de dire le nombre de lignes</param>
        /// <param name="column">Entier donné par l'utilisateur afin de dire le nombre de colonnes</param>
        /// <param name="matrice">Tableauu deux dimensions reprenant les valeurs générés</param>
        public void MatrGen(int rows, int column, out int[,] matrice)
        {
            matrice = new int[rows, column];
            Random alea = new Random();
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < column - 1; j++)
                {
                    matrice[i, j] = alea.Next(0, 21);
                }
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
            int rows;
            int column;
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
                    tableau = tableau + matrice[i, j] + "|";
                }
                tableau = tableau + "\n";
                for (int a = 0; a < rows - 1; a++)
                {
                    tableau = tableau + "———";
                }
                tableau = tableau + "\n";
            }
           
        }


        /// <summary>
        /// Faire une vérfication si l'opération est possible, si oui, effectuer une addition entre deux matrices
        /// Chaque cellules des matrices 1 et 2 doivent être non-vides
        /// </summary>
        /// <param name="matrice1">Matrice qui servira au premier terme de l'addition</param>
        /// <param name="matrice2">Matrice qui servira au deuxième terme de l'addition</param>
        /// <param name="matricePropre">Matrice qui servira à la somme de l'addition</param>
        /// <param name="verif">Booléen qui servira à dire si le calcul est possible</param>
        public void MatrAdd(int[,] matrice1, int[,] matrice2, out int[,] matricePropre, out bool verif)
        {
            int rows;
            int column;
            rows = matrice1.GetLength(0);
            column = matrice1.GetLength(1);
            matricePropre = new int[rows, column];
            if (matrice1.GetLength(0) == matrice2.GetLength(0) && matrice1.GetLength(1) == matrice2.GetLength(1))
            {
                verif = true;
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = 0; j < column - 1; j++)
                    {
                        matricePropre[i, j] = matrice1[i, j] + matrice2[i, j];
                    }
                }
                 
            } else
            {
                verif = false;
                matricePropre[0, 0] = 0;
            }
        }




        /// <summary>
        /// Faire une vérification si l'opération est possible, si oui, une multiplication entre deux matrices
        /// Les cellules des matrices 1 et 2 doivent être non-vides.
        /// </summary>
        /// <param name="matrice1">Matrice qui servira au premier facteur de la multiplication</param>
        /// <param name="matrice2">Matrice qui servira au deuxième facteur de la multiplication</param>
        /// <param name="matricePropre">Matrice qui servira au produit de la multiplication</param>
        /// <param name="verif">Booléen qui servira à dire si le calcul est possible</param>
        public void MatrMul(int[,] matrice1, int[,] matrice2, out int[,] matricePropre, out bool verif)
        {
            int rows;
            int column;
            rows = matrice1.GetLength(0);
            column = matrice2.GetLength(1);
            matricePropre = new int[rows, column];

            if (matrice1.GetLength(0) == matrice2.GetLength(1) && matrice1.GetLength(1) == matrice2.GetLength(0))
            {
                verif = true;
                for (int a = 0; a < rows - 1; a++)
                {
                    for (int b = 0; b < column - 1; b++)
                    {
                        matricePropre[a, b] = 0;
                        for (int j = 0; j < rows - 1; j++)
                        {
                            matricePropre[a, b] = matricePropre[a, b] + matrice1[a, j] * matrice2[j, b];
                        }
                    }
                }
            } else
            {
                verif = false;
            }
        }
    }
}
