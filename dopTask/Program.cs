//  Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа,
//  необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
Console.WriteLine("Введите значение радиуса круга:");
int r = Convert.ToInt32(Console.ReadLine());
double PI = Math.PI; 
double S = PI*r*r;
int P = Convert.ToInt32(Math.Round(S));
int[] a = new int[1];
int index = 0;
while (P != 0)
     {
        int y = P % 10;
        Array.Resize(ref a, a.Length + 1);
        a[index] = y;
        P = (P - y) / 10;
        index++;
     }
int Max(int[] arr)
{
    int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i]) max = arr[i];

}
return max;
}
Console.WriteLine(Max(a));