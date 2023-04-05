// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// пусть будет двумерный массив из случайных чисел от 0 до 9 включительно
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


void FillArray(int [,] array)
{
    for (int i = 0;i< array.GetLength(0);i++)
    {
        for (int j = 0;j<array.GetLength(1);j++ )
        {
            array[i,j] = new Random().Next(-1,10);
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

void PrintFreequncyArr(int [] uniq)
{
    for (int i =0;i<uniq.GetLength(0);i++)
    {
        if (uniq[i]!=0)
        Console.WriteLine($"Число {i} встречается {uniq[i]} раз");
    }
}


int[] CheckNumber(int [,] array)
{
    int[] uniq = new int[10];
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            int value = array[i,j];
            uniq[value]++;
        }

    }
    return uniq;
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
int [] array2 = CheckNumber(array);
PrintFreequncyArr(array2);