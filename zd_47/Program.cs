// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Выводим массив заполненный случайными вещественными числами");
int m = 3;
int n = 4;

double [,] FillArrayRandom(int m, int n)
{
      
    double [,] massiv = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massiv[i, j] = Convert.ToDouble(new Random().Next(-10, 10))/10;
        }
    }
    return massiv;
}

//Вывод элементов массива на экран
void PrintArray(double [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            
            if (massiv[i, j]>=0) Console.Write("  "+  massiv[i, j] + "    ");
            else  Console.Write($" {massiv[i, j]}" + "    ");
           
        }
        Console.WriteLine();
    }
}
double [,] array1 = FillArrayRandom(m, n);
PrintArray(array1);
