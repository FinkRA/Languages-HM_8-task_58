// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void GenerateTable(int[,] array, int row, int col)
{
    int[,] table = new int[row, col];
    Random element = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            table[i, j] = element.Next(100);
            array[i, j] = table[i, j];
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введитче число рядов первой матрицы: ");
int rowTable1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы: ");
int colTable1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Первая матрица:");
int[,] table1 = new int[rowTable1, colTable1];
GenerateTable(table1, rowTable1, colTable1);

Console.Write("Введитче число рядов второй матрицы: ");
int rowTable2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы: ");
int colTable2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int[,] table2 = new int[rowTable2, colTable2];
GenerateTable(table2, rowTable2, colTable2);

Console.WriteLine("Результирующая матрица:");
if ((rowTable1 == colTable2) & (rowTable2 == colTable1))
{
    for (int z = 0; z < rowTable1; z++)
    {
        for (int x = 0; x < rowTable1; x++)
        {
            int sum = 0;
            for (int y = 0; y < rowTable2; y++)
            {
                sum = sum + table1[x, y] * table2[y, z];
            }
            Console.Write(sum + " ");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Произведение этих матриц невозможно.");