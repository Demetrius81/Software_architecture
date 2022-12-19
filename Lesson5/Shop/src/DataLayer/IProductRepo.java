package DataLayer;

import java.util.List;

/**
 * Интерфейс репозитория базы данных
 */
public interface IProductRepo {
    /**
     * Метод получает из БД список товаров
     *
     * @return список товаров
     */
    List<Product> getAllProducts();

    /**
     * Метод получает из БД товар по идентификатору
     *
     * @param id идентификатор товара
     * @return товар
     */
    Product getProductById(int id);

    /**
     * Метод изменяет количество товара на складе
     *
     * @param id    идентификатор товара
     * @param count новое количество товара
     */
    void setNewCountProduct(int id, int count);
}
