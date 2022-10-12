package ModelElements;

import ModelElements.Poligon;

/**
 * Класс - полигональная модель.
 */
public class PoligonalModel {
    public Poligon Poligons;
    public Texture Textures;

    /**
     * Конструктор класса.
     *
     * @param poligons
     */
    public PoligonalModel(Poligon poligons) {
        Poligons = poligons; // агрегация
        Textures = new Texture(); // композиция
    }
}
