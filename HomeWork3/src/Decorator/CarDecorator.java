package Decorator;

/**
 * Абстрактный класс декоратор
 */
public abstract class CarDecorator extends Car {
    protected Car car;

    /**
     * Конструктор класса
     *
     * @param name название (марка) автомобиля
     * @param car  автомобиль для добавления нового функционала
     */
    public CarDecorator(String name, Car car) {
        super(name);
        this.car = car;
    }
}
