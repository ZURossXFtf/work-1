// See https://aka.ms/new-console-template for more information
//Захаров Иван Алексеевич 22-ИСП-2/2 Вариант 18
//sin*sqrt(x-1) - sin*sqrt(x+1)


try
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    double res = Math.Sin(Math.Sqrt(x + 1)) - Math.Sin(Math.Sqrt(x - 1));
    Console.WriteLine($"{res:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
