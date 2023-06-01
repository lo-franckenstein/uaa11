using System;
using System.Security;
using System.Security.Cryptography;

namespace CeUAA11_2023_FranckenLouis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            appel mp = new appel();
            ConsoleKeyInfo keyLetter;
            int crypt;
            string PhClaire;
            string phClef;
            string phrase;
            string[,] matrice;
            bool leave;
            bool verif;
            verif = false;
            crypt = 0;
            string question;
            int a;
            int b;
            a = 0;
            b = 0;
            string convertisseur;

            do
            {
                do
                {
                    Console.WriteLine("CRYPTAGE\n========\n\nChoisissez parmi les options suivantes :\n1 - Cryptage de Vigenère\n2 - Cryptage avec la méthode affine");
                    keyLetter = Console.ReadKey();
                    Console.WriteLine("\n");
                } while (keyLetter.Key != ConsoleKey.NumPad1 && keyLetter.Key != ConsoleKey.D1 && keyLetter.Key != ConsoleKey.NumPad2 && keyLetter.Key != ConsoleKey.D2);

                if (keyLetter.Key == ConsoleKey.NumPad1 || keyLetter.Key == ConsoleKey.D1)
                {
                    crypt = 1;
                }
                else if (keyLetter.Key == ConsoleKey.NumPad2 || keyLetter.Key == ConsoleKey.D2)
                {
                    crypt = 2;
                }

                Console.WriteLine("Encodez la phrase à crypter !");
                PhClaire = Console.ReadLine();
                phrase = PhClaire;
                mp.CryptPhrase(ref phrase);
                PhClaire = phrase;

                Console.WriteLine("");
                if (crypt == 1)
                {
                    Console.WriteLine("Vous avez choisi la méthode de Vigenère !\n-----------------------------------------\nEncodez ma cmé à utiliser dans la méthode de Vigenère !");
                    phClef = Console.ReadLine();
                    phrase = phClef;
                    mp.CryptPhrase(ref phrase);
                    phClef = phrase;
                    mp.CryptVigenere(PhClaire, phClef, out matrice);
                    mp.CryptConv(matrice, out convertisseur);
                    Console.WriteLine(convertisseur);

                }
                else
                {
                    Console.WriteLine("Vous avez choisi la méthode de cryptage affine !\n-----------------------------------------");
                    do
                    {
                        question = "Donnez la valeur du coefficient de (impair entre 1 et 25 sauf 13) :";
                        mp.LireReel(question, out a);
                        if (a == 1 || a == 3 || a == 5 || a == 7 || a == 9 || a == 11 || a == 15 || a == 17 || a == 19 || a == 21 || a == 23 || a == 25)
                        {
                            verif = true;
                        }
                        else
                        {
                            verif = false;
                        }
                    } while (verif == false);
                    do
                    {
                        question = "Donnez la valeur du coefficient b :";
                        mp.LireReel(question, out b);
                        if (b >= 0 && b <= 25)
                        {
                            verif = true;
                        }
                        else
                        {
                            verif = false;
                        }
                    } while (verif == false);
                    mp.CryptAffine(PhClaire, a, b, out matrice);
                    mp.CryptConv(matrice, out convertisseur);
                    Console.WriteLine(convertisseur);
                }

                Console.WriteLine("Un autre cryptage ? o = oui / autre = non");
                keyLetter = Console.ReadKey();
                leave = true;
                if (keyLetter.Key == ConsoleKey.O)
                {
                    leave = false;
                }
            } while (leave == false);
            


        }
    }
}
