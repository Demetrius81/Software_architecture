package Adapter;

public class AdapterMiniUsb implements IDefaultAdapter {
    private IMiniUSB device;

    public AdapterMiniUsb(IMiniUSB device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithMiniUSB();
    }
}
