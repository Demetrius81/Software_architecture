package Adapter;

public class AdapterAppleLigthing implements IDefaultAdapter{
    private IAppleLightning device;

    public AdapterAppleLigthing(IAppleLightning device) {
        this.device = device;
    }

    @Override
    public void connectUSBA() {
        device.connectWithAppleLightning();
    }
}
