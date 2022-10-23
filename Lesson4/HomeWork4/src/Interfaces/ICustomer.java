package Interfaces;

import Models.Ticket;

import java.util.Date;
import java.util.List;

/**
 * Интерфейс взаимодействия с клиентским приложением
 */
public interface ICustomer {
    boolean buyTicket(Ticket ticket) throws RuntimeException;

    List<Ticket> searchTicket(Date date, int route) throws RuntimeException;
}
