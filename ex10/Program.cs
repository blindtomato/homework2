int number = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано число {number}");

int number2 = (number / 10) % 10;

Console.WriteLine($"Вторая цифра сгенерированного числа {number2}");
