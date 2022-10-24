package Core;

import Interfaces.ICarrierRepo;
import Interfaces.ICashRepo;
import Interfaces.IUser;
import Interfaces.ITicket;
import Models.Carrier;
import Services.CarrierRepository;
import Services.CashRepository;

public class CashProvider {
    private long cardNumber;
    private boolean isAuthorized = false;
    private ICarrierRepo carrierRepository;
    private ICashRepo cashRepository;

    public CashProvider() {
        this.carrierRepository = CarrierRepository.getCarrierRepository();
        this.cashRepository = CashRepository.getCashRepository();
    }

    public boolean buy(ITicket ticket) throws RuntimeException {
        if (isAuthorized) {
            Carrier carrier = carrierRepository.read(1);
            return cashRepository.transaction(ticket.getPrice(), cardNumber, carrier.getCardNumber());
        }
        return false;
    }

    public void authorization(IUser client) {
        //Здесь должна быть реализована сверка аккаунта приложения и банковского аккаунта.
        cardNumber = client.getCardNumber();
        isAuthorized = true;
    }
}
