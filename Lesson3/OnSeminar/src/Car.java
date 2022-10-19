//1.	Спроектировать абстрактный класс «Car» у которого должны быть свойства:
// - марка,
// - модель,
// - цвет,
// - тип кузова,
// - число колёс,
// - тип топлива,
// - тип коробки передач,
// - объём двигателя;
// методы:
// - движение,
// - обслуживание,
// - переключение передач,
// - включение фар,
// - включение дворников.



//3.	Расширить абстрактный класс «Car», добавить метод:
// подметать улицу. Создать конкретный автомобиль путём наследования класса «Car».
// Провести проверку принципа SRP.


//4.	Расширить абстрактный класс «Car», добавить метод:
// - включение противотуманных фар,
// - перевозка груза.
// Провести проверку принципа OCP.


//5.	Создать конкретный автомобиль путём наследования класса «Car»,
// определить число колёс = 3. Провести проверку принципа LSP.

//6.	Создать конкретный автомобиль путём наследования класса «Car»,
// определить метод «движение» - «полёт». Провести проверку принципа LSP.

//7.	Создать интерфейс «Заправочная станция», создать метод: заправка топливом.

//8.	Имплементировать метод интерфейса «Заправочная станция» в конкретный класс «Car».

//9.	Добавить в интерфейс «Заправочная станция» методы:
// - протирка лобового стекла,
// - протирка фар,
// - протирка зеркал.

//10.	Имплементировать все методы интерфейса «Заправочная станция» в конкретный класс «Car».
// Провести проверку принципа ISP.
// Создать дополнительный/е интерфейсы и имплементировать их в конкретный класс «Car».
// Провести проверку принципа ISP.




import java.awt.*;

public abstract class Car {

    //fields
    private String mark;
    private String model;
    private Color color;
    private BodyType bodyType;
    private int numberWheels;
    private TypeFuel fuelType;
    private TypeGearbox gearboxType;
    private double engineCapacity;

    //getters & setters
    public String getMark() {
        return mark;
    }

    public void setMark(String mark) {
        this.mark = mark;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public Color getColor() {
        return color;
    }

    public void setColor(Color color) {
        this.color = color;
    }

    public BodyType getBodyType() {
        return bodyType;
    }

    public void setBodyType(BodyType bodyType) {
        this.bodyType = bodyType;
    }

    public int getNumberWheels() {
        return numberWheels;
    }

    public void setNumberWheels(int numberWheels) {
        this.numberWheels = numberWheels;
    }

    public TypeFuel getFuelType() {
        return fuelType;
    }

    public void setFuelType(TypeFuel fuelType) {
        this.fuelType = fuelType;
    }

    public TypeGearbox getGearboxType() {
        return gearboxType;
    }

    public void setGearboxType(TypeGearbox gearboxType) {
        this.gearboxType = gearboxType;
    }

    public double getEngineCapacity() {
        return engineCapacity;
    }

    public void setEngineCapacity(double engineCapacity) {
        this.engineCapacity = engineCapacity;
    }

    //methods
    public void movement() {
    }

    public void maintenance() {
    }

    public boolean gearShifting() {
        return true;
    }

    public boolean switchHeadlights() {
        return true;
    }

    public boolean switchWipers() {
        return true;
    }

}
//метод якорь
    //public void sweeping(){}

    //public void setMake(String make) {
        //this.make = make;
    //}

    //public String getMake() {
        //return make;
    //}

