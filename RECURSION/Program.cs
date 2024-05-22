// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите первое число");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int n = Convert.ToInt32(Console.ReadLine());


//  void PrintNam()
// {
//     Console.WriteLine(m);
//     m++;

//     if (m > n)
//     {
//         return;
//     }

//     PrintNam();
// }

// void PrintNum()
// {
//     Console.WriteLine(n);
//     n++;

//     if (n > m)
//     {
//         return;
//     }

//     PrintNum();
// }

// if (n > m)
// {
//     PrintNam();
// }
// else
// {
//     PrintNum();
// }



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

// Console.WriteLine("Введите неотрицательное число n");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите неотрицательное число m");
// int n = Convert.ToInt32(Console.ReadLine());

// int Ackermann(int n, int m)
//     {
//         if (n == 0) 
//         {
//             return m + 1;
//         }

//         if (m == 0) 
//         {
//             return Ackermann(n - 1, 1);
//         }

//          return Ackermann(n - 1, Ackermann(n, m - 1));
        
//     }
// void PrintResult()
//     {
//         Console.WriteLine(Ackermann(m, n));
//     }

// PrintResult();



// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array =new int[5];
int i = 0; 
int i_last = array.Length - 1;

void FillingАrray()
{

    if(i > array.Length -1)
        {
            return;
        } 

    array[i] = new Random().Next(1, 1000);

    i++;

    FillingАrray();
}

void PrintArray()
{
    Console.Write(i+ "\t");
    i++;

    if(i == array.Length)
        {
            return;
        } 
    PrintArray();
}

void InvertedArray()
{
    if(i == array.Length)
    {
        return;
    } 
    int Val = array[i];
    array[i] = array[i_last];
    array[i_last] = Val;
    i++;
    i_last = i_last -1 ;
    InvertedArray();
}

FillingАrray();
PrintArray();
InvertedArray();
PrintArray();