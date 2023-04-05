// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.



void FillArray(int [,] array)
{
    for (int i = 0;i< array.GetLength(0);i++)
    {
        for (int j = 0;j<array.GetLength(1);j++ )
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j],3} \t");
        
        }
        Console.WriteLine();
    }
}


void ReplaceRows(int [,] array)
{
    int temp = 0;
    for (int j=0;j<array.GetLength(1);j++)
    {
        temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
}





Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
ReplaceRows(array);
PrintArray(array);
