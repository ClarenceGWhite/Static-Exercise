using StaticExercise;
namespace StaticExercise
{

    
    public class Program
    {
       

        static void Main()
        {
            Console.WriteLine("Enter a Fahrenheit temperature you wish to convert to Celsius...");
            var fCon = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Celsius conversion for {fCon} Fahrenheit equals...");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(fCon));
           

            Console.WriteLine();

            Console.WriteLine("Enter a Celsius temperature you wish to convert to Fahrenheit...");
            var cCon = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Celsius conversion for {cCon} Celsius equals...");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(cCon));
           

        }
    }
}
