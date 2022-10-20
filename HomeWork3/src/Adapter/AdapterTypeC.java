package Adapter;

public class AdapterTypeC implements IDefaultAdapter{
    private IUSBTypeC device;

    public AdapterTypeC(IUSBTypeC device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithUSBTypeC();
    }
}
