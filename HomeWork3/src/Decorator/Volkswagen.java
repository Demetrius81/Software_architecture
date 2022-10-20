package Decorator;

public class Volkswagen extends Car{
    public Volkswagen() {
        super("Volkswagen");
    }

    @Override
    public int getCost() {
        return 300_000;
    }
}
