package Rewards.Sapphire;

import Abstractions.IGameItem;
import Abstractions.ItemGenerator;

/**
 * Фабрика класса
 */
public class SapphireGenerator extends ItemGenerator {
    @Override
    public IGameItem createItem() {
        return new SapphireReward();
    }
}
