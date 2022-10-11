package ModelElements;

import ModelElements.Camera;
import ModelElements.Flash;
import Stubs.Type1;
import Stubs.Type2;

/**
 * Класс - модель сцены.
 */
public class Scene {
    public int Id;
    public PoligonalModel Models;
    public Flash Flashes;
    public Camera Cameras; // добавил это поле так как без него нет возможности реализовать отношения агрегации классов

    /**
     * Конструктор класса.
     *
     * @param models
     * @param flashes
     * @param cameras
     */
    public Scene(PoligonalModel models, Flash flashes, Camera cameras) {
        Models = models;
        Flashes = flashes;
        Cameras = cameras;
    }

    /**
     * Метод изменения сцены 1.
     *
     * @param t
     * @return
     */
    public Type1 method1(Type1 t) {
        return t;
    }

    /**
     * Метод изменения сцены 2.
     *
     * @param t1
     * @param t2
     * @return
     */
    public Type1 method1(Type1 t1, Type2 t2) {
        return t1;
    }
}
