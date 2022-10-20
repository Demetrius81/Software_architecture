package Facade;

/**
 * Класс умный дом - Фасад
 */
public class SmartHouse {
    private GasSwitcher gasSwitcher;
    private PowerSwitcher powerSwitcher;
    private WaterSwitcer waterSwitcer;
    private SecuritySystemSwitcher securitySystemSwitcher;

    /**
     * Конструктор класса без параметров
     */
    public SmartHouse() {
        //Создаем экземпляры объектов подсистем умного дома
        gasSwitcher = new GasSwitcher();
        powerSwitcher = new PowerSwitcher();
        waterSwitcer = new WaterSwitcer();
        securitySystemSwitcher = new SecuritySystemSwitcher();
    }

    /**
     * Метод закрыть дом
     */
    public void closeHouse() {
        gasSwitcher.turnOffTheGas();
        powerSwitcher.turnOffThePower();
        waterSwitcer.turnOffTheWater();
        securitySystemSwitcher.turnOnTheSecuritySystem();
    }

    /**
     * Метод открыть дом
     */
    public void openHouse() {
        gasSwitcher.turnOnTheGas();
        powerSwitcher.turnOnThePower();
        waterSwitcer.turnOnTheWater();
        securitySystemSwitcher.turnOffTheSecuritySystem();
    }
}
