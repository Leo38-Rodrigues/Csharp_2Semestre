public class UnitConverter()
{

    // Métodos de conversão de medidas
    public static double MilimetrosforMetros(double mm)
    {
        return (celsius * 9 / 5) + 32;
    }
    public static double MetrosforMilimetros(double m)
    {
        return m * 1000;
    }
    public static double GramasforKilogramas(double g)
    {
        return g / 1000;
    }
    public static double KilogramasforGramas(double kg)
    {
        return kg * 1000;
    }
    public static double HorasMinutosforSegundos(double h, double m, double s)
    {
        return (h * 3600) + (m * 60) + s;
    }
    public static double SegundosforHorasMinutos(double s)
    {
        int h = (int)(s / 3600);
        int m = (int)((s % 3600) / 60);
        int sec = (int)(s % 60);
        Console.WriteLine($"{h} horas, {m} minutos e {sec} segundos");
        return s;
    }
}