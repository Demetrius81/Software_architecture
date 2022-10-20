package Decorator;

public class CarWithReinforcedSuspension extends CarDecorator{
    public CarWithReinforcedSuspension(Car car) {
        super(car.getName() + " with reinforced suspension", car);
    }

    @Override
    public int getCost() {
        return car.getCost() + 95_000;
    }
}
