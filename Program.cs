Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Выберите тип конвертации:\n1 - Рубли -> Доллары\t 2 - Доллары -> Рубли");
string type = Console.ReadLine();

double rate = 87.74;

switch (type)
{
    case "1":
        Console.WriteLine($"Введите сумму в рублях: ");
        
        double rublesQuantity = Convert.ToDouble(Console.ReadLine());
        double quantityDollars = rublesQuantity / rate;

        Console.WriteLine($"{quantityDollars.ToString("C", new System.Globalization.CultureInfo("en-US"))} = {rublesQuantity.ToString("C", 
        new System.Globalization.CultureInfo("ru-ru"))}");

        break;

    case "2":
        Console.WriteLine($"Введите сумму в долларах: ");

        double dollarsQuantity = Convert.ToDouble(Console.ReadLine());
        double quantityRubles = dollarsQuantity * rate;

        Console.WriteLine($"{quantityRubles.ToString("C", new System.Globalization.CultureInfo("ru-ru"))} = {dollarsQuantity.ToString("C", 
        new System.Globalization.CultureInfo("en-US"))}");

        break;
}

Console.ReadLine();