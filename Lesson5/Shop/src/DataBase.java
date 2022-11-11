import java.util.ArrayList;
import java.util.List;

public class DataBase {
    private List<Product> _products = new ArrayList<>();
    private static DataBase _instance;

    private DataBase() {
        _products.add(new Product(1, "Лопата штыковая", 50, 1400, "Обычная ржавая лопата\t\t\t\t\t\t"));
        _products.add(new Product(2, "Лопата совковая", 24, 1560, "Ржавая лопата в виде совка\t\t\t\t"));
        _products.add(new Product(3, "Кирка\t\t\t", 34, 440, "Ржавая кирка для дробления твердых грунтов"));
        _products.add(new Product(4, "Лом\t\t\t", 12, 200, "Ржавый лом для дробления камней и льда\t"));
    }

    public List<Product> getProducts() {
        return _products;
    }

    public void setProducts(List<Product> _products) {
        this._products = _products;
    }

    public static DataBase GetInstance(){
        if(_instance == null){
            _instance = new DataBase();
        }
        return  _instance;
    }
}
