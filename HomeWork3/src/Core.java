import Adapter.ServiceComputer;
import Decorator.*;
import Facade.SmartHouse;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Core {

    public void runProgram() {
        while (true) {
            //Вывод в консоль вариантов запуска
            System.out.println("\nThese are homework#3 tests");
            System.out.println("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            System.out.println("To run an facade pattern test\t\tenter 1");
            System.out.println("To run an adapter pattern test\t\tenter 2");
            System.out.println("To run an decorator pattern test\tenter 3");
            System.out.println("To exit\t\t\t\t\t\t\t\tenter 0");
            System.out.println("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            System.out.print("Enter you choice > ");
            int choice = 0;

            //Запрос ввести вариант запуска с валидацией некорректного ввода
            try {
                choice = getChoice();
            } catch (RuntimeException ex) {
                System.err.println(ex.getMessage());
                continue;
            } catch (Exception ex) {
                System.err.println(ex.getMessage());
                continue;
            }

            //Валидация диапазона вводимых чисел
            if (choice < 0 || choice > 3) {
                System.err.println("You entered an invalid value.");
                continue;
            }
            System.out.println("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            //Селектор выбора способов запуска программы
            switch (choice) {
                case 1:
                    runSmartHouse();
                    break;
                case 2:
                    runUpdateDevices();
                    break;
                case 3:
                    runBuyCar();
                    break;
                default:
                    return;
            }
        }
    }

    private int getChoice() throws Exception {
        int num = 0;
        Scanner in = new Scanner(System.in);
        try {
            num = in.nextInt();
        } catch (InputMismatchException ex) {
            throw new RuntimeException("This is not number.");
        } catch (Exception ex) {
            throw new Exception("Something wrong.");
        }
        return num;
    }

    private void runBuyCar() {
        //Создаем экземпляры новых автомобилей
        Car car1 = new Audi();
        Car car2 = new Volkswagen();
        Car car3 = new Lada();

        //Вызываем конкретные декораторы для наших автомобилей
        car1 = new CarWithAudio(car1);
        car1 = new CarSportyDesign(car1);

        car2 = new CarWithReinforcedSuspension(car2);

        car3 = new CarSportyDesign(car3);
        car3 = new CarWithReinforcedSuspension(car3);

        //Выводим в консоль результат работы
        System.out.println("Test decorator pattern.");
        System.out.println("=========================================================================================");
        System.out.println("You buy an " + car1.getName() + " car for " + car1.getCost());
        System.out.println("You buy an " + car2.getName() + " car for " + car2.getCost());
        System.out.println("You buy an " + car3.getName() + " car for " + car3.getCost());
        System.out.println("=========================================================================================");
    }

    private void runUpdateDevices() {
        System.out.println("Test adapter pattern.");
        System.out.println("=========================================================================================");
        //Создаем компьютер и запускаем обновление устройств
        ServiceComputer computer = new ServiceComputer();
        computer.update();
        System.out.println("=========================================================================================");
    }

    private void runSmartHouse() {
        //Создаем умный дом
        SmartHouse smartHouse = new SmartHouse();
        System.out.println("Test facade pattern.");
        System.out.println("We have come home.");
        System.out.println("=========================================================================================");
        //Открываем дом
        smartHouse.openHouse();
        System.out.println("=========================================================================================");
        System.out.println("We left home.");
        System.out.println("=========================================================================================");
        //Уходим и закрываем дом
        smartHouse.closeHouse();
        System.out.println("=========================================================================================");
    }
}
