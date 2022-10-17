package Rewards.Gold;

import Abstractions.IGameItem;
import Abstractions.ItemGenerator;

/**
 * Фабрика класса
 */
public class GoldGenerator extends ItemGenerator {
    @Override
    public IGameItem createItem() {
        return new GoldReward();
    }
}
