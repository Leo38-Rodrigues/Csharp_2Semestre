
Console.WriteLine("O que deseja converter?" +
                  "\n-------------------------" +
                  "\n1 - [C] Celsius" +
                  "\n2 - [F] Fahrenheit" +
                  "\n3 - [k] Kelvin");
string? temperatura = Console.ReadLine();
if (temperatura == "C") // CELSIUS --------------------------------------------------------------
{
    Console.WriteLine("para que deseja converter?" +
                  "\n-------------------------" +
                  "\n2 - [F] Fahrenheit" +
                  "\n3 - [K] Kelvin");
    string? choice1 = Console.ReadLine();
    if (choice1 == "F")
    {
        Console.WriteLine("\nDigite o valor em Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {celsius} em fahrenheit é:");
        Console.WriteLine(TempeatureConverter.CelsiusToFahrenheit(celsius));
    }
    else if (choice1 == "K")
    {
        Console.WriteLine("Digite o valor em Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {celsius} em Kelvin é:");
        Console.WriteLine(TempeatureConverter.CelsiusToKelvin(celsius));
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
else if (temperatura == "F") // FAREINHEIT ------------------------------------------------
{
    Console.WriteLine("para que deseja converter?" +
                  "\n-------------------------" +
                  "\n2 - [C] Celsius" +
                  "\n3 - [K] Kelvin");
    string? choice2 = Console.ReadLine();
    if (choice2 == "C")
    {
        Console.WriteLine("Digite o valor em Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {fahrenheit} em Celsius é:");
        Console.WriteLine(TempeatureConverter.FahrenheitToCelsius(fahrenheit));
    }
    else if (choice2 == "K")
    {
        Console.WriteLine("Digite o valor em Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {fahrenheit} em Kelvin é:");
        Console.WriteLine(TempeatureConverter.FahrenheitToKelvin(fahrenheit));
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
else if (temperatura == "K") // KELVIN ---------------------------------------------------------
{
    Console.WriteLine("para que deseja converter?" +
                  "\n-------------------------" +
                  "\n2 - [C] Celsius" +
                  "\n3 - [F] Fahrenheit");
    string? choice3 = Console.ReadLine();
    if (choice3 == "C")
    {
        Console.WriteLine("\nDigite o valor em Kelvin:");
        double kelvin = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {kelvin} em Celsius é:");
        Console.WriteLine(TempeatureConverter.KelvinToCelsius(kelvin));
    }
    else if (choice3 == "F")
    {
        Console.WriteLine("\nDigite o valor em Kelvin:");
        double kelvin = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {kelvin} em Fahrenheit é:");
        Console.WriteLine(TempeatureConverter.KelvinToFahrenheit(kelvin));
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
else
{
    Console.WriteLine("Opção inválida!");
}

