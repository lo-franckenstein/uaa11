using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace ApplicationCryptage
{
    class appel
    {

        /// <summary>
        /// Attribue un chiffre croissant à chaque lettre (1, 2, 3,...)
        /// </summary>
        /// <param name="key">key est un string comportant la clé secrète</param>
        /// <param name="matrice">matrice est une matrice dans laquelle on va appliquer la méthode de cryptage</param>
        public void CryptAtt(string key, ref int[,] matrice)
        {
            int letter;
            letter = key.Length;
            for (int i = 0; i < letter - 1; i++)
            {
                matrice[1, i] = i;
            }

        }


        /// <summary>
        /// Créer une matrice dont le nombre de colonnes est équivaut au nombre de lettres
        /// </summary>
        /// <param name="phrase">phrase est un string comportant la phrase à crypter</param>
        /// <param name="key">key est un string comportant la clé secrète</param>
        /// <param name="matrice">matrice est une matrice dans laquelle on va appliquer la méthode de cryptage</param>
        public void CryptCrea(string phrase, string key, out int[,] matrice)
        {
            int Pletter;
            int letter;
            int rows;

            Pletter = phrase.Length;
            letter = key.Length;
            rows = Pletter / letter;
            if(Pletter % letter == 0)
            {

            } else
            {
                rows = rows + 1;
            }
            rows = rows + 2;
            matrice = new int[rows, letter];
        }



        /// <summary>
        /// Récupérer les lettres d’une colonne à l’aide du numéro de colonne (2ème étape) dans l’ordre croissant. Mettre sous string (et mettre un espace lorsque la boucle touche le fond de la colonne).
        /// </summary>
        /// <param name="matrice">matrice est une matrice dans laquelle on va appliquer la méthode de cryptage</param>
        /// <param name="NString">NString est un string qui comporte le résultat final, le message crypté</param>
        public void CryptCrypt(ref int[,] matrice, ref string NString)
        {
            bool trouve;
            int i;
            int j;
            i = 1;
            do
            {
                trouve = false;
                j = 0;
                do
                {
                    if (i == matrice[1, j])
                    {
                        for (int k = 2; k < matrice.GetLength(0); k--)
                        {
                            NString += matrice[k, j];
                        }
                        NString += "";
                        trouve = true;
                        i++;
                        j++;
                    }
                } while(!trouve && j < matrice.GetLength(1));
            } while (i <= matrice.GetLength(1));
        }




        /// <summary>
        /// Placer les lettres sans espaces, ni d’apostrophe dans la matrice
        /// </summary>
        /// <param name="matrice">matrice est une matrice dans laquelle on va appliquer la méthode de cryptage</param>
        /// <param name="phrase">phrase est un string comportant la phrase à crypter</param>
        public void CryptPhrase(ref int[,] matrice, string phrase)
        {
            int rows;
            int a;
            bool pass;
            int letter;
            int j;
            
            rows = matrice.GetLength(0);
            a = 0;
            pass = false;
            letter = matrice.GetLength(1);
            for (int i = 2; i<rows - 1; i++)
			{
                j = 0;
                do {
                    if(j != letter) {
                        matrice[i,j] = phrase[a];
                        a++;
                        pass = false;
                    } else
                    {
                        pass = true;
                    }
                    j++;
                } while (pass == false) ;
			}
        }




        /// <summary>
        /// Placer le mot dans la première ligne, et récupérer les chiffres dans la deuxième ligne
        /// </summary>
        /// <param name="key">key est un string comportant la clé secrète</param>
        /// <param name="matrice">matrice est une matrice dans laquelle on va appliquer la méthode de cryptage</param>
        public void CryptPlace(string key, ref int[,] matrice)
        {
            int letter;
            letter = key.Length;
            for (int i = 0; i < letter - 1; i++)
            {
                matrice[0, i] = key[i];
            }
        }




        /// <summary>
        ///  Retirer les espaces et les apostrophes de la phrase.
        /// </summary>
        /// <param name="phrase">phrase est un string comportant la phrase à crypter</param>
        /// <param name="NString">NString est un string qui comporte le résultat final, le message crypté</param>
        public void CryptRed(string phrase, out string NString)
        {
            int Pletter;
            Pletter = phrase.Length;
            NString = "";
            for (int i = 0; i < Pletter - 1; i++)
            {
                if(phrase[i] == ',' || phrase[i] == ' ' || phrase[i] == '"' || phrase[i] == ':')
                {

                } else
                {
                    NString = NString + phrase[i];
                }
            }
        }



        /// <summary>
        /// Trier dans l’ordre l’alphabet (A, B, C, D,...) le mot clé
        /// </summary>
        /// <param name="key">key est un string comportant la clé secrète<</param>
        public void CryptTri(ref string key)
        {
            char temp;
            bool permut;
            int passage;
            int letter;
            letter = key.Length;
            passage = 0;
            char[] tabKey;
            tabKey = new char[letter];
            for (int i = 0; i < letter - 1; i++)
            {
                tabKey[i] = key[i];
            }
            do
            {
                permut = false;
                for (int i = 0; i < i - 2 - passage; i++)
                {
                    if (tabKey[i] > tabKey[i +1])
                    {
                        temp = tabKey[i];
                        tabKey[i] = tabKey[i + 1];
                        tabKey[i + 1] = temp;
                        permut = true;
                    }
                }
                passage = passage + 1;
            } while (permut == false);
        }


    }
}
