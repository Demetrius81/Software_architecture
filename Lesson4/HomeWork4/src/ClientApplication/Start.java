package ClientApplication;

import Core.Customer;
import Interfaces.ICustomer;
import Models.Ticket;

import java.util.Date;
import java.util.List;

public class Start extends EnterData {
    private ICustomer customer;
    private List<Ticket> tickets;
    private int ticketRouteNumber;
    private Date ticketDate;

    public void run() {
        runLoginRegisterMenu();
    }

    public Start() {
        this.customer = new Customer();
    }

    private void runLoginRegisterMenu() {
        while (true) {
            System.out.println("Application for buying bus tickets");
            System.out.println("=====================================================================================");
            System.out.println("To login\t\t\tenter 1");
            System.out.println("To register\t\t\tenter 2");
            System.out.println("To exit\t\t\tenter 0");
            System.out.println("=====================================================================================");
            System.out.print("Enter your choice > ");
            int choice = 0;

            try {
                choice = inputInt(0, 2);
            } catch (RuntimeException ex) {
                System.err.println(ex.getMessage());
                continue;
            }
            System.out.println("=====================================================================================");

            switch (choice) {
                case 1:
                    login();
                    if (customer.getClient() == null) {
                        break;
                    } else {
                        runBuyingMenu();
                        return;
                    }
                case 2:
                    register();
                    break;
                default:
                    return;
            }
        }
    }

    private void login() {
        System.out.println("Login");
        System.out.println("=====================================================================================");
        System.out.print("User name: ");
        String userName = inputString();
        System.out.print("Password: ");
        int passwordHash = inputString().hashCode();
        System.out.println("=====================================================================================");
        System.out.print("Enter the system... ");
        try {
            customer.setClient(Authentication.authentication(customer.getClientProvider(), userName, passwordHash));
        } catch (RuntimeException ex) {
            System.out.println(ex.getMessage());
            System.out.println("=====================================================================================");
            return;
        }
        System.out.println("OK");
        System.out.println("=====================================================================================");
    }

    private void register() {

    }

    private void runBuyingMenu() {
        while (true) {
            System.out.println("Application for buying bus tickets. | User " + customer.getClient().getUserName() + " |");
            System.out.println("=====================================================================================");
            System.out.println("To select route number and print all tickets\tenter 1");
            System.out.println("To exit\t\t\tenter 0");
            System.out.println("=====================================================================================");
            System.out.print("Enter your choice > ");
            int choice = 0;

            try {
                choice = inputInt(0, 1);
            } catch (RuntimeException ex) {
                System.err.println(ex.getMessage());
                continue;
            }
            System.out.println("=====================================================================================");

            switch (choice) {
                case 1:
                    ticketRouteNumber = runSelectRouteMenu();
                    if (ticketRouteNumber > 0) {
                        ticketDate = runSelectDate();
                        if (ticketDate != null) {
                            tickets = customer.searchTicket(ticketDate, ticketRouteNumber); // TODO: Implement catch!!!
                            printAllTickets(tickets);
                            buyTicketMenu();
                            return;
                        }
                        continue;
                    }
                    continue;
                default:
                    return;
            }
        }
    }

    private int runSelectRouteMenu() {
        System.out.println("Input route number and date. | User " + customer.getClient().getUserName() + " |");
        System.out.println("=====================================================================================");
        System.out.print("Route number > ");
        //Здесь ограничиваем число маршрутов. У на всего 2 маршрута.
        int numRoute;
        try {
            numRoute = inputInt(1, 2);
        } catch (RuntimeException ex) {
            System.err.println(ex.getMessage());
            System.out.println("=====================================================================================");
            return -1;
        }
        System.out.println("=====================================================================================");
        return numRoute;
    }

    private Date runSelectDate() {
        System.out.print("Date > ");
        //Здесь ограничиваем число маршрутов. У на всего 2 маршрута.
        Date date;
        try {
            date = inputDate();
        } catch (RuntimeException ex) {
            System.err.println(ex.getMessage());
            System.out.println("=====================================================================================");
            return null;
        }
        System.out.println("=====================================================================================");
        return date;
    }

    private void printAllTickets(List<Ticket> ticks) {
        for (var t : ticks) {
            System.out.println(t.toString());
        }
        System.out.println("=====================================================================================");
    }


    private void buyTicketMenu() {
        System.out.println("Confirm to buy. | User " + customer.getClient().getUserName() + " |");
        System.out.println("=====================================================================================");
        System.out.print("To buy a ticket for bus route " + ticketRouteNumber + " on the " + ticketDate + " enter" +
                " \"Yes\" > ");
        String answer = inputString();
        System.out.println("=====================================================================================");
        if (answer.equalsIgnoreCase("YES")) {
            for (var t : tickets) {
                if (t.getDate().equals(ticketDate) && t.getRouteNumber() == ticketRouteNumber && t.getValid()) {
                    boolean flag = false;
                    try {
                        flag = customer.buyTicket(t);
                    } catch (RuntimeException ex) {
                        System.err.println(ex.getMessage());
                        System.out.println("====================================================================" +
                                "=================");
                        return;
                    }
                    if (flag) {
                        System.out.println(t.toPrint());
                        System.out.println("====================================================================" +
                                "=================");
                        return;
                    }
                }
            }
        }
    }
}
