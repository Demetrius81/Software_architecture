package ApplicationLayer;

import LogicLayer.ILogic;

import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * Абстрактный класс с реализацией методов для работы с консолью
 */
public abstract class BaseApp {
    /**
     * Метод выводит на экран каталог товаров
     *
     * @param logic объект расчета бизнес логики
     * @return количество позиций товаров
     */
    protected int printAllProducts(ILogic logic) {
        System.out.println("+-----------+-------------------+-------+-----------+-----------------------------------" +
                "--------------------+");
        System.out.println("| N позиции\t| Наименование\t\t| Цена\t| Количество| Описание\t\t\t\t\t\t\t\t\t\t\t\t|");
        System.out.println("+-----------+-------------------+-------+-----------+-----------------------------------" +
                "--------------------+");
        var count = printAll(logic);
        System.out.println("+-----------+-------------------+-------+-----------+-----------------------------------" +
                "--------------------+");
        return count;
    }

    /**
     * Метод выводит на экран список товаров
     *
     * @param logic объект расчета бизнес логики
     * @return количество позиций товаров
     */
    protected int printAll(ILogic logic) {
        var products = logic.showAllProducts();
        for (var product : products) {
            System.out.println("| " + product.getId() + "\t\t\t| " + product.getName() + "\t| " + product.getPrice() +
                    "\t| " + product.getCount() + "\t\t| " + product.getDescription() + "\t\t\t| ");
        }
        return products.size();
    }

    /**
     * Метод ввода строки и ее валидация на пустую строку
     *
     * @return строка
     * @throws RuntimeException
     */
    protected String inputString() throws RuntimeException {
        Scanner in = new Scanner(System.in);
        String str;
        try {
            str = in.next();
        } catch (Exception ex) {
            throw new RuntimeException("Something wrong.");
        }
        if (str.isEmpty()) {
            throw new RuntimeException("You must something enter");
        }
        return str;
    }

    /**
     * Метод ожидает ввода команды Enter
     */
    protected void inputEnter() {
        Scanner in = new Scanner(System.in);
        in.nextLine();
    }

    /**
     * Метод ввода и валидации целого числа в диапазоне
     *
     * @param minVariant минимальное число
     * @param maxVariant максимальное число
     * @return введенное целое число
     * @throws RuntimeException
     */
    protected int inputInt(int minVariant, int maxVariant) throws RuntimeException {
        int num = 0;
        Scanner in = new Scanner(System.in);
        try {
            num = in.nextInt();
        } catch (InputMismatchException ex) {
            throw new RuntimeException("This is not number.");
        } catch (Exception ex) {
            throw new RuntimeException("Something wrong.");
        }
        if (num < minVariant || num > maxVariant) {
            throw new RuntimeException("You entered an invalid value.");
        }
        return num;
    }

    /**
     * Метод выводит на экран элемент сообщение пользователю
     *
     * @param message сообщение
     */
    protected void printLine(String message) {
        System.out.println("=======================================================================================" +
                "======================");
        System.out.print(message);
    }
}
