Console.WriteLine("Введите число от 1 до 7 ");
int day = Convert.ToInt32 (Console.ReadLine());

if (day >= 1 && day <= 5)
    Console.WriteLine("Не является выходным");
else if (day == 6 || day == 7)
        Console.WriteLine("Является выходным");
    else
        Console.WriteLine("Вы ввели некорректное число");