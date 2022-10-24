package Interfaces;

import Core.UserProvider;

import java.util.Date;
import java.util.List;

/**
 * Интерфейс взаимодействия с клиентским приложением
 */
public interface ICustomer {
    List<ITicket> getSelectedTickets();
    void setSelectedTickets(List<ITicket> selectedTickets);
    IUser getUser();
    void setUser(IUser client);
    UserProvider getUserProvider();
    boolean buyTicket(ITicket ticket) throws RuntimeException;
    List<ITicket> searchTicket(Date date, int route) throws RuntimeException;
}
