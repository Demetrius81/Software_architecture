package Facade;

public class SmartHouse {
    private GasSwitcher gasSwitcher = new GasSwitcher();
    private PowerSwitcher powerSwitcher = new PowerSwitcher();
    private WaterSwitcer waterSwitcer = new WaterSwitcer();
    private SecuritySystemSwitcher securitySystemSwitcher = new SecuritySystemSwitcher();

    public void closeHouse(){
        gasSwitcher.turnOffTheGas();
        powerSwitcher.turnOffThePower();
        waterSwitcer.turnOffTheWater();
        securitySystemSwitcher.turnOnTheSecuritySystem();
    }

    public void openHouse(){
        gasSwitcher.turnOnTheGas();
        powerSwitcher.turnOnThePower();
        waterSwitcer.turnOnTheWater();
        securitySystemSwitcher.turnOffTheSecuritySystem();
    }
}
