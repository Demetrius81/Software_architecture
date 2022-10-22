package Services;

import Models.Client;

import java.util.List;

public interface IClientRepo {
    int create(Client client);
    Client read(int id);
    Client read(String userName);
    List<Client> readAll();
    boolean update(Client client);
    boolean delete(Client client);
}
