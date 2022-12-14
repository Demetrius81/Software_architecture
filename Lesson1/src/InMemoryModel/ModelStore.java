package InMemoryModel;

import ModelElements.*;

/**
 * Класс - хранилище моделей.
 */
public class ModelStore implements IModelChanger {
    public PoligonalModel Models;
    public Scene Scenes;
    public Flash Flashes;
    public Camera Cameras;
    private IModelChangeObserver changeObservers;

    /**
     * Конструктор класса.
     *
     * @param changeObservers
     */
    public ModelStore(IModelChangeObserver changeObservers) {
        this.changeObservers = changeObservers;
        Models = new PoligonalModel(new Poligon()); // композиция
        Flashes = new Flash(); // композиция
        Cameras = new Camera(); // композиция
        Scenes = new Scene(Models, Flashes, Cameras); // композиция
    }

    /**
     * Метод возвращает сцену по порядковому номеру.
     *
     * @param n
     * @return
     */
    public Scene getScene(int n) {
        return Scenes;
    }

    @Override
    public void notifyChange(IModelChanger sender) {

    }
}
