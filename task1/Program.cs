// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)  // matrix.GetLength(0) длина строчек либо matrix.GetLength(0) можно поменять на rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) либо cols если это передано в параметрах метода (int rows, int cols)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int [,] matr)    // печатаем двумерный Массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

// создать массив
int[,] resultMatrix = GetMatrix(3,4,0,100);   // вызов метода
 // посмотрим на нашу матрицу
 PrintMatrix(resultMatrix);


//  Задача 48: Задайте двумерный массив размера m на n, 
//  каждый элемент в массиве находится по формуле: 
//  Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)  // matrix.GetLength(0) длина строчек либо matrix.GetLength(0) можно поменять на rows
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) либо cols если это передано в параметрах метода (int rows, int cols)
//         {
//             matrix[i, j] = i+j;
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int [,] matr)    // печатаем двумерный Массив
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// // создать массив
// int[,] resultMatrix = GetMatrix(3,4,0,100);   // вызов метода
//  // посмотрим на нашу матрицу
//  PrintMatrix(resultMatrix);

