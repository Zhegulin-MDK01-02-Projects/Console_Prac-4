class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        int power = 3;

        int[,] result = MatrixPower(matrix, power);

        Console.WriteLine("Result:");
        PrintMatrix(result);
    }

    static int[,] MatrixPower(int[,] matrix, int power)
    {
        int[,] result = matrix;

        for (int i = 1; i < power; i++)
        {
            result = MultiplyMatrices(result, matrix);
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}