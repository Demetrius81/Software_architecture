import Adapter.ServiceComputer;
import Facade.SmartHouse;

public class Main {
    public static void main(String[] args) {
        //runSmartHouse();
        runUpdateDevices();


    }

    private  static void runUpdateDevices(){
        ServiceComputer computer = new ServiceComputer();
        computer.update();
    }

    private static void runSmartHouse(){
        SmartHouse smartHouse = new SmartHouse();
        System.out.println("Test facade pattern.");
        System.out.println("We have come home.");
        System.out.println("==========================================================");
        smartHouse.openHouse();
        System.out.println("==========================================================");
        System.out.println("We left home.");
        System.out.println("==========================================================");
        smartHouse.closeHouse();
        System.out.println("==========================================================");
    }
}