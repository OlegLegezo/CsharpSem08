// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


int[,] GetArray(int a, int b) //метод заполнения массива целыми числами
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-столбцы
        {
            array[i, j] = rnd.Next(0, 10); //или array[i, j]=rnd.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array) //метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-столбцы
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] arrayResult1 = GetArray(m, n);
Console.WriteLine("массив №1:");
PrintArray(arrayResult1);
Console.WriteLine();


void Remover(int[,] arr)
{
    int[,] newarr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int min = arr[0, 0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                imin = i;
                jmin = j;
            }
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)//0-строки
    {
        if (i != imin)
        {
            for (int j = 0; j < arr.GetLength(1); j++)//1-столбцы
            {
                if (j != jmin)
                {
                    Console.Write(arr[i, j] + " ");
                }

            }
        }
        Console.WriteLine();

    }
}

Remover(arrayResult1);