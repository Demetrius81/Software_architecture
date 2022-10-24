package Interfaces;

import Models.Ticket;

import java.util.List;

/**
 * Интерфейс взаимодействия с базой билетов
 */
public interface ITicketRepo {
    boolean create(ITicket ticket);
    List<ITicket> readAll(int routeNumber);
    boolean update(ITicket ticket);
    boolean delete(ITicket ticket);
}
