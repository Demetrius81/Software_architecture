package Decorator;

public class Audi extends Car{
    public Audi() {
        super("Audi");
    }

    @Override
    public int getCost() {
        return 350_000;
    }
}
