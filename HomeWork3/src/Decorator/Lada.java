package Decorator;

public class Lada extends Car{
    public Lada() {
        super("Lada");
    }

    @Override
    public int getCost() {
        return 400_000;
    }
}
