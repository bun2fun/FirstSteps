using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of rows and columns:");
         //input
        int n = int.Parse(Console.ReadLine());
        string direction = "right";
        int[,] spiral = new int[n,n];
        int currentRow = 0;
        int currentCol = 0;

        //solution

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
            {   
                currentCol--;
                currentRow--;
                direction = "left";
            }
            if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }
            spiral[currentRow, currentCol] = i;
            if (direction == "right")
            {
                currentCol++;   
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            } 
            else if (direction == "up")
            {
                currentRow--;
            }
        }
        //print
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}" , spiral[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}