package Services;

import Models.Client;

import java.util.ArrayList;
import java.util.List;

public class ClientRepository implements IClientRepo {
    private static ClientRepository clientRepository;
    private List<Client> clients;

    private ClientRepository() {
        //имитация работы базы клиентов
        clients = new ArrayList<>();
        clients.add(new Client(1, "Ivan", "1111".hashCode(), 2));
        clients.add(new Client(2, "Vasiliy", "2222".hashCode(), 3));
        clients.add(new Client(3, "Fedor", "3333".hashCode(), 4));
        clients.add(new Client(4, "Grigoriy", "4444".hashCode(), 5));
    }

    public static ClientRepository getClientRepository() {
        if (clientRepository == null) {
            clientRepository = new ClientRepository();
        }
        return clientRepository;
    }

    @Override
    public int create(Client client) throws RuntimeException {
        for (var currentClient : clients) {
            if (currentClient.getId() == client.getId()) {
                throw new RuntimeException("A client already exists");
            }
        }
        clients.add(client);
        return client.getId();
    }

    @Override
    public Client read(int id) throws RuntimeException {
        for (var client : clients) {
            if (client.getId() == id) {
                return client;
            }
        }
        throw new RuntimeException("A client with this ID not found");
    }

    @Override
    public Client read(String userName) throws RuntimeException {
        for (var client : clients) {
            if (client.getUserName() == userName) {
                return client;
            }
        }
        throw new RuntimeException("A client with this ID not found");
    }

    @Override
    public List<Client> readAll() throws RuntimeException {
        if (clients.isEmpty()) {
            throw new RuntimeException("List of clients is empty");
        }
        return clients;
    }

    @Override
    public boolean update(Client client) {
        Client tempClient = null;
        for (var currentClient : clients) {
            if (currentClient.getId() == client.getId()) {
                clients.remove(currentClient);
                clients.add(client);
                return true;
            }
        }
        return false;
    }

    @Override
    public boolean delete(Client client) {
        for (var currentClient : clients) {
            if (currentClient.equals(client)) {
                clients.remove(currentClient);
                return true;
            }
        }
        return false;
    }
}
