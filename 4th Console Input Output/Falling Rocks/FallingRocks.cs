using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Collections.Generic;

struct GameObject
{
    public int x;
    public int y;
    public char symbol;
    public ConsoleColor color;
}
class FallingRocks
{

    static void PrintPosition(int x, int y, char symbol, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }
    static void PrintGameInfo(int x, int y, string info, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(info);
    }
    static void Main()
    {
        int playFieldWidth = 45;
        int lifeCount = 3;
        int score = 0;
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 60;

        GameObject userDwarf = new GameObject();
        userDwarf.x = 15;
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.color = ConsoleColor.Red;
        Console.WriteLine();
        userDwarf.symbol = '0';

        List<GameObject> rocks = new List<GameObject>();
        Random randomGenerator = new Random();

        char[] rockShape = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };

        while (true)
        {
            GameObject newRock = new GameObject();
            newRock.color = ConsoleColor.DarkYellow;
            newRock.x = randomGenerator.Next(0, playFieldWidth);
            newRock.y = 0;
            newRock.symbol = rockShape[new Random().Next(0, rockShape.Length)];
            rocks.Add(newRock);


            if (Console.KeyAvailable)       //makes sure the game is running although player takes no action
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);      //move the dwarf (checks if any key is pressed)
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userDwarf.x - 1 >= 0)
                    {
                        userDwarf.x = userDwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userDwarf.x + 1 < playFieldWidth)
                    {
                        userDwarf.x = userDwarf.x + 1;
                    }
                }
            }

            //move rocks
            List<GameObject> newList = new List<GameObject>();

            for (int i = 0; i < rocks.Count; i++)
            {
                GameObject oldRock = rocks[i];
                GameObject brandRock = oldRock;
                brandRock.x = oldRock.x;
                brandRock.y = oldRock.y + 1;
                brandRock.color = oldRock.color;
                brandRock.symbol = oldRock.symbol;
                
                //check for collision
                if (brandRock.y == userDwarf.y && brandRock.x == userDwarf.x)
                {
                    lifeCount--;
                    if (lifeCount <= 0)
                    {
                        PrintGameInfo(20, 15, "GAME OVER", ConsoleColor.Red);
                        Console.ReadKey();
                        return;
                    }
                }
                
                if (brandRock.y < Console.WindowHeight)
                {
                    newList.Add(brandRock);
                }
                else
                {
                    score += 1;
                }
            }
            //rocks.Remove(oldRock);
            rocks = newList;
           
            //clear the console
            Console.Clear();
            
            //redraw playfield
            PrintPosition(userDwarf.x, userDwarf.y, userDwarf.symbol, userDwarf.color);

            foreach (GameObject rock in rocks)
            {
                PrintPosition(rock.x, rock.y, rock.symbol, rock.color);
            }
            //game info
            PrintGameInfo(47, 5, "Lives left:" + lifeCount, ConsoleColor.Blue);
            PrintGameInfo(47, 6, "Score:" + score, ConsoleColor.Blue);
            
            //slow down program
            Thread.Sleep(150);
        }
    }
}
