package Facade;

/**
 * Подсистема включения/выключения охранной системы
 */
public class SecuritySystemSwitcher {
    /**
     * Метод выключения охранной системы
     */
    public void turnOffTheSecuritySystem() {
        System.out.println("SecuritySystem off.");
    }

    /**
     * Метод включения охранной системы
     */
    public void turnOnTheSecuritySystem() {
        System.out.println("SecuritySystem on.");
    }
}
