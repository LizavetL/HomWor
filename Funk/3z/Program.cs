int size = 5 ;
int[] array =new int[size];
int i_last = array.Length -1 ;
int i = 0;


void FillingАrray()
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 1000);
}
}

void FillingReverseArray()
{
    while(i < i_last)
    {
        int Value = array[i];
        array[i] = array[i_last];
        array[i_last] = Value;
        i++;
        i_last = i_last -1;
    }
}


void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" "+"\t");
    }
    Console.WriteLine();
}

FillingАrray();
PrintArray();
FillingReverseArray();
PrintArray();