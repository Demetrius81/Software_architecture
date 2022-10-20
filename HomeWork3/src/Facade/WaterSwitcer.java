package Facade;

/**
 * Подсистема включения/выключения водопровода
 */
public class WaterSwitcer {
    /**
     * Метод выключения воды
     */
    public void turnOffTheWater(){
        System.out.println("Water off.");
    }

    /**
     * Метод включения воды
     */
    public void turnOnTheWater(){
        System.out.println("Water on.");
    }
}
