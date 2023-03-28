using System;
using System.Collections.Generic;
using System.Text;

namespace _5Ti_OpérationMatrice_FranckenLouis
{
    public struct appel
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <param name="n"></param>
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
        /// 
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="column"></param>
        /// <param name="matrice"></param>
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
        /// 
        /// </summary>
        /// <param name="matrice"></param>
        /// <param name="tableau"></param>
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
        /// 
        /// </summary>
        /// <param name="matrice1"></param>
        /// <param name="matrice2"></param>
        /// <param name="matricePropre"></param>
        /// <param name="verif"></param>
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
        /// 
        /// </summary>
        /// <param name="matrice1"></param>
        /// <param name="matrice2"></param>
        /// <param name="matricePropre"></param>
        /// <param name="verif"></param>
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
