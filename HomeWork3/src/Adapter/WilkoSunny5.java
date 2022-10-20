package Adapter;

/**
 * Класс - модель мобильного телефона
 */
public class WilkoSunny5 implements IMicroUsb {
    @Override
    public void connectWithMicroUSB() {
        System.out.println("WilkoSunny5 connected");
    }
}
