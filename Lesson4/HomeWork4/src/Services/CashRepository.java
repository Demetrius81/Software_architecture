package Services;

import Models.BankAccount;

import java.util.ArrayList;
import java.util.List;

public class CashRepository implements ICashRepo {
    private static CashRepository cashRepository;

    private List<BankAccount> clients;

    public List<BankAccount> getClients() {
        return clients;
    }

    private CashRepository() {
        //имитация работы банка
        clients = new ArrayList<>();
        for (int i = 1; i <= 5; i++){
            clients.add(new BankAccount());
        }

    }

    public static CashRepository getCashRepository(){
        if(cashRepository == null){
            cashRepository = new CashRepository();
        }
        return cashRepository;
    }

    @Override
    public boolean transaction(int payment, long cardFrom, long cardTo) throws RuntimeException {
        BankAccount from = null;
        BankAccount to = null;
        for (var client : clients){
            if(client.getCard() == cardFrom){
                from = client;
            }
            if(client.getCard() == cardTo){
                to = client;
            }
        }
        if(from == null){
            throw new RuntimeException("No withdrawal account.");
        }
        if(to == null){
            throw new RuntimeException("No money account.");
        }
        if (from.getBalance() - payment < 0) {
            throw new RuntimeException("Insufficient funds.");
        }
        if(to.getBalance() > Integer.MAX_VALUE - payment){
            throw new RuntimeException("Too much amount.");
        }

        try{
        }finally {
            clients.remove(from);
            clients.remove(to);
            from.setBalance(from.getBalance() - payment);
            to.setBalance(to.getBalance() + payment);
            clients.add(from);
            clients.add(to);
        }
        return false;
    }
}
