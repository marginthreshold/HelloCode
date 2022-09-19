using static System.Console;

int[] array={1,244,3,43,5,67,7,899,9};

int Max (int a, int b, int c)
{
    int max= Math.Max(a,b);
    max= Math.Max(max,c);
    return max;
}

Write (Max(Max (array[1],array[2],array[3]),
            Max (array[4],array[5],array[6]),
            Max (array[7],array[8],array[0])));