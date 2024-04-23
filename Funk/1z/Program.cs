// while (sum % 2 == 2 || num == q)
// {
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
// }




// if (num < 10)
// {
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
// }

// if (num >= 10 && num < 100)
// {
//     Foo10();
// }

// if (num >= 100)
// {
//     Foo100();
// }


// while (sum % 2 == 2 || num == q)
// {
//     Console.WriteLine("Введите число");
//     string num = Console.ReadLine();
// }

// if (num = "q")


// int Foo10()
// {
//     int fnum = num / 10;
//     int lnum = num % 10;
//     int sum = fnum + lnum;
//     return sum;
// }

// int Foo100()
// {
//     int fnum = num / 100;
//     int lnum = num % 10;
//     int sum = fnum + lnum;
//     return sum;
// }


// if (num < 10)
// {
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
// }

// if (num >= 10 && num < 100)
// {
//     Foo10();
// }

// if (num >= 100)
// {
//     Foo100();
// }





// int ConculateSUM()
// {
//    int sum = 0 ;
//     lastnum  = num % 10 
//     sum = sum + lastnum
//     num = num / 10

// }

// int ferst()
// {
//     int fnum = num / 100;
//     int lnum = num % 10;
//     int sum = fnum + lnum;
//     return fnum;
// }

int sum = 0;
bool end = true;

while (end)
{
Console.WriteLine("Введите целое число");

string count = Console.ReadLine();

if (count == "q" )
{
    break;
}
else 
{
    int num = Convert.ToInt32(count);

    if(num >= 10 && num < 1000)
    {
        while (num > 0)
        {
            int lastnum = 0;
            lastnum  = num % 10 ;
            sum = sum + lastnum ;
            num = num / 10 ;
        }
        
    }
    
    if (sum % 2 == 0)
    {
        break;
    }
}
}

// int number;
// if (int.TryParse(count, out number))
// {
//          if (number > 10 && number < 100)
//              { 
//                  Foo10();
//                  if (sum % 2 == 0)
//                      {
//                          break;
//                      }

//              }
//          if (number > 100 && number < 1000)
//              {
//                  Foo100();
//                  if (sum % 2 == 0)
//                      {
//                          break;
//                      }                 
//              }
// }
// }
