package Abstractions;

/**
 * Абстракция фабрики классов
 */
public abstract class ItemGenerator {
    /**
     * Метод взаимодействия с абстракцией продукта
     *
     * @return  содержимое разных сундуков
     */
    public String openReward() {
        IGameItem gameItem = createItem();
        return gameItem.open();
    }

    /**
     * Метод создания экземпляра продукта
     *
     * @return экземпляр продукта
     */
    public abstract IGameItem createItem();
}
