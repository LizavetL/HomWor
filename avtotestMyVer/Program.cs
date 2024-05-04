// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


// Console.WriteLine("Введите позицию по строкам");
// int positionX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию по столбцам");
// int positionY = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[3, 4];

// void FilingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 1000);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintElement()
// {
// if (positionX > array.GetLength(0))
// {
//     Console.WriteLine("Позиция по строкам выходит за пределы массива");
// }

// if (positionY > array.GetLength(1))
// {
//     Console.WriteLine("Позиция по столбцам выходит за пределы массива");
// }
// else
// {
//     Console.WriteLine(array[positionX,positionY]);
// }
// }

// FilingArray();
// PrintArray();
// PrintElement();



// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

// int[,] array = new int[3, 4];

// void FilingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 1000);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void FillingReverseArray2()
// {
// for (int i = 0; i < array.GetLength(1); i++)
//     {
//          int Value = array[0,i];
//          array[0,i] = array[array.GetLength(0)-1,i];
//          array[array.GetLength(0)-1,i] = Value;
//     }
// }

// FilingArray();
// PrintArray();
// Console.WriteLine();
// FillingReverseArray2();
// PrintArray();

//  Неудачные попытки
// void FillingReverseArray()
// {

// for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int i_last = 0;
//             int Value = array[i,j];
//             array[i,j] = array[i_last,j];
//             array[i_last,j] = Value;
//         }
//     }
// }


// for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int i_last = 0;
//             int Value = array[i,j];
//             array[i,j] = array[i_last,j];
//             array[i_last,j] = Value;
//         }
//     }
    // for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         Console.Write(array[i, j]+ "\t");
    //     }
    //     Console.WriteLine();

//     while(i = 0)
//     {
//         for (j = 0; j < array.GetLength(1); j++ )
        
//         {
//             int Value = array[i,j];
//             array[i,j] = array[i_last,j];
//             array[i_last] = Value;
//             j++;
//         }
//     }
// }







// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

int[,] array = new int[3, 4];

void FilingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 1000);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}

int[] FilingSamArray()
{
int[] sum = new int[array.GetLength(0)];
for (int i = 0; i < sum.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
            {
                sum[i] += array[i, j];
            }
    }

    Console.Write(sum[0]+ sum[1]+ sum[2]+ "\t");    
    return sum;
}

void FindMin()
{
    int[] sum = FilingSamArray();
    int mini = 0;

        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[mini] > sum[i])
            {
                mini = i;
            }
        }
    Console.Write("строка с наименьшей суммой элементов : "+ mini);
}

FilingArray();
PrintArray();
FilingSamArray();
FindMin();