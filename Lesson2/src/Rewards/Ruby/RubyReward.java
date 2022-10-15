package Rewards.Ruby;

import Abstractions.IGameItem;

/**
 * Модель сундука
 */
public class RubyReward implements IGameItem {
    @Override
    public String open() {
        return "Ruby";
    }
}
