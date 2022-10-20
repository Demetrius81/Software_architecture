package Facade;

/**
 * Подсистема включения/выключения подачи газа
 */
public class GasSwitcher {
    /**
     * Метод выключения подачи газа
     */
    public void turnOffTheGas() {
        System.out.println("Gas off.");
    }

    /**
     * Метод включения подачи газа
     */
    public void turnOnTheGas() {
        System.out.println("Gas on.");
    }
}
