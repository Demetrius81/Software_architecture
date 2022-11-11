import java.util.InputMismatchException;
import java.util.Scanner;

public class ClientApp {

    private Logic logic = new Logic(new ProductRepo(DataBase.GetInstance()));

    public void mainMenu(){
        System.out.println("=============================================================================================================");
        System.out.println("Вас приветствует фирменный магазин завода переработки вторичного сырья.");
        System.out.println("=============================================================================================================");
        System.out.println("Чтобы ознакомиться с ассортиментом товаров магазина\tвведите 1");
        System.out.println("Чтобы выйти\t\t\t\t\t\t\t\t\t\t\tвведите 0");
        System.out.println("=============================================================================================================");

        //printAllProducts();


        System.out.print("Ожидаю ввода > ");
        int n = inputInt(0, 1);

    }

    private void selectMainMenu(int choice){
        switch (choice){
            case 1:
                catalogueMenu();
                break;
            case 0:
                return;
            default:
                //TODO implement error
        }
    }

    private void catalogueMenu(){
        System.out.println("=============================================================================================================");
        System.out.println("Вас приветствует фирменный магазин завода переработки вторичного сырья.");
        System.out.println("=============================================================================================================");
        System.out.println("Каталог товаров");
        System.out.println("=============================================================================================================");
        //TODO implement printAllProducts
        System.out.println("=============================================================================================================");
        System.out.println("Чтобы купить товар\tвведите номер позиции товара");
        System.out.println("Чтобы выйти\t\t\t\t\t\t\t\t\t\t\tвведите 0");
        System.out.println("=============================================================================================================");
        System.out.print("Ожидаю ввода > ");
    }

    private  void printAllProducts(){
        System.out.println("+-----------+-------------------+-------+-----------+-------------------------------------------------------+");
        System.out.println("| N позиции\t| Наименование\t\t| Цена\t| Количество| Описание\t\t\t\t\t\t\t\t\t\t\t\t|");
        System.out.println("+-----------+-------------------+-------+-----------+-------------------------------------------------------+");
        printAll();
        System.out.println("+-----------+-------------------+-------+-----------+-------------------------------------------------------+");
    }

    private void printAll(){
        var products = logic.showAllProducts();
        for (var product : products){
            System.out.println("| " + product.getId() + "\t\t\t| " + product.getName() + "\t| " + product.getPrice() +
                    "\t| " + product.getCount() + "\t\t| " + product.getDescription() + "\t\t\t| ");
        }
    }






    private int inputInt(int minVariant, int maxVariant) throws RuntimeException {
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



}
