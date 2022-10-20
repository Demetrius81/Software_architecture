package Decorator;

public class CarWithAudio extends CarDecorator{
    public CarWithAudio(Car car) {
        super(car.getName() + " with audio preparation", car);
    }

    @Override
    public int getCost() {
        return car.getCost() + 50_000;
    }
}
