import ApplicationLayer.ClientApp;
import DataLayer.DataBase;
import DataLayer.ProductRepo;
import LogicLayer.Logic;

public class Main {
    public static void main(String[] args) {
        // имитация регистрации сервисов, запуск имитации работы БД
        var dbContext = DataBase.getInstance();
        var repo = new ProductRepo(dbContext);
        var logic = new Logic(repo);
        // запуск приложения
        ClientApp app = new ClientApp(logic);
        app.mainMenu();
    }
}