package Decorator;

/**
 * Класс - модель конкретного автомобиля
 */
public class Volkswagen extends Car {
    /**
     * Конструктор класса
     */
    public Volkswagen() {
        super("Volkswagen");
    }

    @Override
    public int getCost() {
        return 300_000;
    }
}
