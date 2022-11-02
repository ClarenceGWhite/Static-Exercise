using StaticExercise;
namespace StaticExercise
{

    
    public class Program
    {
       

        static void Main()
        {

            Console.WriteLine("32 degrees F equals this Celsius value... ");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(32));

            Console.WriteLine();

            Console.WriteLine("100 degrees C equals this Fahrenheit value...");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(100));
       
        }
    }
}
