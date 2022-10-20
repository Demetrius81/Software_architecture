package Adapter;

public class ServiceComputer {

    //Создаем устройства для подключения с разными интерфейсами
    private IAppleLightning device1 = new AppleIphone9();
    private IMiniUSB device2 = new SonyEricssonZ1010();
    private IMicroUsb device3 = new WilkoSunny5();
    private IUSBTypeC device4 = new SamsungGalaxyS9();
    private IUSBTypeC device5 = new SamsungA10();

    //Создаем адаптеры к устройствам
    private IDefaultAdapter adapter1 = new AdapterAppleLigthing(device1);
    private IDefaultAdapter adapter2 = new AdapterMiniUsb(device2);
    private IDefaultAdapter adapter3 = new AdapterMicroUSB(device3);
    private IDefaultAdapter adapter4 = new AdapterTypeC(device4);
    private IDefaultAdapter adapter5 = new AdapterTypeC(device5);

    public void update(){
        //Подключаем устройства используя адаптеры
        adapter1.connectUSBA();
        adapter2.connectUSBA();
        adapter3.connectUSBA();
        adapter4.connectUSBA();
        adapter5.connectUSBA();

        System.out.println("\nUpdate connected devices.");
    }
}
