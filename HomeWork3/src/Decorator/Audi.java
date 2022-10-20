package Decorator;

/**
 * Класс - модель конкретного автомобиля
 */
public class Audi extends Car {
    /**
     * Конструктор класса
     */
    public Audi() {
        super("Audi");
    }

    @Override
    public int getCost() {
        return 350_000;
    }
}
