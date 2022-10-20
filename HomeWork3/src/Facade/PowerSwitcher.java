package Facade;

/**
 * Подсистема включения/выключения подачи электроэнергии
 */
public class PowerSwitcher {
    /**
     * Метод выключения электропитания
     */
    public void turnOffThePower() {
        System.out.println("Power off.");
    }

    /**
     * Метод включения электропитания
     */
    public void turnOnThePower() {
        System.out.println("Power on.");
    }
}
