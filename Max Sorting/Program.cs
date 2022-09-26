using static System.Console;
Clear();

int[] array = { 1, 2, 8, 9, 4, 7, 3, 6, 5,6,9 };
Array.ForEach(array,elements=>Write(" "+elements));
WriteLine();

for (int i = 0; i < array.Length-1; i++)
{
    int maxPosition = i;
    for(int j=i+1; j<array.Length;j++)
    {
        
        if (array[j]>array[maxPosition])
        {
           
            maxPosition=j;
        }
        
    }
     int temp=array[i];
            array[i]=array[maxPosition];
            array[maxPosition]=temp;
        
}

Array.ForEach(array,el=>Write(" "+el));


