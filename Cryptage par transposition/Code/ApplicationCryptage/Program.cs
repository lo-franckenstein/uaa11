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

            string phrase;
            string key;


            Console.WriteLine("Bonjour, \n Bienvenue sur CryptKey, une application qui permet de faire du cryptage par transposition.");
            Thread.Sleep(500);
            Console.WriteLine("Quel est votre message qui sera ensuite crypté?");
            phrase = Console.ReadLine();
            mp.CryptRed(phrase, out phrase);
            Console.WriteLine("Quel est votre clé?");
            key = Console.ReadLine();
            mp.CryptTri(key);


        }
    }
}
