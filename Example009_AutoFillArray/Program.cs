using static System.Console;
Clear();

void FillArray(int[] colleciton)
{
    int lenght = colleciton.Length;
    int index = 0;
    while (index < lenght)
    {
        colleciton[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position =0;
    while(position<count)
    {
        WriteLine(coll[position]);
        position++;

    }
}

int[] array=new int[10];

FillArray(array);
PrintArray(array);
