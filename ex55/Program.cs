// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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


int[,] ArrayChangeRovCol(int[,] array1) //метод замены первой и последней строки массива
{
    if (array1.GetLength(0) != array1.GetLength(1))
    {
        Console.WriteLine("введите массив с одинаковым кол-вом строк и столбцов");
        return array1;
    }
    int[,] array2 = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)//1-столбцы
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array2[i, j] = array1[j, i];
        }

    }

    return array2;
}

int[,] arrayResult2 = ArrayChangeRovCol(arrayResult1);
Console.WriteLine("массив перевернут:");
PrintArray(arrayResult2);

int[,] ArrayChangeRovCol2(int[,] array1) //метод замены первой и последней строки массива
{
    int[,] array2 = new int[array1.GetLength(1), array1.GetLength(0)];
    for (int i = 0; i < array1.GetLength(1); i++)//1-столбцы
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            array2[i, j] = array1[j, i];
        }

    }

    return array2;
}

int[,] arrayResult3 = ArrayChangeRovCol2(arrayResult1);
Console.WriteLine("массив перевернут:");
PrintArray(arrayResult3);
