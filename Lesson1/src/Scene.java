import Stubs.Type1;
import Stubs.Type2;

public class Scene {
    public int Id;
    public PoligonalModel Models;
    public Flash Flashes;
    public Camera Cameras; // добавил это поле так как без него нет возможности реализовать отношения агрегации классов

    public Scene(PoligonalModel models, Flash flashes, Camera cameras) {
        Models = models;
        Flashes = flashes;
        Cameras = cameras;
    }

    public Type1 method1(Type1 t){
        return t;
    }

    public Type1 method1(Type1 t1, Type2 t2){
        return t1;
    }
}
