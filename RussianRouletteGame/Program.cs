using RussianRouletteGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRouletteGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            RoulettePlayer player1 = new RoulettePlayer("Vladimir", "Putin");
            Console.WriteLine(player1);
            RoulettePlayer player2 = new RoulettePlayer("Donald", "Trump");

            Console.WriteLine($"1.oyuncu {player1.FirstName} {player1.LastName} adlı oyuncu {player1.Health} canla oyuna başlıyor.");
            Console.WriteLine($"2.oyuncu {player2.FirstName} {player2.LastName} adlı oyuncu {player2.Health} canla oyuna başlıyor.");
            Gun gun = new Gun();

            Random randomBulletgen = new Random();
            int randomBullet = randomBulletgen.Next(1, (gun.NumberOfBullets + 1));

            Random dicegen = new Random();
            int dice1 = dicegen.Next(1, 7);
            int dice2 = dicegen.Next(1, 7);

            Console.WriteLine("Oyuncular zar atıyor...");
            //Console.WriteLine($"random bullet number: {randomBullet}", randomBullet);
            bool run = true;
            while (run)
            {
                if (dice1 > dice2)
                {
                    Console.WriteLine("1.oyuncu oyuna başlıyor.");
                    //Console.WriteLine($"ilk zar:{dice1}, ikinci zar: {dice2} ", dice1, dice2);
                    run = false;
                }
                else if (dice1 < dice2)
                {
                    Console.WriteLine("2.oyuncu oyuna başlıyor");
                    //Console.WriteLine($"ilk zar:{dice1}, ikinci zar: {dice2} ", dice1, dice2);
                    run = false;
                }
                else
                {
                    Console.WriteLine("Oyuncular tarafından bir daha zar atılıyor.");
                    //Console.WriteLine($"ilk zar:{dice1}, ikinci zar: {dice2} ", dice1, dice2);
                    dice1 = dicegen.Next(1, 7);
                    dice2 = dicegen.Next(1, 7);

                }

            }
            int idx = 1;
            //int idx2 = 1;
            while (idx <= 6)
            {
                if (dice1 > dice2)
                {
                    if (randomBullet % 2 == 1 && idx == randomBullet)
                    {
                        //
                        player1.Health = 0;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"1.Oyuncu {player1.FullName} {idx}. mermiyi kafasına sıktı ve canı {player1.Health}'a düştü.");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"2.Oyuncu {player2.FullName} oyunu kazandı!!!");
                        //Console.WriteLine($"1.oyuncunun canı {player1.Health}");
                        //idx++;
                        break;
                    }
                    else if (randomBullet % 2 == 0 && idx == randomBullet)
                    {
                        // 
                        player2.Health = 0;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"2.Oyuncu {player2.FullName} {idx}. mermiyi kafasına sıktı ve canı {player2.Health}'a düştü.");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"1.Oyuncu {player1.FullName} oyunu kazandı!!!");
                        break;
                    }

                }
                else if (dice1 < dice2)
                {
                    if (randomBullet % 2 == 1 && idx == randomBullet)
                    {
                        player2.Health = 0;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"2.Oyuncu {player2.FullName} {idx}. mermiyi kafasına sıktı ve canı {player2.Health}'a düştü.");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"1.Oyuncu {player1.FullName} oyunu kazandı!!!");
                        //Console.WriteLine($"1.oyuncunun canı {player1.Health}");
                        //idx++;
                        break;
                    }
                    else if (randomBullet % 2 == 0 && idx == randomBullet)
                    {
                        // 
                        player1.Health = 0;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"1.Oyuncu {player1.FullName} {idx}. mermiyi kafasına sıktı ve canı {player1.Health}'a düştü.");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"2.Oyuncu {player2.FullName} {player2.LastName} oyunu kazandı!!!");
                        break;
                    }
                    
                    //idx2++;
                }


                //Console.WriteLine(randomBullet);

                idx++;
            }
            Console.ReadKey();
        }
    }
}
