using Microsoft.VisualBasic;
using System;
using System.Threading;

namespace ApplicationCryptage
{
    class Program
    {
        static void Main(string[] args)
        {

            appel mp = new appel();
            animation ani = new animation();

            string phrase;                  // phrase est un string comportant la phrase à crypter
            string key;                     // key est un string comportant la clé secrète
            string NString;                 // NString est un string qui comporte le résultat final, le message crypté

            NString = "";


            ani.Cadenas24();
            Console.WriteLine("Bonjour, \n Bienvenue sur CryptKey, une application qui permet de faire du cryptage par transposition.");
            Thread.Sleep(500);
            Console.WriteLine("Quel est votre message qui sera ensuite crypté?");
            phrase = Console.ReadLine();
            mp.CryptRed(phrase, out phrase);
            Console.WriteLine("Quel est votre clé?");
            key = Console.ReadLine();
            mp.CryptTri(ref key);
            mp.CryptCrea(phrase, key, out int[,] matrice);
            mp.CryptAtt(key, ref matrice);
            mp.CryptPlace(key, ref matrice);
            mp.CryptPhrase(ref matrice, phrase);
            mp.CryptCrypt(ref matrice, ref NString);
            Console.WriteLine(NString);


        }
    }
}
