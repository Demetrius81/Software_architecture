import java.util.List;

public class Logic {
    private ProductRepo _repository;

    public Logic(ProductRepo _repository) {
        this._repository = _repository;
    }

    public void buyProduct(int id, int count) throws RuntimeException {
        Product product = tryGetProduct(id);
        if (product.getCount() < count) {
            throw new RuntimeException("Такого количества продукта нет");
        }
        //Здесь вызывается метод оплаты товара
        _repository.setNewCountProduct(id, count);
    }

    public List<Product> showAllProducts() {
        return _repository.getAllProducts();
    }

    public Product showSelectedProduct(int id) throws RuntimeException {
        return tryGetProduct(id);
    }

    private Product tryGetProduct(int id)throws RuntimeException{
        Product product = _repository.getProductById(id);
        if (product == null) {
            throw new RuntimeException("Такого продукта нет");
        }
        return product;
    }
}
