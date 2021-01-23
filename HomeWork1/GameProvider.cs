using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    class GameProvider 
    {
        public void Gameplay()
        {
            // ввод кол-ва игроков
            Console.WriteLine("Введите количество игроков:");
            string qantityOfPlayers = Console.ReadLine();
            int QantityOfPlayers = Convert.ToInt32(qantityOfPlayers);

            //ввод диапазона gameNumber
            Console.WriteLine("Введите первое число диапазона случайных чисел:");
            string gameNumberOne = Console.ReadLine();
            int GameNumberOne = Convert.ToInt32(gameNumberOne);

            Console.WriteLine("Введите второе число диапазона случайных чисел:");
            string gameNumberTwo = Console.ReadLine();
            int GameNumberTwo = Convert.ToInt32(gameNumberTwo);

            string askOfReapeat="x";
            while (askOfReapeat != "Y")
            {

            string[] ArrayOfPlayers = new string[QantityOfPlayers];// массив из игроков

           // цикл представления игроков
            for (int counterOfPlayers = 0; counterOfPlayers < QantityOfPlayers; counterOfPlayers++)
            {
                int numberOfPlayer = counterOfPlayers + 1;
                Console.WriteLine($"Введите имя игрока {numberOfPlayer}");
                ArrayOfPlayers[counterOfPlayers] = Console.ReadLine();
                Console.WriteLine($"Привет {ArrayOfPlayers[counterOfPlayers]}");
            }
        
            Random generationRandomValue = new Random();
            int gameNumber = generationRandomValue.Next(GameNumberOne, GameNumberTwo);

            Console.WriteLine(gameNumber);
            int result = gameNumber;
            // запуск цикла проверки результата вычитания значения попытки игрока из загаданного числа
            for(;result>0 ; )
            {
                int CellOfArrayOfPlayers = 0;// ячейка в списке массива имен игроков

                // перебор игроков для осуществления попытки
                while ( CellOfArrayOfPlayers<= QantityOfPlayers - 1)
                {
                    if (result == 0 || result<0)
                    {
                        Console.WriteLine("gameOver \n Реванш? \n Y/N");
                        askOfReapeat = Console.ReadLine();
                        if (askOfReapeat == "N")
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                            Console.WriteLine($"сделай попытку  {ArrayOfPlayers[CellOfArrayOfPlayers]} от 1 до 4");
                            string userTry = Console.ReadLine();
                           int UserTry = Convert.ToInt32(userTry);
                        while (UserTry<=0 || UserTry > 4)
                        {
                            Console.WriteLine($"Неверная попытка {ArrayOfPlayers[CellOfArrayOfPlayers]} введите от 1 до 4");
                            userTry = Console.ReadLine();
                            UserTry = Convert.ToInt32(userTry);
                        }
                            CellOfArrayOfPlayers++;
                            result = result - UserTry;
                            Console.WriteLine(result);
                    }
            }
                     
                }
             
            }
        }   

    }
}
