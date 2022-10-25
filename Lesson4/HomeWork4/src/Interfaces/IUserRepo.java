package Interfaces;

import java.util.List;

/**
 * Интерфейс взаимодействия с базой клиентов
 */
public interface IUserRepo {
    int create(String userName, int passwordHash,long cardNumber);
    IUser read(int id);
    IUser read(String userName);
    List<IUser> readAll();
    boolean update(IUser client);
    boolean delete(IUser client);
}
