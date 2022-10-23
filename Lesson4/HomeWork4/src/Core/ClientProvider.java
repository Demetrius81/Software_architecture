package Core;

import Interfaces.IClientRepo;
import Models.Client;
import Services.ClientRepository;

import java.util.List;

public class ClientProvider {
    private IClientRepo clientRepository;

    public ClientProvider() {
        this.clientRepository = ClientRepository.getClientRepository();
    }

    public int createClient(int id, String userName, int passwordHash, long cardNumber) throws RuntimeException {
        Client client = new Client(id, userName, passwordHash, cardNumber);
        clientRepository.create(client);
        return client.getId();
    }

    public Client getClientByName(String userName) throws RuntimeException {
        var client = clientRepository.read(userName);
        return client;
    }

    public List<Client> getAllClients() throws RuntimeException {
        var clients = clientRepository.readAll();
        return clients;
    }
}
