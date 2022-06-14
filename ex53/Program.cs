// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
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

int[,] ArrayChange(int[,] array1) //метод замены первой и последней строки массива
{
    int a = array1.GetLength(0);
    int b = array1.GetLength(1);
    int[,] array2 = array1;
    // Array.Copy(array1)
    //int temp=0;
    for (int j = 0; j < array1.GetLength(1); j++)//1-столбцы
    {
        int temp = array1[0, j];
        //array2[array1.GetLength(0) - 1, j] = array1[0, j];//вот так нельзя делать, птмчт по сути = это не перенос массива,
        // а ссылка одного на другой нужно через Array.Copy
        array2[0, j] = array1[array1.GetLength(0) - 1, j];
        array2[array1.GetLength(0) - 1, j] = temp;
    }

    return array2;
}


int[,] arrayResult3 = ArrayChange(arrayResult1);
Console.WriteLine();
Console.WriteLine("метод Антона с temp замены первой и последней строки:");
PrintArray(arrayResult3);

