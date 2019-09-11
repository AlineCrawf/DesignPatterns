 public interface observer{
    fun Update(temperature: Float, humidity: Float, pressure: Float)
}

public interface  Subject {
    fun registerObserver(o: observer)
    fun removeObserver(o: observer)
    fun notifyObservers()
}

public interface DisplayElement{
    fun display()
}