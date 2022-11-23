//Семинар7 Задача1 Задайте двумерный массив mxn,
// заполненный случайными вещественными числами.

/*double [,] CreateRandom2dArray (int rows, int colonms, int minValue, int maxValue)
{
    double [,] array = new double [rows, colonms];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colonms; j++)
            array [i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        return array;
}
void Show2dArray (double [,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        Console.Write(array [i, j] + " ");
    Console.WriteLine();
    }
}

Console.Write("Inpute rows; ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input colonms: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input mitValue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(n, m, min, max);
Show2dArray(myArray);
*/

// Задача2 Программа принимает на вход позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указывает,
// что такого элемента нет.

/*int [,] CreateRandom2dArray (int rows, int colunms)
{
    int [,] array = new int [rows, colunms];
    for(int i = 0; i < rows; i++)
        for (int j = 0; j < colunms; j++)
         array [i,j] = new Random().Next(0,100);
         return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
void Search(int row, int colunm, int[,]array)
{
    if(row > array.GetLength(0)-1 || colunm > array.GetLength(1)-1 || row < 0 || colunm < 0)
    Console.WriteLine("There are no numbers with such indices in the array");
    else
    Console.WriteLine("["+row+","+colunm+"] is "+array[row, colunm]+"");
}
Console.WriteLine("Input rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input colunms: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);

Console.WriteLine("Input the row: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the colunm: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Search(m1, n1, myArray);
*/

//Задача3 Задать двумерный массив из целых чисел. Найти среднеарифметическое
// элементов в каждом столбце.

/*int [,] CreateRandom2dArray (int rows, int colunms)
{
    int[,] array = new int[rows, colunms];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colunms; j++)
         array [i,j] = new Random().Next(0,100);
         return array;
}
void Show2dArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
void Arithmetics(int[,]array)
{
    double sum = 0;
    for(int j = 0; j <  array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
           sum += array[i,j]; 
        }
        Console.Write(sum/array.GetLength(1) + " ");
    }
}
Console.WriteLine("Input rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input colunms: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
Arithmetics(myArray);
*/