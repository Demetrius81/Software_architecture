package Core;

import Interfaces.ITicket;
import Interfaces.ITicketRepo;
import Services.TicketRepository;

import java.util.List;

public class TicketProvider {
    private ITicketRepo ticketRepo;

    public TicketProvider() {
        this.ticketRepo = TicketRepository.getTicketRepository();
    }

    public List<ITicket> getTickets(int routeNumber) throws RuntimeException {
        return ticketRepo.readAll(routeNumber);
    }

    public boolean updateTicketStatus(ITicket ticket){
        ticket.setValid(false);
        return ticketRepo.update(ticket);
    }
}
