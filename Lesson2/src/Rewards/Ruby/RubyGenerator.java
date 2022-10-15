package Rewards.Ruby;

import Abstractions.IGameItem;
import Abstractions.ItemGenerator;

/**
 * Фабрика класса
 */
public class RubyGenerator extends ItemGenerator {
    @Override
    public IGameItem createItem() {
        return new RubyReward();
    }
}
