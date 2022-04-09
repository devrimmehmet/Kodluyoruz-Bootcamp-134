using System;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Oyunda İki Oyuncu olacak
             * Her bir oyuncuda iki adet zar olacak
             * Oyuncular sırası ile zar atar
             * Zarlar karşılaştırılır
             * Büyük atan kazanır.
             * 
             * 
             * Nesneler: 
             * 1-Oyun
             * 2-Oyuncu
             * 3-Zar
             * 
             */
            do { 
            Game game = new Game();
            game.PlayerOne = new Player { Name = "Turkay" };
            game.PlayerTwo = new Player { Name = "Mehmet" };
            game.PlayAndTurn();
            game.ShowWinner();
                Console.WriteLine("Oyunu Bitirmek İstermisin?");
            } while
            (Console.ReadLine()!="E" );
        }
    }
}
