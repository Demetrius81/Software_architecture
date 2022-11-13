package LogicLayer;

import DataLayer.Product;

import java.util.List;

/**
 * Интерфейс бизнес логики приложения
 */
public interface ILogic {
    /**
     * Метод логики покупки товара
     *
     * @param id    идентификатор товара
     * @param count количество товаров
     * @throws RuntimeException
     */
    void buyProduct(int id, int count) throws RuntimeException;

    /**
     * Метод возвращает список продуктов
     *
     * @return
     */
    List<Product> showAllProducts();

    /**
     * Метод возвращает выбранный продукт
     *
     * @param id идентификатор продукта
     * @return
     * @throws RuntimeException
     */
    Product showSelectedProduct(int id) throws RuntimeException;
}
