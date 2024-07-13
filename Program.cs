Console.WriteLine($"Введите сумму в долларах: ");
double dollars = Convert.ToDouble(Console.ReadLine());

double Rate = 87.99;
double rubles = dollars * Rate;

Console.WriteLine($"{rubles.ToString("C", new System.Globalization.CultureInfo("ru-ru"))} = {dollars.ToString("C", 
new System.Globalization.CultureInfo("en-US"))}");

Console.ReadLine();