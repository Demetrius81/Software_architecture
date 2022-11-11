import java.util.ArrayList;
import java.util.List;

public class DataBase {
    private List<Product> _products = new ArrayList<>();
    private static DataBase _instance;

    private DataBase() {
        _products.add(new Product(1, "Лопата штыковая", 50, 100, "Обычная ржавая лопата"));
        _products.add(new Product(2, "Лопата совковая", 24, 125, "Ржавая лопата в виде совка"));
        _products.add(new Product(3, "Кирка", 34, 140, "Ржавая кирка для дробления твердых грунтов"));
        _products.add(new Product(4, "Лом", 12, 80, "Ржавый лом для дробления камней и льда"));
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
