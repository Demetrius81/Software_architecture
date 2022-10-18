public class FutereCar extends Car {
    FutereCar() {
        this.setNumberWheels(3);
    }

    @Override
    public void movement() {
        fly();
    }

    private void fly() {
    }
}
