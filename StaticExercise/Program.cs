namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newTemp = TempConverter.FahrenheitToCelsius(70);

            Console.WriteLine($"{newTemp} celsius");

            var newerTemp = TempConverter.CelsiusToFarenheit(20);

            Console.WriteLine($"{newerTemp} farenheit");
        }
    }
}
