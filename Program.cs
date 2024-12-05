class Tempreture
{
    public static double FahrenheitToCelsius(int temp) => (temp - 32) / 1.8;
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Tempreture.FahrenheitToCelsius(64));
    }

    
}

