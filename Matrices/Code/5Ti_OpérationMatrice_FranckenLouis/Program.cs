using System;

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

            question = "Nombre de lignes sur la matrice? ";
            mp.LireReel(question, out n);
            rows = n;
            question = "Nombre de colonnes sur la matrice? ";
            mp.LireReel(question, out n);
            column = n;

            mp.MatrGen(rows, column, out matrice);
            mp.MatrCon(matrice, out tableau);
            Console.WriteLine(tableau);

        }
    }
}
