package Interfaces;

/**
 * Интерфейс взаимодействия с базой банковских операций
 */
public interface ICashRepo {
    boolean transaction(int payment, long cardFrom, long cardTo);
}
