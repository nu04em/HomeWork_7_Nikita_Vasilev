// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-30, 31); // [-30; 30]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");

        Console.WriteLine();
    }
}

void MatrixExchange(int[,] matrix)
{
    Console.Write("Укажите позиции в массиве: ");
    int[] count = Console.ReadLine()!.Split().Select(a => int.Parse(a)).ToArray();
    int row = count[0];
    int column = count[1];
    int countsRow = matrix.GetLength(0);
    int countsColumn = matrix.GetLength(1);

    if (row > countsRow || column > countsColumn || row < 1 || column < 1)
        {
            Console.Write("Такой позиции нет");
            return;
        }
    else
        Console.Write($"Согласно указанной позиции, значение в массиве равно: {matrix[row -1, column -1]}");
} 
    
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
MatrixExchange(matrix);
