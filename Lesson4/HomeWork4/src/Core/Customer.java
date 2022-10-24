package Core;

import Interfaces.IUser;
import Interfaces.ICustomer;
import Interfaces.ITicket;
import Models.Ticket;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Customer implements ICustomer {
    private TicketProvider ticketProvider;
    private CashProvider cashProvider;
    private UserProvider userProvider;
    private IUser client;
    private List<ITicket> selectedTickets;

    public Customer() {
        this.cashProvider = new CashProvider();
        this.ticketProvider = new TicketProvider();
        this.userProvider = new UserProvider();
    }

    @Override
    public List<ITicket> getSelectedTickets() {
        return selectedTickets;
    }

    @Override
    public void setSelectedTickets(List<ITicket> selectedTickets) {
        this.selectedTickets = selectedTickets;
    }

    @Override
    public UserProvider getUserProvider() {
        return userProvider;
    }

    @Override
    public IUser getUser() {
        return client;
    }

    @Override
    public void setUser(IUser client) {
        this.client = client;
    }

    @Override
    public boolean buyTicket(ITicket ticket) throws RuntimeException {
        boolean flag;
        cashProvider.authorization(client);
        flag = cashProvider.buy(ticket);
        if (flag) {
            flag = ticketProvider.updateTicketStatus(ticket);
        }
        return flag;
    }

    @Override
    public List<ITicket> searchTicket(Date date, int route) throws RuntimeException {
        List<ITicket> result = new ArrayList<>();
        var list = ticketProvider.getTickets(route);
        for (ITicket ticket : list) {
            if (ticket.getDate().equals(date)) {
                result.add((Ticket)ticket);
            }
        }
        if (result.isEmpty()) {
            throw new RuntimeException("There are no tickets for this date");
        }
        return result;
    }
}
