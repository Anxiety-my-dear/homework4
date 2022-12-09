// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число:");
int[] a = new int[1];
int sum =0;
int x = Convert.ToInt32(Console.ReadLine());
int index = 0;
  while (x != 0)
     {
        int y = x % 10;
        Array.Resize(ref a, a.Length + 1);
        a[index] = y;
        x = (x - y) / 10;
        index++;
     }

     for(int i = 0; i < a.Length; i++)
     {
      sum = sum + a[i];
     }
    Console.WriteLine(sum);