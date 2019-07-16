using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Weather
    {
        int temperature;
        string forecast;

        public Weather()
        {

        }
        public void SetTemperature()
        {
            Random random = new Random();
            temperature = random.Next(49, 98);
        }
        public void SetForecast()
        {
            List<string> ForecastOptions = new List<string>();
            ForecastOptions.Add("Sunny");
            ForecastOptions.Add("Cloudy");
            ForecastOptions.Add("Rainy");

            Random random = new Random();
            int index = random.Next(0, 2);
            forecast = ForecastOptions[index];
            
        }
    }
}
