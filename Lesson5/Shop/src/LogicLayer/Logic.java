package LogicLayer;

import DataLayer.IProductRepo;
import DataLayer.Product;

import java.util.List;

/**
 * Класс бизнес логики приложения
 */
public class Logic implements ILogic {
    private IProductRepo _repository;

    /**
     * Конструктор класса
     *
     * @param _repository ссылка на репозиторий
     */
    public Logic(IProductRepo _repository) {
        this._repository = _repository;
    }

    /**
     * Метод логики покупки товара
     *
     * @param id    идентификатор товара
     * @param count количество товаров
     * @throws RuntimeException
     */
    @Override
    public void buyProduct(int id, int count) throws RuntimeException {
        Product product = tryGetProduct(id);
        if (product.getCount() < count) {
            throw new RuntimeException("Такого количества продукта нет");
        }
        //Здесь вызывается логика оплаты товара
        _repository.setNewCountProduct(id, count);
    }

    /**
     * Метод возвращает список продуктов
     *
     * @return
     */
    @Override
    public List<Product> showAllProducts() {
        return _repository.getAllProducts();
    }

    /**
     * Метод возвращает выбранный продукт
     *
     * @param id идентификатор продукта
     * @return
     * @throws RuntimeException
     */
    @Override
    public Product showSelectedProduct(int id) throws RuntimeException {
        return tryGetProduct(id);
    }

    /**
     * Метод возвращает товар по идентификатору
     *
     * @param id идентификатор продукта
     * @return
     * @throws RuntimeException
     */
    private Product tryGetProduct(int id) throws RuntimeException {
        Product product = _repository.getProductById(id);
        if (product == null) {
            throw new RuntimeException("Такого продукта нет");
        }
        return product;
    }
}
