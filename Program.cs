Console.WriteLine("Выберите тип прогрессии (1 - арифметическая, 2 - геометрическая)");
int type = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первый член прогрессии");
int firstTerm = int.Parse(Console.ReadLine());
if (type == 1)
{
    Console.WriteLine("Введите разность прогрессии");
    int difference = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите номер последнего члена");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Выберите метод решения (1 - через цикл, 2 - через формулу)");
    int method = int.Parse(Console.ReadLine());
    int sum;
    if (method == 1)
    {
        sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += firstTerm + i * difference;
        }
    }
    else
    {
        sum = (2 * firstTerm + (n - 1) * difference) * n / 2;
    }
    Console.WriteLine($"Сумма арифметической прогрессии = {sum}");
}
else
{
    Console.WriteLine("Введите знаменатель прогрессии");
    int denominator = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите номер последнего члена");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Выберите метод решения (1 - через цикл, 2 - через формулу)");
    int method = int.Parse(Console.ReadLine());
    int sum;
    if (method == 1)
    {
        sum = firstTerm;

        for (int i = 1; i < n; i++)
        {
            firstTerm *= denominator;
            sum += firstTerm;
        }
    }
    else
    {
        sum = firstTerm * (1 - (int)Math.Pow(denominator, n)) / (1 - denominator);
    }
    Console.WriteLine($"Сумма геометрической прогрессии = {sum}");
}
