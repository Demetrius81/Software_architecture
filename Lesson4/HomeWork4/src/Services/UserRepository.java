package Services;

import Interfaces.IUser;
import Interfaces.IUserRepo;
import Models.User;

import java.util.ArrayList;
import java.util.List;

public class UserRepository implements IUserRepo {
    private static UserRepository clientRepository;
    private List<IUser> clients;

    private UserRepository() {
        //имитация работы базы клиентов
        clients = new ArrayList<>();
        clients.add(new User(1, "Ivan", "1111".hashCode(), 2));
        clients.add(new User(2, "Vasiliy", "2222".hashCode(), 3));
        clients.add(new User(3, "Fedor", "3333".hashCode(), 4));
        clients.add(new User(4, "Grigoriy", "4444".hashCode(), 5));
    }

    public static UserRepository getClientRepository() {
        if (clientRepository == null) {
            clientRepository = new UserRepository();
        }
        return clientRepository;
    }

    @Override
    public int create(IUser client) throws RuntimeException {
        for (var currentClient : clients) {
            if (currentClient.getId() == client.getId()) {
                throw new RuntimeException("A client already exists");
            }
        }
        clients.add((User)client);
        return client.getId();
    }

    @Override
    public IUser read(int id) throws RuntimeException {
        for (var client : clients) {
            if (client.getId() == id) {
                return client;
            }
        }
        throw new RuntimeException("A client with this ID not found");
    }

    @Override
    public IUser read(String userName) throws RuntimeException {
        for (var client : clients) {
            var clientName = client.getUserName();
            if (clientName.equals(userName)) {
                return client;
            }
        }
        throw new RuntimeException("A client with this ID not found");
    }

    @Override
    public List<IUser> readAll() throws RuntimeException {
        if (clients.isEmpty()) {
            throw new RuntimeException("List of clients is empty");
        }
        return clients;
    }

    @Override
    public boolean update(IUser client) {
        User tempClient = null;
        for (IUser currentClient : clients) {
            if (currentClient.getId() == client.getId()) {
                clients.remove(currentClient);
                clients.add((User)client);
                return true;
            }
        }
        return false;
    }

    @Override
    public boolean delete(IUser client) {
        for (IUser currentClient : clients) {
            if (currentClient.equals((User)client)) {
                clients.remove(currentClient);
                return true;
            }
        }
        return false;
    }
}
