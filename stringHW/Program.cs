// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// char [,] simvol_array = new char[,]{
//     {'q', 'y', 'm'},
//     {'s', 'L', '&'},
// };

// string result = "";

// void FillingString()
// {
//     for (int i = 0; i < simvol_array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < simvol_array.GetLength(1); j++)
//         {
//             result = result + simvol_array[i,j];
//         }
//     }
// }

// void PrintString()
// {
//     Console.Write(result);
// }

// FillingString();
// PrintString();

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string str = "qYmSL&" ;
// string result = "";

// string FillingString()
// {
//     result = str.ToLower();

//     return result;
// }

// void PrintString()
// {
//     Console.Write(result);
// }

// FillingString();
// PrintString();

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = "TeneT" ;

char[] palindrom = new char[str.Length];
int i = 0;
int j = palindrom.Length-1;

for ( i = 0; i < palindrom.Length; i++)
    {
        palindrom[i] = str[i];
    }

while (i < j)
{
    if (palindrom[i] == palindrom[j])
    {
        i++;
        j = j - 1;
        Console.Write("Строка является полиндромом");
    }
    else 
    {
        Console.Write("Строка не является полиндромом");
    }
}

// if (palindrom[i] == palindrom[j]) // попробовать с фор
//         {
//             i++;
//             j = j - 1;
//             Console.Write("Строка является полиндромом");
//         }
//         else 
//         {
//             Console.Write("Строка не является полиндромом");
//         } 

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

