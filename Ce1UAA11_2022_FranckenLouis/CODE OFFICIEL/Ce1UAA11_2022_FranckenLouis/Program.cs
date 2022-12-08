using System;

namespace Ce1UAA11_2022_FranckenLouis
{
    class Program
    {
        static void Main(string[] args)
        {

            double leave;
            leave = 0;
            double nbrlancer;
            string totalU1;
            string totalU2;
            string resultatU1;
            string resultatU2;
            double verif;
            verif = 0;
            totalU1 = "";
            totalU2 = "";
            resultatU1 = "";
            resultatU2 = "";
            do
            {
                Console.WriteLine("ZANZIBAR!");

                do
                {
                    Console.Write("Combien de lancers désirez-vous? (Entre 3 & 9");
                    nbrlancer = double.Parse(Console.ReadLine());
                } while (nbrlancer > 9 || nbrlancer < 3);

                generator(nbrlancer, totalU1, totalU2, resultatU1, resultatU2, verif);

                do
                {
                    Console.Write("Souhaitez-vous recommencer?");
                    leave = double.Parse(Console.ReadLine());
                } while (leave != 0 || leave != 1);

            } while (leave == 0);

            Console.WriteLine("Merci d'avoir passé un moment avec nous!");





        }


        static void calculator(double temporaire, double player, out string totalU2, out string totalU1)
        {
            totalU1 = "";
            totalU2 = "";

            if (temporaire == 1)
            {
                if (player == 1)
                {
                    totalU1 = totalU1 + 100;
                } else
                {
                    totalU2 = totalU2 + 100;
                }
            } else
            {
                if (temporaire == 2)
                {
                    if (player == 1)
                    {
                        totalU1 = totalU1 + 2;
                    }
                    else
                    {
                        totalU2 = totalU2 + 2;
                    }
                }
                else
                {
                    if (temporaire == 3)
                    {
                        if (player == 1)
                        {
                            totalU1 = totalU1 + 3;
                        }
                        else
                        {
                            totalU2 = totalU2 + 3;
                        }
                    }
                    else
                    {
                        if (temporaire == 4)
                        {
                            if (player == 1)
                            {
                                totalU1 = totalU1 + 4;
                            }
                            else
                            {
                                totalU2 = totalU2 + 4;
                            }
                        }
                        else
                        {
                            if (temporaire == 5)
                            {
                                if (player == 1)
                                {
                                    totalU1 = totalU1 + 5;
                                }
                                else
                                {
                                    totalU2 = totalU2 + 5;
                                }
                            }
                            else
                            {
                                if (temporaire == 6)
                                {
                                    if (player == 1)
                                    {
                                        totalU1 = totalU1 + 60;
                                    }
                                    else
                                    {
                                        totalU2 = totalU2 + 60;
                                    }
                                }
                                else
                                {

                                }
                            }
                        }
                    }
                }
            }
        }




        static void generator(double nbrlancer, string totalU1, string totalU2, string resultatU1, string resultatU2, double verif)
        {
            double i;
            double temporaire;
            double sousverif1;
            double sousverif2;
            double player;
            sousverif1 = 0;
            sousverif2 = 0;
            Random alea = new Random();

            i = 1;
            temporaire = 0;


            do
            {
                for (int j = 1; j != 3; j++ )
                {
                    temporaire = alea.Next(1, 7);
                    resultatU1 = resultatU1 + temporaire + " ";
                    player = 1;
                    calculator(temporaire, player, out totalU2, out totalU1);
                    if (temporaire == 2)
                    {
                        sousverif1 = sousverif1 + 1;
                    } else
                    {
                        sousverif2 = sousverif2 + 1;
                    }
                    temporaire = alea.Next(1, 7);
                    resultatU2 = resultatU2 + temporaire + " ";
                    player = 2;
                    calculator(temporaire, player, out totalU2, out totalU1);
                    if (temporaire == 2)
                    {
                        sousverif1 = sousverif1 + 1;
                    }
                    else
                    {
                        sousverif2 = sousverif2 + 1;
                    }
                }
                resultatU1 = resultatU1 + "- ";
                resultatU2 = resultatU2 + "- ";
                if (sousverif1 == 3 || sousverif2 == 3)
                {
                    verif = 1;
                } else
                {
                    sousverif2 = 2;
                }
            } while (i != nbrlancer || verif != 1);
        }
    }
}
