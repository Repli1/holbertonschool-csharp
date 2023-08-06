using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int columns = myMatrix.GetLength(1);
        int[,] newMatrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                newMatrix[i, j] = (myMatrix[i, j] * myMatrix[i, j]);
            }
        }
        return newMatrix;
    }
}
