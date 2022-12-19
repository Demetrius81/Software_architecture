package ApplicationLayer;

import LogicLayer.ILogic;

/**
 * Класс с основной логикой работы клиентского приложения
 */
public class ClientApp extends BaseApp {
    private ILogic _logic;

    /**
     * Конструктор класса
     *
     * @param logic объект логики приложения
     */
    public ClientApp(ILogic logic) {
        _logic = logic;
    }

    /**
     * Основной цикл программы
     */
    public void mainMenu() {
        boolean run = true;
        int choice = -1;
        while (run) {
            printLine("Вас приветствует фирменный магазин завода переработки вторичного сырья.\n");
            printLine("Чтобы ознакомиться с ассортиментом товаров магазина\tвведите 1\nЧтобы выйти\tвведите 0\n");
            printLine("Ожидаю ввода > ");
            try {
                choice = inputInt(0, 1);
            } catch (RuntimeException ex) {
                printLine(ex.getMessage() + "\n");
                continue;
            }
            run = selectMainMenu(choice);
        }
    }

    /**
     * Метод меню выбора
     *
     * @param choice выбор пользователя
     * @return разрешение на продолжение работы
     */
    private boolean selectMainMenu(int choice) {
        switch (choice) {
            case 1:
                catalogueMenu();
                break;
            default:
                return false;
        }
        return true;
    }

    /**
     * Меню каталога
     */
    private void catalogueMenu() {
        boolean run = true;
        while (run) {
            var choice = -1;
            printLine("Вас приветствует фирменный магазин завода переработки вторичного сырья.\n");
            printLine("Каталог товаров\n");
            var count = printAllProducts(_logic);
            printLine("Чтобы купить товар\tвведите номер позиции товара\nЧтобы выйти\t\t\t\t\t\t\t\t\t\t\tвведите 0\n");
            printLine("Ожидаю ввода > ");
            try {
                choice = inputInt(0, count);
                run = selectBuyMenu(choice);
            } catch (RuntimeException ex) {
                printLine(ex.getMessage() + "\n");
            }
        }
    }

    /**
     * Меню выбора товара
     *
     * @param choice выбор пользователя
     * @return разрешение на продолжение работы
     * @throws RuntimeException
     */
    private boolean selectBuyMenu(int choice) throws RuntimeException {
        switch (choice) {
            case 0:
                return false;
            default:
                buyMenu(choice);
                return true;
        }
    }

    /**
     * меню покупки товара
     *
     * @param id идентификатор товара
     */
    private void buyMenu(int id) {
        printLine("Вас приветствует фирменный магазин завода переработки вторичного сырья.\n");
        var product = _logic.showSelectedProduct(id);
        printLine("Товар " + product.getName() + " по цене " + product.getPrice() + " р. осталось на складе "
                + product.getCount() + " штук.\nВведите количество товара > ");
        int count = -1;
        try {
            count = inputInt(1, product.getCount());
        } catch (RuntimeException ex) {
            printLine(ex.getMessage() + "\n");
            return;
        }
        printLine("Вы действительно хотите приобрести товар " + product.getName() + " в количестве " + count
                + " штук, общей стоимостью " + product.getPrice() * count + " рублей?\nДля подтверждения введите Y > ");
        if (inputString().equals("y")) {
            try {
                _logic.buyProduct(id, count);
            } catch (RuntimeException ex) {
                printLine(ex.getMessage() + "\n");
            }
        } else {
            return;
        }
        printLine("Поздравляю! Вы приобрели " + count + " штук " + product.getName() + ", общей стоимостью "
                + product.getPrice() * count + "\n");
        inputEnter();
    }

}
