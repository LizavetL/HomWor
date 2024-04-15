Console.WriteLine("Введите число");

string num = Console.ReadLine();
string mun = "" ;
int line = 0 ;

for (int i = num.Length-1; i >= 0; i--) 
{
    mun += num ;
}

int mun0 = Convert.ToInt32(mun) ;
while (mun0 % 10 > 0 ) // должно быть другое ограниченье
{
    line = mun0 % 10 ;
    Console.Write(line+ ", ");
    mun0 = mun0 / 10 ;
}