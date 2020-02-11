using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            String s = "Current Weather Condition:";
            s += "temperature : " + temperature + ", ";
            s += "humidity : " + humidity;
            Console.WriteLine(s);
        }
    }

    public class AwfulForecastDisplay : Observer, DisplayElement
    {
        private Subject weatherData;
        private string forecast;

        public AwfulForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Next weather will be ... " + forecast);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            forecast = Forecast(temp, humidity, pressure);
            Display();
        }

        string Forecast(float temp, float humidity, float pressure)
        {
            if (humidity > 50)
            {
                return "Rainy";
            }
            if (humidity > 10)
            {
                return "Cloudy";
            }
            return "Sunny";
        }
    }
}
