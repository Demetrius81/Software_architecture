package Core;

import Models.Ticket;
import Services.ITicketRepo;
import Services.TicketRepository;

import java.util.List;

public class TicketProvider {
    private ITicketRepo ticketRepo;

    public TicketProvider() {
        this.ticketRepo = TicketRepository.getTicketRepository();
    }

    public List<Ticket> getTickets(int routeNumber) throws RuntimeException {
        return ticketRepo.readAll(routeNumber);
    }

    public boolean updateTicketStatus(Ticket ticket){
        boolean result = ticketRepo.update(ticket);
        return result;
    }
}
