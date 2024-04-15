int num = new Random().Next(10,100);

int fnum = num / 10 ;
int snum = num % 10;

if (fnum > snum)
{
    Console.WriteLine(fnum);
}
else
{
    Console.WriteLine(snum);
}