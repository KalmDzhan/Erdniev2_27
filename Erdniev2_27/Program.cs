int n, x, lastDigit, twoDigit;

Console.Write("Введите n: ");
n = Convert.ToInt32(Console.ReadLine());

lastDigit = n % 10;
twoDigit = n / 10;

x = lastDigit * 100 + twoDigit;

Console.WriteLine(x);
Console.ReadKey();
