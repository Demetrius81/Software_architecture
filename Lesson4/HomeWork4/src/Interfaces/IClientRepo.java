package Interfaces;

import Models.Client;

import java.util.List;

/**
 * Интерфейс взаимодействия с базой клиентов
 */
public interface IClientRepo {
    int create(Client client);
    Client read(int id);
    Client read(String userName);
    List<Client> readAll();
    boolean update(Client client);
    boolean delete(Client client);
}
