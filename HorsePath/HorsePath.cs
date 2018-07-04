using System;
using System.Collections.Generic;
using System.Linq;

namespace HorsePath
{
    class HorsePath

    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //int[][] board = new int[n][];
            int[,] board = new int[n, n];
            int counter = 1;

            int[] dRows = new int[] { -2, -2, -1, -1, +1, +1, +2, +2 };
            int[] dCows = new int[] { -1, +1, -2, +2, -2, +2, -1, +1 };

            //for (int i = 0; i < board.Length; i++)
            //{
            //    board[i] = new int[n];
            //}

            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    if (board[r, c] != 0)
                        continue;
                    int row = r;
                    int col = c;
                    while (board[row, col] == 0)
                    {
                        board[row, col] = counter;
                        counter++;

                        for (int dir = 0; dir < dRows.Length; dir++)
                        {
                            int nextRow = row + dRows[dir];
                            int nextCol = col + dCows[dir];

                            if (nextRow < 0 || nextRow >= board.GetLength(0))
                                continue;

                            int a = board.GetLength(0);
                            
                            if (nextCol < 0 || nextCol >= board.GetLength(1))
                                continue;

                            if (board[nextRow, nextCol] != 0)
                                continue;
                            row = nextRow;
                            col = nextCol;
                            break;
                        }
                    }
                }

            }




            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
