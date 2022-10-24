package Core;

import Interfaces.ICarrierRepo;
import Interfaces.ICashRepo;
import Models.Carrier;
import Models.Client;
import Models.Ticket;
import Services.CarrierRepository;
import Services.CashRepository;

public class CashProvider {
    private long cardNumber;//TODO: implement setter
    private boolean isAuthorized = true; //TODO: implement authorization logic!!!!!
    private ICarrierRepo carrierRepository;
    private ICashRepo cashRepository;

    public CashProvider() {
        //this.cardNumber = cardNumber;
        this.carrierRepository = CarrierRepository.getCarrierRepository();
        this.cashRepository = CashRepository.getCashRepository();
    }

    public boolean buy(Ticket ticket) throws RuntimeException {
        if (isAuthorized) {
            Carrier carrier = carrierRepository.read(1);
            return cashRepository.transaction(ticket.getPrice(), cardNumber, carrier.getCardNumber());//TODO: insert the client card number
        }
        return false;
    }

    public void authorization(Client client) {
        //TODO: Create Authorization class and implement logic
        isAuthorized = client.getCardNumber() == cardNumber;
    }
}
