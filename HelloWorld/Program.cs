using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Boolean gameEnd = false;
            Console.WriteLine("Welcome to Tic Toe Game");
            OyunOyna oyunBasla = new OyunOyna();
            oyunBasla.oyna(false);
            
        }

    }
}
