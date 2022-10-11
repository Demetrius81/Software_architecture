public class PoligonalModel {
    public Poligon Poligons;
    public Texture Textures;

    public PoligonalModel(Poligon poligons) {
        Poligons = poligons; // агрегация
        Textures = new Texture(); // композиция
    }
}
