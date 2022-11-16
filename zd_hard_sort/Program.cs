// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.Write("Введите число строк массива: ");
int row=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Формируем массив заполненный случайным образом :");

int [,] FillArray(int row, int column)
{
   
    int [,] massiv= new int [row,column];

    for(int i=0; i<row;i++)
    {
        for(int j=0; j<column; j++)
        {
            massiv[i,j]=new Random().Next(0,10);
        }
    }
    return massiv;
}

void PrintArray(int [,] massiv)
{
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            Console.Write($"{massiv[i,j]}"+ " ");
            
        }
        Console.WriteLine();
    }
}

int [,] array = FillArray(row, column);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированый массив");

int [,] arraySort=SortMassiv(array);
PrintArray(arraySort);

int [,] SortMassiv(int [,] massiv)
{   for (int k=0; k<((row-1)*(column)); k++)
        {
            for(int i=0; i<row; i++)
            { int j=0;
                for ( j=0; j<column-1; j++)
                {
                    if (massiv[i,j]>massiv[i,j+1])
                    {
                        int temp = massiv[i, j+1];
                        massiv[i,j+1]=massiv[i,j];
                        massiv[i,j]=temp;
                        
                    }                    
                }
                if (i<row-1) 
                {
                    if (massiv[i,j]>massiv[i+1,0])
                    {   int temp = massiv[i+1,0];
                        massiv[i+1,0]=massiv[i,j];
                        massiv[i,j]=temp;

                    }
                }
            }
        }

    return massiv;
}