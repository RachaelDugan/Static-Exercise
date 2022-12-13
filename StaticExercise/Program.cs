namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double celsius = TempConverter.FarenheitToCelsius(75);
            Console.WriteLine($"This is the temp in to celsius: {celsius}");
            Console.WriteLine();
            double farenheit = TempConverter.CelsiusToFarenheit(celsius);
            Console.WriteLine($"This is the temp in farenheit: {farenheit}");
        }
    }
}
