package Decorator;

/**
 * Класс - конкретный декоратор. Предоставляет функционал дополнительной аудиосистеммы
 */
public class CarWithAudio extends CarDecorator {
    /**
     * Конструктор класса
     *
     * @param car автомобиль для добавления дополнительного функционала
     */
    public CarWithAudio(Car car) {
        super(car.getName() + " with audio preparation", car);
    }

    @Override
    public int getCost() {
        return car.getCost() + 50_000;
    }
}
