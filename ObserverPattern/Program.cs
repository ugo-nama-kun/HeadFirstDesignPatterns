using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whether Data Start");

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            AwfulForecastDisplay awfulForecastDisplay = new AwfulForecastDisplay(weatherData);

            weatherData.SetMeaturements(27, 65, 30.4f);
            weatherData.SetMeaturements(28, 5, 29.2f);
            weatherData.SetMeaturements(26, 20, 29.2f);

            Console.ReadLine();
        }
    }
}
