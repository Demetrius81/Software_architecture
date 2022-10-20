package Adapter;

public class AdapterMicroUSB implements IDefaultAdapter{
    private IMicroUsb device;

    public AdapterMicroUSB(IMicroUsb device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithMicroUSB();
    }
}
