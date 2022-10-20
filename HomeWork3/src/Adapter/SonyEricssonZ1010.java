package Adapter;

public class SonyEricssonZ1010 implements IMiniUSB {
    @Override
    public void connectWithMiniUSB(){
        System.out.println("SonyEricssonZ1010 connected");
    }
}
