package Rewards.Coopper;

import Abstractions.IGameItem;
import Abstractions.ItemGenerator;

/**
 * Фабрика класса
 */
public class CooperGenerator extends ItemGenerator {
    @Override
    public IGameItem createItem() {
        return new CooperReward();
    }
}
