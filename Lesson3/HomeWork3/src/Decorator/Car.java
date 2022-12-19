package Decorator;

/**
 * Абстрактный класс - модель автомобиля
 */
public abstract class Car {
    private String name;

    public String getName() {
        return name;
    }

    /**
     * Конструктор класса
     *
     * @param name название (марка) автомобиля
     */
    public Car(String name) {
        this.name = name;
    }

    /**
     * Получить цену автомобиля
     *
     * @return цена автомобиля
     */
    public abstract int getCost();
}
