namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double tempF = 212;
            double tempC = 100;
            
            double convertedToC = TempConverter.FahrenheitToCelsius(tempF);
            double convertedToF = TempConverter.CelsiusToFahrenheit(tempC);
            
            Console.WriteLine($"{tempF} F is {convertedToC}");
            Console.WriteLine($"{tempC} C is {convertedToF}");
        }
    }
}
