package ClientApplication;

import Core.UserProvider;
import Interfaces.IUser;

public class Authentication {

    public static IUser authentication(UserProvider userProvider, String login, int passHash){
        var client = userProvider.getClientByName(login);
        if(client.getHashPassword() == passHash){
            return client;
        }else {
            throw new RuntimeException("Authentication fail");
        }
    }
}
