Console.WriteLine("input number:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number >0)
    {
    int count = number % 10;
    number = number/10;
    sum = sum + count;
    }
Console.WriteLine("sum of numbers:" + sum);
