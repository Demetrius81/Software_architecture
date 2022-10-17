package Rewards.Mud;

import Abstractions.IGameItem;

/**
 * Модель сундука
 */
public class MudReward implements IGameItem {
    @Override
    public String open() {
        return "Mud";
    }
}
