package ClientApplication;

import Core.ClientProvider;

public class Start {
    private ClientProvider clientProvider;    
    
    public Start(){
        this.clientProvider = new ClientProvider();        
    }



    public void Login(){
        System.out.println("Application for buying bus tickets");
        System.out.println("=========================================================================================");
        System.out.println("To login\t\t\tenter 1");
        System.out.println("To register\t\t\tenter 2");
        System.out.println("To exit\t\t\tenter 3");
        System.out.println("=========================================================================================");
        System.out.println("");
    }

}
