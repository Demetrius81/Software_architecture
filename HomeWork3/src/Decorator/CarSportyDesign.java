package Decorator;

/**
 * Класс - конкретный декоратор. Предоставляет функционал спортивного дизайна кузова
 */
public class CarSportyDesign extends CarDecorator {
    /**
     * Конструктор класса
     *
     * @param car автомобиль для добавления дополнительного функционала
     */
    public CarSportyDesign(Car car) {
        super(car.getName() + " sporty design", car);
    }

    @Override
    public int getCost() {
        return car.getCost() + 200_000;
    }
}
