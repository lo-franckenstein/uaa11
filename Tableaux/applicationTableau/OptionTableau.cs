using System;
using System.Threading;

namespace applicationTableau
{
    public struct OptionTableau
    {
        public void LireEntier(string question, out int n)

        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Thread.Sleep(300);
                Console.WriteLine("Attention ! vous devez taper un nombre entier !");
                nUser = Console.ReadLine();
            }
        }


        public void duplication(int[] tableau1, out int[] tableau2)
        {
            int place;
            place = tableau1.Length;
            tableau2 = new int[place];
            for (int i = 0; i < place - 1; i++)
            {
                tableau2[i] = tableau1[i];
            }

        }

        public void affichage(int[] tableau, out string aff)
        {
            aff = " ";

            for(int i = 0; i < tableau.Length; i--)
            {
                aff = aff + tableau[i] + " ";
            }

        }

        public void systemmojo(int[] tJours, string[] tMois, out string[] mojo)
        {
            int i2;
            i2 = 0;
            mojo = new string[24];
            for (int i = 0; i < 11; i++)
            {
                mojo[i2] = tMois[i];
                i2 = i2 + 1;
                mojo[i2] = tJours[i2].ToString();
                i2 = i2 + 1;
            }
        }

        public void randommm(int number, int intervallemin, int intervallemax, out int[] tableau)
        {
           
            Random alea = new Random();
            tableau = new int[number];
            for (int i = 1; i < number; i++ )
            {
                tableau[i] = alea.Next(intervallemin, intervallemax);
            }

        } 

        public void paireimpaire(int[] tableaupairimpaire, out int[] pair, out int[] impaire)
        {
            int ii = 0;
            int ip = 0;
            pair = new int[20];     
            impaire = new int[20];


            for (int i = 1; i < 20; i++)
            {
                if (tableaupairimpaire[i] % 2 == 0)
                {
                    pair[ip] = tableaupairimpaire[i];
                    ip++;
                } else
                {
                    impaire[ii] = tableaupairimpaire[i];
                    ii++;
                }

                do
                {
                    pair[ip] = 0;
                    ip++;
                } while (ip < 20);

                do
                {
                    impaire[ii] = 0;
                    ii++;
                } while (ii < 20);
            }


        }






    }
}
