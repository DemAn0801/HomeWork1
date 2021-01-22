using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    class GameProvider
    {

        public void ThePresentaitonOfThePlayers()
        {
            string qantityOfPlayers = Console.ReadLine(); // ввод кол-ва игроков
            int QantityOfPlayers = Convert.ToInt32(qantityOfPlayers);

            string[] ArrayOfPlayers = new string[QantityOfPlayers];// массив из игроков

           // циккл представления игроков
            for (int counterOfPlayers = 0; counterOfPlayers < QantityOfPlayers; counterOfPlayers++)
            {
                int numberOfPlayer = counterOfPlayers + 1;
                Console.WriteLine($"Введите имя игрока {numberOfPlayer}");
                ArrayOfPlayers[counterOfPlayers] = Console.ReadLine();
                Console.WriteLine($"Привет {ArrayOfPlayers[counterOfPlayers]}");
            }
        
            Random generationRandomValue = new Random();
            int GenerationRandomValue = generationRandomValue.Next(75, 120);

            Console.WriteLine(GenerationRandomValue);
            int result = GenerationRandomValue;
            for(;result>0 ; )
            {
                int CellOfArrayOfPlayers = 0;
                while ( CellOfArrayOfPlayers<=QantityOfPlayers-1)
                {
                    if (result == 0 || result<0)
                    {
                        Console.WriteLine("gameOver");
                        break;
                    }
                    else
                    {
                     Console.WriteLine($"сделай попытку {ArrayOfPlayers[CellOfArrayOfPlayers]}");
                     string userTry = Console.ReadLine();
                     int UserTry = Convert.ToInt32(userTry);
                     CellOfArrayOfPlayers++;
                     result = result - UserTry;
                     Console.WriteLine(result);
                    }
                     
                }
             
            }
        }   

    }
}
