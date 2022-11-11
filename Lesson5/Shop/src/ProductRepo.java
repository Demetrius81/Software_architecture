import java.util.List;

public class ProductRepo {
    private DataBase _context;

    public ProductRepo(DataBase context) {
        this._context = context;
    }

    public List<Product> getAllProducts(){
        return _context.getProducts();
    }

    public Product getProductById(int id){
        return _context.getProducts().stream().filter(x->x.getId() == id).findAny().get();
    }

    public void setNewCountProduct(int id, int count){
        int newCount = _context.getProducts().stream().filter(x->x.getId() == id).findAny().get().getCount() - count;
        _context.getProducts().stream().filter(x->x.getId() == id).findAny().get().setCount(newCount);
    }
}
