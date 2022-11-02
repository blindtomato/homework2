Console.WriteLine("Введите число ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number / 100 == 0)
    Console.WriteLine("Третьей цифры нет ");
else 
{
    int k = number;
    int n3 = 0;
    while (k >= 100)
    {
        n3 = k % 10;
        k = k / 10;        
    }
Console.WriteLine($"Третья цифра заданного числа {n3}");
}
