package Interfaces;

import Core.ClientProvider;
import Models.Client;
import Models.Ticket;

import java.util.Date;
import java.util.List;

/**
 * Интерфейс взаимодействия с клиентским приложением
 */
public interface ICustomer {
    Client getClient();
    void setClient(Client client);
    ClientProvider getClientProvider();
    boolean buyTicket(Ticket ticket) throws RuntimeException;

    List<Ticket> searchTicket(Date date, int route) throws RuntimeException;
}
