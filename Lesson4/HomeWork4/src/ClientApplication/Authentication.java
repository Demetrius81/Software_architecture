package ClientApplication;

import Core.ClientProvider;
import Models.Client;

public class Authentication {

    public static Client authentication(ClientProvider clientProvider, String login, int passHash){
        var client = clientProvider.getClientByName(login);
        if(client.getHashPassword() == passHash){
            return client;
        }else {
            throw new RuntimeException("Authentication fail");
        }
    }
}
