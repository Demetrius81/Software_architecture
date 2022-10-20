package Decorator;

public abstract class CarDecorator extends Car {
    protected Car car;
    public CarDecorator(String name, Car car) {
        super(name);
        this.car = car;
    }
}
