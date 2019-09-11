class WeatherData (): Subject
{
    var temperature: Float = 0.toFloat()
    var humidity: Float = 0.toFloat()
    var pressure: Float  = 0.toFloat()
    var observers: ArrayList <observer>

    init{
        observers = ArrayList <observer> ()
    }
    override fun registerObserver(o: observer)
    {
        observers.add(o)
    }

    override fun removeObserver(o: observer) {
        val i : Int = observers.indexOf(o)
        if (i >= 0)
            observers.remove(o)
    }

    override fun notifyObservers() {
        for ( i in 0..(observers.size - 1))
        {
            val obs:observer = observers.get(i)
            obs.Update(temperature,humidity,pressure)
        }
    }

    fun measurementsChanged()
    {
        notifyObservers()
    }

    fun setMeasurements(temperature: Float, humidity: Float, pressure: Float)
    {
        this.temperature = temperature
        this.humidity = humidity
        this.pressure = pressure

        measurementsChanged()
    }
}