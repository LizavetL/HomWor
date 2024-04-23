int[] array =new int[5];
int eveN = 0;

void FillingАrray()
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
}

int CountingEvenElements()
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        eveN++;
    }
}
return eveN;
}


void OutputValue()
{
Console.Write(eveN);
}

FillingАrray();
CountingEvenElements();
OutputValue();