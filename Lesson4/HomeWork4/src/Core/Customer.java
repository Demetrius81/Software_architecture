package Core;

import Interfaces.ICustomer;
import Models.Client;
import Models.Ticket;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Customer implements ICustomer {
    //private int id;
    //private List<Ticket> tickets;
    private TicketProvider ticketProvider;
    private CashProvider cashProvider;
    private ClientProvider clientProvider;
    private Client client;

    public Customer() {
        this.cashProvider = new CashProvider();
        this.ticketProvider = new TicketProvider();
        this.clientProvider = new ClientProvider();
    }

    @Override
    public ClientProvider getClientProvider() {
        return clientProvider;
    }

    @Override
    public Client getClient() {
        return client;
    }

    @Override
    public void setClient(Client client) {
        this.client = client;
    }

    @Override
    public boolean buyTicket(Ticket ticket) throws RuntimeException {  //TODO: add client as parameter
        boolean flag;
        flag = cashProvider.buy(ticket);
        if (flag) {
            flag = ticketProvider.updateTicketStatus(ticket);
        }
        return flag;
    }

    @Override
    public List<Ticket> searchTicket(Date date, int route) throws RuntimeException {
        List<Ticket> result = new ArrayList<>();
        var list = ticketProvider.getTickets(route);
        for (Ticket ticket : list) {
            if (ticket.getDate().equals(date)) {
                result.add(ticket);
            }
        }
        if (result.isEmpty()) {
            throw new RuntimeException("There are no tickets for this date");
        }
        return result;
    }
}
