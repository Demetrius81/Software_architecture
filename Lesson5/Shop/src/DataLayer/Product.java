package DataLayer;

/**
 * Класс - модель продукта
 */
public class Product {
    private int _id;
    private String _name;
    private String _description;
    private int _price;
    private int _count;

    /**
     * Конструктор класса модели товара
     *
     * @param _id          идентификатор товара
     * @param _name        название товара
     * @param _count       количество данного товара на складе
     * @param _price       цена товара
     * @param _description описание товара
     */
    public Product(int _id, String _name, int _count, int _price, String _description) {
        this._id = _id;
        this._name = _name;
        this._description = _description;
        this._price = _price;
        this._count = _count;
    }

    public int getCount() {
        return _count;
    }

    public void setCount(int _count) {
        this._count = _count;
    }

    public int getId() {
        return _id;
    }

    public void setId(int _id) {
        this._id = _id;
    }

    public String getName() {
        return _name;
    }

    public void setName(String _name) {
        this._name = _name;
    }

    public String getDescription() {
        return _description;
    }

    public void setDescription(String _description) {
        this._description = _description;
    }

    public int getPrice() {
        return _price;
    }

    public void setPrice(int _price) {
        this._price = _price;
    }

}
