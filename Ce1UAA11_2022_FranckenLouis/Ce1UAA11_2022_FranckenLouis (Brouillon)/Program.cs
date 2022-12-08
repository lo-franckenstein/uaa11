using System;

namespace Ce1UAA11_2022_FranckenLouis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arret;
            arret = false;
            int points;
            points = 0;
            double nbrtour;


            

            Console.WriteLine("ZANZIBAR !");
            do
            {
                Console.WriteLine("Combien de lancers désirez-vous? (entre 3 et 9) ");
                nbrtour = double.Parse(Console.ReadLine());


                for (int a = 1; a != nbrtour; a++)
                {
                    tourDeJeu(out string desSortis, out int pointsTour, out arret, out points);
                }
                
            } while (arret != true);

        }


        static void comptePoints(int de, out int points)
        {
            if (de == 1)
            {
                points = 100;
            } else
            {
                if (de >= 2 && de <= 5)
                {
                    points = de;
                } else
                {
                    points = de;
                }
            }
        }

        static void tourDeJeu(out string desSortis, out int pointsTour, out bool arret, out int points)
        {
            int compte2;
            int de;
            Random alea = new Random();
            points = 0;

            desSortis = "";
            pointsTour = 0;
            arret = false;
            compte2 = 0;

            for (int i = 1; i <= 4; i++ )
            {
                de = alea.Next(1, 7);
                if (de == 2)
                {
                    compte2 = compte2 + 1;
                };
                desSortis = desSortis + de + " ";
                comptePoints(de, out points);
                pointsTour = pointsTour + points;
            }
            if (compte2 == 3)
            {
                arret = true;
            }
            
        }

       
    }
}
