package Adapter;

/**
 * Класс - конкретный адаптер
 */
public class AdapterAppleLigthing implements IDefaultAdapter {
    private IAppleLightning device;

    /**
     * Конструктор класса
     *
     * @param device устройство для соединения (объект класса для изменения его интерфейса)
     */
    public AdapterAppleLigthing(IAppleLightning device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithAppleLightning();
    }
}
