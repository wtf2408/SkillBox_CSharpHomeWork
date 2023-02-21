#region Задание 1. Случайная матрица
Console.WriteLine("Задание 1. Случайная матрица\nВведите количество строк матрицы");
int rowMatrix = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы");
int columnMatrix = int.Parse(Console.ReadLine());

int[,] matrix = CreateMatrix(rowMatrix, columnMatrix);
PrintMatrix(matrix);

int sum = 0;
foreach (var item in matrix)
{
    sum += item;
}
Console.WriteLine($"сумма - {sum}\n");
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] CreateMatrix(int row, int column) 
{
    int[,] matrix = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 20);
        }
    }
    return matrix;
}
#endregion

#region Задание 2. Сложение матриц
Console.WriteLine("Задание 2. Сложение матриц");
int[,] matrix1 = CreateMatrix(3, 3);
int[,] matrix2 = CreateMatrix(3, 3);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] sumMatrix = SumMatrixElements(matrix1, matrix2);
PrintMatrix(sumMatrix);
int[,] SumMatrixElements(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
    return matrix3;
}
#endregion