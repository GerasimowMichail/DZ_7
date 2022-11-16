// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число для проверки");
int a = Convert.ToInt32(Console.ReadLine());
int m = 3;
int n = 4;
int[,] FillArrayRandom(int m, int n)
{
    int[,] massiv = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massiv[i, j] = new Random().Next(0, 10);
        }
    }
    return massiv;
}
//Вывод элементов массива на экран
void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (massiv[i, j] >= 0) Console.Write("  " + massiv[i, j] + "    ");
            else Console.Write($" {massiv[i, j]}" + "    ");
        }
        Console.WriteLine();
    }
}
// поиск позиции элемента введенного с клавиатуры

int[] Pozition(int[,] array, int num)
{
    int[] numPozition = new int[3];
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == a)
            {
                numPozition[0] = i;
                numPozition[1] = j;
                
                flag = true;
                break;
            }
            else flag = false;
        }
    }
    if (flag == false) numPozition[2] = 0;
    else numPozition[2] = 1;
    return numPozition;
}

void PrintArray2(int[] massiv)
{
    for (int i = 0; i < massiv.GetLength(0) - 1; i++)
    {
      
        Console.Write($"{massiv[i]}" + "  ");
       

    }
}

int[,] randMas = FillArrayRandom(m, n);
PrintArray(randMas);
int[] mas1 = Pozition(randMas, a);
if (mas1[2] == 1) PrintArray2(mas1);
else Console.WriteLine("Такого элемента нет в массиве");
