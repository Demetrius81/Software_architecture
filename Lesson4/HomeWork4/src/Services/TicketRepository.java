package Services;

import Models.Ticket;

import java.util.*;

public class TicketRepository implements ITicketRepo {
    private static TicketRepository ticketRepository;
    private List<Ticket> tickets;

    private TicketRepository() {
        //здесь симуляция работы с БД
        tickets = new ArrayList<>();
        generateTickets(1, 6, 10, new Date());
        generateTickets(2, 4, 15, new Date());
    }

    public static TicketRepository getTicketRepository() {
        if (ticketRepository == null) {
            ticketRepository = new TicketRepository();
        }
        return ticketRepository;
    }

    @Override
    public boolean create(Ticket ticket) {
        //функционал не используется
        tickets.add(ticket);
        return true;
    }

    @Override
    public List<Ticket> readAll(int routeNumber) throws RuntimeException {
        List<Ticket> routeTickets = new ArrayList<>();
        for (Ticket ticket : tickets){
            if(ticket.getRouteNumber() == routeNumber){
                routeTickets.add(ticket);
            }
        }
        if (routeTickets.isEmpty()){
            throw new RuntimeException("There are no tickets for this bus.");
        }
        return tickets;
    }

    @Override
    public boolean update(Ticket ticket) {
        int n = 0;
        for (Ticket tick : tickets) {
            if (tick.equals(ticket)) {
                n = tickets.indexOf(tick);
                break;
            }
            return false;
        }
        tickets.remove(n);
        tickets.add(ticket);
        return true;
    }

    @Override
    public boolean delete(Ticket ticket) {
        //функционал не используется
        if (tickets.contains(ticket)) {
            tickets.remove(ticket);
            return true;
        }
        return false;
    }

    private void generateTickets(int roureNumber, int countPlaces, int price, Date date) {
        for (int i = 1; i <= countPlaces; i++) {
            tickets.add(new Ticket(roureNumber, i, price, date, true));
        }
    }
}
