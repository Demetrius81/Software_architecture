package Rewards.Coopper;

import Abstractions.IGameItem;

/**
 * Модель сундука
 */
public class CooperReward implements IGameItem {
    @Override
    public String open() {
        return "Cooper";
    }
}
