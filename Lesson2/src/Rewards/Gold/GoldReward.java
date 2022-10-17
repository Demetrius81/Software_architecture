package Rewards.Gold;

import Abstractions.IGameItem;

/**
 * Модель сундука
 */
public class GoldReward implements IGameItem {
    @Override
    public String open() {
        return "Gold";
    }
}
