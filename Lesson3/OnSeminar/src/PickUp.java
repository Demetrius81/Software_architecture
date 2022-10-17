//2.	Создать конкретный автомобиль путём наследования класса «Car»
class  PickUp extends Car implements Refueling,Wiping
{
    private int loadCapacity;

    @Override
    public void fuel() {}
    @Override
    public void wipWindshield(){}
    @Override
    public void wipHeadlights(){}
    @Override
    public void wipMirrors(){}

    public int getLoadCapacity() {
        return loadCapacity;
    }
    public void setLoadCapacity(int loadCapacity) {
        this.loadCapacity = loadCapacity;
    }
}
