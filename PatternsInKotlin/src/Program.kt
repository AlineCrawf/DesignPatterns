fun main(args: Array<String>)
{
    var weatherData: WeatherData = WeatherData()
    var currentDisplay :CurrentConditionDisplay = CurrentConditionDisplay(weatherData)
    weatherData.setMeasurements(80f, 65f, 30.4f)
    weatherData.setMeasurements(82f,70f,29.2f)
    weatherData.setMeasurements(78f,90f,29.2f)
}