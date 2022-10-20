package Decorator;

/**
 * Класс - модель конкретного автомобиля
 */
public class Lada extends Car {
    /**
     * Конструктор класса
     */
    public Lada() {
        super("Lada");
    }

    @Override
    public int getCost() {
        return 400_000;
    }
}
