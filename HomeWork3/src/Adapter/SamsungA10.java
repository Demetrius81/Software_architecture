package Adapter;

/**
 * Класс - модель мобильного телефона
 */
public class SamsungA10 implements IUSBTypeC {
    @Override
    public void connectWithUSBTypeC() {
        System.out.println("SamsungA10 connected");
    }
}
