package DataLayer;

import java.util.List;

/**
 * Класс репозитория БД
 */
public class ProductRepo implements IProductRepo {
    private DataBase _context;

    /**
     * Конструктор класса
     *
     * @param context ссылка на контекст для взаимодействия с базой данных
     */
    public ProductRepo(DataBase context) {
        this._context = context;
    }

    /**
     * Метод получает из БД список товаров
     *
     * @return список товаров
     */
    @Override
    public List<Product> getAllProducts() {
        return _context.getProducts();
    }

    /**
     * Метод получает из БД товар по идентификатору
     *
     * @param id идентификатор товара
     * @return товар
     */
    @Override
    public Product getProductById(int id) {
        return _context.getProducts().stream().filter(x -> x.getId() == id).findAny().get();
    }

    /**
     * Метод задает новое количество товара на складе
     *
     * @param id    идентификатор товара
     * @param count новое количество товара
     */
    @Override
    public void setNewCountProduct(int id, int count) {
        int newCount = _context.getProducts().stream().filter(x -> x.getId() == id).findAny().get().getCount() - count;
        _context.getProducts().stream().filter(x -> x.getId() == id).findAny().get().setCount(newCount);
    }
}
