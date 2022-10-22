package Core;

import Services.ClientRepository;

public class ClientProvider {
    private ClientRepository clientRepository;

    public ClientProvider() {
        this.clientRepository = ClientRepository.getClientRepository();
    }




}
