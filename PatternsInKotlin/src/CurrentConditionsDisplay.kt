class CurrentConditionDisplay(internal var weatherData : Subject) : observer, DisplayElement {
    var temperature: Float = 0.toFloat()
    var humidity: Float = 0.toFloat()

    init{
        weatherData.registerObserver(this)
    }

    override fun Update(temperature: Float, humidity: Float, pressure: Float) {
            this.temperature = temperature
            this.humidity = humidity
            display()
    }

    override fun display() {
        println("Current conditions: " + temperature + "C degrees and " + humidity + "% humidity")
    }
}