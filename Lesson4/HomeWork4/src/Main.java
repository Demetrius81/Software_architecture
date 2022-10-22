import Services.CashRepository;

public class Main {
    public static void main(String[] args) {
        var c = CashRepository.getCashRepository();
        var cl = c.getClients();
        for(var cc : cl){
            System.out.println(cc.toString());
        }
    }
}