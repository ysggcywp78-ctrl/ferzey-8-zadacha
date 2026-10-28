using System;

class Program
{
    static void Main()
    {
        int[] cols = new int[8]; 
        PlaceQueens(0, cols);
    }

       static bool PlaceQueens(int row, int[] cols)
    {
        if (row == 8) 
        {
            Console.WriteLine("Решение (строка, колонка):");
            for (int r = 0; r < 8; r++)
                Console.WriteLine($"{r}, {cols[r]}");
            return true; 
        }

        for (int col = 0; col < 8; col++)
        {
            if (IsSafe(row, col, cols))
            {
                cols[row] = col;              
                if (PlaceQueens(row + 1, cols)) 
                    return true;            

            }
        }

        return false;
    }

    static bool IsSafe(int row, int col, int[] cols)
    {
        for (int r = 0; r < row; r++)
        {
            int c = cols[r];

            if (c == col || Math.Abs(r - row) == Math.Abs(c - col))
                return false;
        }
        return true;
    }
}