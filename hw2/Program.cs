Console.WriteLine("Введите координаты х");
int x = int.Parse(Console.ReadLine()) ;

Console.WriteLine("Введите координаты у");
int y = int.Parse(Console.ReadLine()) ;

if (x == 0)
{
    Console.WriteLine("координаты x не должны равнться 0"); 
}
if (y == 0)
{
    Console.WriteLine("координаты y не должны равнться 0"); 
}

if (x > 0)
{
    if (y > 0)
    Console.WriteLine("I"); 
}
if (x > 0)
{
    if (y < 0)
    Console.WriteLine("II"); 
}
if (x < 0)
{
    if (y < 0)
    Console.WriteLine("III"); 
}
if (x < 0)
{
    if (y > 0)
    Console.WriteLine("IV"); 
}
