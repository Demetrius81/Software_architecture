package Rewards.Gam;

import Abstractions.IGameItem;

/**
 * Модель сундука
 */
public class GemReward implements IGameItem {
    @Override
    public String open() {
        return "Gem";
    }
}
