int[] a = new int[8];
void FillArray( int[] arr)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100);
    }
}   
 FillArray(a);
Console.Write($"[{a[0]}, {a[1]}, {a[2]}, {a[3]}, {a[4]}, {a[5]}, {a[6]}, {a[7]}]");