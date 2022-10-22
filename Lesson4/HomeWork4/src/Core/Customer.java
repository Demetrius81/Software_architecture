package Core;

import Models.Client;
import Models.Ticket;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Customer {
    private int id;
    private List<Ticket> tickets;
    private CashProvider cashProvider;
    private Client client;

    public Customer() {
        this.cashProvider = new CashProvider(client.getCardNumber());
    }

    public boolean buyTicket(Ticket ticket) throws RuntimeException {
        return cashProvider.buy(ticket);
    }

    public List<Ticket> searchTicket(Date date, int route) throws RuntimeException {
        TicketProvider provider = new TicketProvider();
        List<Ticket> result = new ArrayList<>();
        var list = provider.getTickets(route);
        for (Ticket ticket : list) {
            if (ticket.getDate() == date) {
                result.add(ticket);
            }
        }
        if (result.isEmpty()) {
            throw new RuntimeException("There are no tickets for this date");
        }
        return result;
    }
}
