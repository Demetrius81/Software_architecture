package Rewards.Gam;

import Abstractions.IGameItem;
import Abstractions.ItemGenerator;

/**
 * Фабрика класса
 */
public class GemGenerator extends ItemGenerator {
    @Override
    public IGameItem createItem() {
        return new GemReward();
    }
}
