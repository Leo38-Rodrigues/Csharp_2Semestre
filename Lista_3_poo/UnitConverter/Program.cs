Console.WriteLine("O que deseja converter?" +
                  "\n-------------------------" +
                  "\n1 - [C] Compimento" +
                  "\n2 - [M] Massa" +
                  "\n3 - [T] Tempo");
string? temperatura = Console.ReadLine();
if (temperatura == "C") // COMPRIMENTO --------------------------------------------------------------
{
    Console.WriteLine("Qual unidade deseja converter?" +
                  "\n-------------------------" +
                  "\n2 - [1] Milimetros" +
                  "\n3 - [2] Metros" );
    string? choice1 = Console.ReadLine();
    if (choice1 == "1")
    {
        Console.WriteLine("\nDigite o valor em milimetros:");
        double mili = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {celsius} em fahrenheit é:");
        Console.WriteLine(UnitConverter.MilimetrosforMetros(mili));
    }
    else if (choice1 == "2")
    {
        Console.WriteLine("Digite o valor em Metros:");
        double metros = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {celsius} em Kelvin é:");
        Console.WriteLine(UnitConverter.MetrosforMilimetros(metros));
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
else if (temperatura == "M") // MASSA  ------------------------------------------------
{
    Console.WriteLine("Qual unidade deseja converter?" +
                  "\n-------------------------" +
                  "\n2 - [1] Gramas" +
                  "\n3 - [2] Kilogramas" );
    string? choice1 = Console.ReadLine();
    if (choice1 == "1")
    {
        Console.WriteLine("\nDigite o valor em gramas:");
        double gramas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {gramas} em Kilogramas é:");
        Console.WriteLine(UnitConverter.GramasforKilogramas(gramas));
    }
    else if (choice1 == "2")
    {
        Console.WriteLine("Digite o valor em kilogramas:");
        double kgramas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {kilogramas} em gramas é:");
        Console.WriteLine(UnitConverter.KilogramasforGramas(kgramas));
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
else if (temperatura == "T") // KELVIN ---------------------------------------------------------
{
    Console.WriteLine("Qual unidade deseja converter?" +
                  "\n-------------------------" +
                  "\n2 - [1] Horas:minutos" +
                  "\n3 - [2] Segundos" );
    string? choice1 = Console.ReadLine();
    if (choice1 == "1")
    {
        Console.WriteLine("\nDigite o valor em gramas:");
        double gramas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {gramas} em Kilogramas é:");
        Console.WriteLine(UnitConverter.GramasforKilogramas(gramas));
    }
    else if (choice1 == "2")
    {
        Console.WriteLine("Digite o valor em kilogramas:");
        double kgramas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("valor {kilogramas} em gramas é:");
        Console.WriteLine(UnitConverter.KilogramasforGramas(kgramas));
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

