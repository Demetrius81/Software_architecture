package Adapter;

/**
 * Класс - модель мобильного телефона
 */
public class AppleIphone9 implements IAppleLightning {
    @Override
    public void connectWithAppleLightning() {
        System.out.println("AppleIphone9 connected");
    }
}
