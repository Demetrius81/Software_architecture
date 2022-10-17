package Rewards.Silver;

import Abstractions.IGameItem;
import Abstractions.ItemGenerator;

/**
 * Фабрика класса
 */
public class SilverGenerator extends ItemGenerator {
    @Override
    public IGameItem createItem() {
        return new SilverReward();
    }
}
