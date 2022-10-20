package Decorator;

public class CarSportyDesign extends CarDecorator {
    public CarSportyDesign(Car car) {
        super(car.getName() + " sporty design", car);
    }

    @Override
    public int getCost() {
        return car.getCost() + 200_000;
    }
}
