

Console.WriteLine("Введите первое число: ");
        int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
        int num_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
        int num_C = Convert.ToInt32(Console.ReadLine());
        int max = num_A;
if (num_B > max)
        {
            max = num_B;
        }
if (num_C > max)
        {
            max = num_C;
        }
        Console.WriteLine("Наибольшее число: " + max);