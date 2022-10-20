package Adapter;

/**
 * Класс - конкретный адаптер
 */
public class AdapterMicroUSB implements IDefaultAdapter {
    private IMicroUsb device;

    /**
     * Конструктор класса
     *
     * @param device устройство для соединения (объект класса для изменения его интерфейса)
     */
    public AdapterMicroUSB(IMicroUsb device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithMicroUSB();
    }
}
