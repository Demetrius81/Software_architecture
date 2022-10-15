package Rewards.Mud;

import Abstractions.IGameItem;
import Abstractions.ItemGenerator;

/**
 * Фабрика класса
 */
public class MudGenerator extends ItemGenerator {
    @Override
    public IGameItem createItem() {
        return new MudReward();
    }
}
