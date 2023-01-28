int[] array = new int[100];
Random random = new Random();
for (int i = 0; i < array.Length; i++) array[i] = random.Next(20);

Show show_all = new(Show_n1);
show_all += (Show_n2);
show_all += (Show_simple_n);
show_all += (Show_Fib_n);

show_all(array);

void Show_n2(int[] a)
{
    Console.WriteLine("Чётные числа в массиве ");
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]%2 == 0) Console.WriteLine(a[i]+" ");
    }
    Console.WriteLine("\n\n");
}

void Show_n1(int[] a)
{
    Console.WriteLine("Нечётные числа в массиве ");
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 1) Console.WriteLine(a[i] + " ");
    }
    Console.WriteLine("\n\n");
}

void Show_simple_n(int[] a)
{
    Console.WriteLine("Простые числа в массиве ");
    for (int i = 0; i < a.Length; i++)
    {
        for (int i1 = 2; i1 <= a[i]; i1++)
        {
            if (a[i] % i1 == 0 && a[i] > i1) break;
            else if (a[i] == i1) Console.WriteLine(a[i] + " ");
        }
    }
    Console.WriteLine("\n\n");
}

void Show_Fib_n(int[] a)
{
    Console.WriteLine("Фибоначи числа в массиве ");
    int[] b = new int[47];
    b[0] = 0;
    b[1] = 1;
    for (int i = 2; i < b.Length; i++) b[i] = b[i - 1] + b[i-2];

    for (int i = 0; i < a.Length; i++)
    {
        for (int i1 = 0; i1 < b.Length; i1++) if (a[i] == b[i1]) Console.WriteLine(a[i]+ " ");
    }
    Console.WriteLine("\n\n");
}

public delegate void Show(int[] array);