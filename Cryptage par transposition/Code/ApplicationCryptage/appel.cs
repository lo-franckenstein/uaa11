using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ApplicationCryptage
{
    class appel
    {
        public void CryptAtt(string key, ref int[,] matrice)
        {
            int letter;
            letter = key.Length;
            for (int i = 0; i < letter - 1; i++)
            {
                matrice[1, i] = i;
            }

        }



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




        public void CryptCrypt(ref int[,] matrice, ref string Nstring)
        {
            int letter;
            letter = matrice.GetLength(1);
            for (int i = 1; i <= letter; i++)
            {
                for (int j = 3; j < rows; j++)
                {
                    for (int k = 0; k < letter - 1; k++)
                    {
                        if(matrice[2, k] == i)
                        {
                            if(matrice[j, k])
                            {
                                NString = NString + matrice[j, k];
                            } else
                            {
                                NString = NString + "";
                            }
                        }
                    }
                }
            }
        }





        public void CryptPhrase(ref int[,] matrice, string phrase)
        {
            int rows;
            int a;
            bool pass;
            int letter;
            
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





        public void CryptPlace(string key, ref int[,] matrice)
        {
            int letter;
            letter = key.Length;
            for (int i = 0; i < letter - 1; i++)
            {
                matrice[0, i] = key[i];
            }
        }





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




        public void CryptTri(string key)
        {
            string temp;
            bool permut;
            int passage;
            int letter;
            letter = key.Length;
            passage = 0;
            tabKey = new char[letter];
            for (int i = 0; i < letter - 1; i++)
            {
                tabKey[i] = key[i];
            }
            do
            {
                permut = false;
                for (int i = 0; i < new - 2 - passage; i++)
                {
                    if (tabKey[i] > tabKey[i - 1])
                    {
                        temp = tabKey[i];
                        tabKey[i] = tabKey[i + 1];
                        tabKey[i + 1] = temp;
                        permut = true;
                    }
                }
                passage = passage + 1;
            } while (permut = false);
        }


    }
}
