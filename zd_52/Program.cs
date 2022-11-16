// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Выводим массив заполненный случайными вещественными числами");
int m = 3;
int n = 4;
int [,] FillArrayRandom(int m, int n)
{      
    int [,] massiv = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massiv[i, j] = new  Random().Next(0, 10) ;
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
            if (massiv[i, j]>=0) Console.Write("  "+  massiv[i, j] + "    ");
            else  Console.Write($" {massiv[i, j]}" + "    ");           
        }
        Console.WriteLine();
    }
}

void PrintArray2(double [] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {        
            // Console.Write($"{0:F1}",massiv[i] +"    "); 
           
            Console.Write(Math.Round(massiv[i],2)+  "     ");   
           
                   
    } 
}

 
// Рассчитываем среднее арифметическое по столбцам

double [] AverageMean(int [,] massiv)
{       
    
    double [] averageColumn= new double[4];
    for(int j=0;j<massiv.GetLength(1);j++)    
    {double sum=0;
        for(int i=0;i<massiv.GetLength(0);i++)
        {  
             sum=sum+massiv[i,j];                            
        }
        double average=sum/massiv.GetLength(0);

        // Console.Write($"{average:F2}  ",average);
        averageColumn[j]=average;
    }
    return averageColumn;
}

int [,] array1 = FillArrayRandom(m, n);
PrintArray(array1);
 Console.WriteLine();
double [] res=AverageMean(array1);


 PrintArray2(res);


