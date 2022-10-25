package Core;

import Interfaces.IUser;
import Interfaces.IUserRepo;
import Models.User;
import Services.UserRepository;

import java.util.List;

public class UserProvider {
    private IUserRepo clientRepository;

    public UserProvider() {
        this.clientRepository = UserRepository.getClientRepository();
    }

    public int createClient(String userName, int passwordHash, long cardNumber) throws RuntimeException {
        int id = clientRepository.create(userName, passwordHash, cardNumber);
        return id;
    }

    public IUser getClientByName(String userName) throws RuntimeException {
        var client = clientRepository.read(userName);
        return client;
    }

    public List<IUser> getAllClients() throws RuntimeException {
        var clients = clientRepository.readAll();
        return clients;
    }
}
