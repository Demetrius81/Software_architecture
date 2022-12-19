package Decorator;

/**
 * Класс - конкретный декоратор. Предоставляет функционал усиленной подвески
 */
public class CarWithReinforcedSuspension extends CarDecorator {
    /**
     * Конструктор класса
     *
     * @param car автомобиль для добавления дополнительного функционала
     */
    public CarWithReinforcedSuspension(Car car) {
        super(car.getName() + " with reinforced suspension", car);
    }

    @Override
    public int getCost() {
        return car.getCost() + 95_000;
    }
}
