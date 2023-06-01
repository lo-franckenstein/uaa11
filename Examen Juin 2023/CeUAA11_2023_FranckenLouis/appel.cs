using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CeUAA11_2023_FranckenLouis
{






    public struct appel
    {


        public void CryptAffine(string PhClaire, int a, int b, out string[,] matAffine)
        {
            int x;
            int y;
            matAffine = new string[4, PhClaire.Length];
            for (int i = 0; i < PhClaire.Length - 2; i++)
            {
                matAffine[0, i] = PhClaire[i].ToString();
                x = ((int)PhClaire[i] - 65);
                matAffine[1, i] = x.ToString();
                y = (a * x + b) % 26;
                matAffine[2, i] = y.ToString();
                matAffine[3, i] = (y + 65).ToString();

            }
        }




        public void CryptVigenere(string PhClaire, string phClef, out string[,] matViegenere)
        {
            int j;
            int codeAscii;

            matViegenere = new string[4, PhClaire.Length];
            j = 0;
            for (int i = 0; i < PhClaire.Length; i++)
            {
                matViegenere[0, i] = PhClaire[i].ToString();
                if (j == phClef.Length)
                {
                    j = 0;
                }
                matViegenere[1, i] = PhClaire[j].ToString();
                matViegenere[2, i] = (((int)phClef[j]) - 65).ToString();
                if (((int)PhClaire[i]) + int.Parse(matViegenere[2, i]) <= 90)
                {
                    codeAscii = (int)char.Parse(matViegenere[0, i]) + int.Parse(matViegenere[2, i]);
                }
                else
                {
                    codeAscii = (int)char.Parse(matViegenere[0, i]) + int.Parse(matViegenere[2, i]) - 26;
                }
                matViegenere[3, i] = Convert.ToChar(codeAscii).ToString();
                j++;

            }

        }

        public void CryptPhrase(ref string phrase)
        {
            int number;
            string[] stock;
            string NPhrase;
            number = phrase.Length;
            stock = new string[number];
            NPhrase = "";

            for (int i = 0; i < number - 1; i++)
            {
                stock[i] = phrase[i].ToString();
            }

            for (int i = 0; i < number - 1; i++)
            {
                if (stock[i] == "-" || stock[i] == " " || stock[i] == "'" || stock[i] == "_" || stock[i] == "")
                {
                    NPhrase = "";
                } else
                {
                    NPhrase = stock[i];
                }
            }

            phrase = NPhrase;

            

        }


        public void CryptConv(string[,] matrice, out string convertisseur)
        {
            int rows;
            int column;
            rows = matrice.GetLength(0);
            column = matrice.GetLength(1);
            convertisseur = "Voici la matrice de cryptage : \n------------------------------\n";
            for(int i = 0;i < rows - 1;i++)
            {
                for (int j = 0; j < column - 1; j++)
                {
                    convertisseur += matrice[i, j] + " ";
                }
                convertisseur += "\n";
            }
            convertisseur += "\n\nRésultat du cryptage par la méthode de Vigenère\n";
            for (int i = 0; i < rows - 1; i++)
            {
                convertisseur += matrice[4, i];
            }

        }


        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
        }









    }
}
