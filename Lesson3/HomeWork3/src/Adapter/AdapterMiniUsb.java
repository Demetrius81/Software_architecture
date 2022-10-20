package Adapter;

/**
 * Класс - конкретный адаптер
 */
public class AdapterMiniUsb implements IDefaultAdapter {
    private IMiniUSB device;

    /**
     * Конструктор класса
     *
     * @param device устройство для соединения (объект класса для изменения его интерфейса)
     */
    public AdapterMiniUsb(IMiniUSB device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithMiniUSB();
    }
}
