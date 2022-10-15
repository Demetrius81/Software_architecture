package Rewards.Silver;

import Abstractions.IGameItem;

/**
 * Модель сундука
 */
public class SilverReward implements IGameItem {
    @Override
    public String open() {
        return "Silver";
    }
}
