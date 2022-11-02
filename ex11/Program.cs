Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number <= 0)
    Console.WriteLine("Вы ввели некорректное число");
else if (number / 10 == 0)
        Console.WriteLine("У введенного вами числа нет второй цифры");
    else 
    {
        int quantity = Convert.ToInt32(Math.Truncate(Math.Log10(number)));
        int pow10 = Convert.ToInt32(Math.Pow(10, quantity - 1));
        int n1 = number / Convert.ToInt32(Math.Pow(10, quantity)) * pow10;
        int n2 = number % pow10;
        Console.WriteLine(n1 + n2);
    }
 