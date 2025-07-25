namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input temperature in fahrenheit to convert to celsius.");

            double farTempInput;
            while (!double.TryParse(Console.ReadLine(), out farTempInput))
            {
                Console.WriteLine("Please input a valid value.");
            }

            double celsius = TempConverter.FahrenheitToCelsius(farTempInput);

            Console.WriteLine("Please input temperature in celsius to convert to fahrenheit.");

            double celTempInput;
            while (!double.TryParse(Console.ReadLine(), out celTempInput))
            {
                Console.WriteLine("Please input a valid value.");
            }

            double fahrenheit = TempConverter.CelsiusToFahrenheit(celTempInput);

            Console.WriteLine(
                $"{farTempInput} degrees fahrenheit converts to {celsius.ToString("F2")} degrees celsius.\n"
                + $"{celTempInput} degrees celsius converts to {fahrenheit.ToString("F2")} degrees fahrenheit.\n");

            Console.WriteLine("Press enter to quit.\n");
            Console.ReadLine();
        }
    }
}
