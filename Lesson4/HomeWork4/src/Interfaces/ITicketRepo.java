package Interfaces;

import Models.Ticket;

import java.util.List;

/**
 * Интерфейс взаимодействия с базой билетов
 */
public interface ITicketRepo {
    boolean create(Ticket ticket);
    List<Ticket> readAll(int routeNumber);
    boolean update(Ticket ticket);
    boolean delete(Ticket ticket);
}
