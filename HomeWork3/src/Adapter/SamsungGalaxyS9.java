package Adapter;

public class SamsungGalaxyS9 implements IUSBTypeC {
    @Override
    public void connectWithUSBTypeC(){
        System.out.println("SamsungGalaxyS9 connected");
    }
}
