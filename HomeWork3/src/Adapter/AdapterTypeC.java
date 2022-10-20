package Adapter;

/**
 * Класс - конкретный адаптер
 */
public class AdapterTypeC implements IDefaultAdapter {
    private IUSBTypeC device;

    /**
     * Конструктор класса
     *
     * @param device устройство для соединения (объект класса для изменения его интерфейса)
     */
    public AdapterTypeC(IUSBTypeC device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithUSBTypeC();
    }
}
