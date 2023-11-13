using ObserverDesignPattern.src.Observers;
using ObserverDesignPattern.src.Subject;

namespace ObserverDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

            currentConditionDisplay.register(weatherStation);
            statisticsDisplay.register(weatherStation);
            forecastDisplay.register(weatherStation);
           

            weatherStation.setWeatherData(81, 71, 39);
            weatherStation.setWeatherData(85, 69, 29);
            weatherStation.setWeatherData(78, 65, 25);
        }
    }
}