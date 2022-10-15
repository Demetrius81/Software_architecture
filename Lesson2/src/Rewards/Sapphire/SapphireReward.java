package Rewards.Sapphire;

import Abstractions.IGameItem;

/**
 * Модель сундука
 */
public class SapphireReward implements IGameItem {
    @Override
    public String open() {
        return "Sapphire";
    }
}
