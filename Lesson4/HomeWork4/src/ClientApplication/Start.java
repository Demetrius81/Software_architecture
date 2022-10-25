package ClientApplication;

import Core.Customer;
import Interfaces.ICustomer;
import Interfaces.ITicket;

import java.util.Date;
import java.util.List;

public class Start extends EnterData {
    private ICustomer customer;
    private int ticketRouteNumber;
    private Date ticketDate;

    public void run() {
        runLoginRegisterMenu();
    }

    private void runLoginRegisterMenu() {
        while (true) {
            System.out.println("Application for buying bus tickets");
            System.out.println("=====================================================================================");
            System.out.println("This is a test version. The data base is not available in full mode.");
            System.out.println("=====================================================================================");
            System.out.println("To login\t\t\tenter 1");
            System.out.println("To register\t\t\tenter 2");
            System.out.println("To exit\t\t\t\tenter 0");
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
                    if (customer.getUser() == null) {
                        break;
                    } else {
                        runBuyingMenu();
                        break;
                    }
                case 2:
                    register();
                    if (customer == null) {
                        break;
                    } else {
                        runBuyingMenu();
                        break;
                    }
                default:
                    return;
            }
        }
    }

    private void login() {
        System.out.println("This is a test version. The data base is not available in full mode.");
        System.out.println("=====================================================================================");
        System.out.println("Login");
        System.out.println("=====================================================================================");
        System.out.print("User name: ");
        String userName = inputString();
        System.out.print("Password: ");
        int passwordHash = inputString().hashCode();
        System.out.println("=====================================================================================");
        System.out.print("Enter the system... ");
        customer = new Customer();
        try {
            customer.setUser(Authentication.authentication(customer.getUserProvider(), userName, passwordHash));
        } catch (RuntimeException ex) {
            System.out.println("FAIL");
            System.out.println(ex.getMessage());
            System.out.println("=====================================================================================");
            return;
        }
        System.out.println("OK");
        System.out.println("=====================================================================================");
    }

    private void register() {
        System.out.println("This is a test version. The data base is not available in full mode.");
        System.out.println("=====================================================================================");
        System.out.println("Register");
        System.out.println("=====================================================================================");
        System.out.print("Enter user name: ");
        String userName = inputString();
        System.out.print("Enter password: ");
        int passwordHash = inputString().hashCode();
        System.out.print("Repeat password: ");
        int passwordHash2 = inputString().hashCode();
        if(passwordHash != passwordHash2){
            System.out.println("=====================================================================================");
            System.out.println("Passwords do not match. Exit register.");
            System.out.println("=====================================================================================");
            return;
        }
        System.out.print("Enter card number: ");
        long cardNumber = inputLong(1L, 9999_9999_9999_9999L);
        System.out.println("=====================================================================================");
        System.out.print("Register the system... ");
        customer = new Customer();
        int id;
        try {
            id = customer.getUserProvider().createClient(userName, passwordHash, cardNumber);
            customer.setUser(Authentication.authentication(customer.getUserProvider(), userName, passwordHash));
        } catch (RuntimeException ex) {
            System.out.println("FAIL");
            System.out.println(ex.getMessage());
            System.out.println("=====================================================================================");
            return;
        }
        System.out.println("OK. user " + customer.getUser().getUserName() + " with ID " + id + "added to base.");
        System.out.println("=====================================================================================");
    }

    private void runBuyingMenu() {
        boolean run = true;
        while (run) {
            System.out.println("Application for buying bus tickets. | User " + customer.getUser().getUserName() + " |");
            System.out.println("=====================================================================================");
            System.out.println("To select route number and print all tickets\tenter 1");
            System.out.println("To logout\t\t\t\t\t\t\t\t\t\tenter 0");
            System.out.println("=====================================================================================");
            System.out.print("Enter your choice > ");
            int choice = 0;

            try {
                choice = inputInt(0, 1);
            } catch (RuntimeException ex) {
                System.out.println("==============================================================================" +
                        "=======");
                System.out.println(ex.getMessage());
                System.out.println("==============================================================================" +
                        "=======");
                continue;
            }
            System.out.println("=====================================================================================");

            switch (choice) {
                case 1:
                    ticketRouteNumber = runSelectRouteMenu();
                    if (ticketRouteNumber > 0) {
                        ticketDate = runSelectDate();
                        if (ticketDate != null) {
                            try {
                                customer.setSelectedTickets(customer.searchTicket(ticketDate, ticketRouteNumber));
                            } catch (RuntimeException ex){
                                System.err.println(ex.getMessage());
                                System.out.println("=============================================================" +
                                        "========================");
                                continue;
                            }
                            printAllTickets(customer.getSelectedTickets());
                            buyTicketMenu();
                            continue;
                            //return;
                        }
                        continue;
                    }
                    continue;
                default:
                    run = false;
                    break;
            }
        }
    }

    private int runSelectRouteMenu() {
        System.out.println("Input route number and date. | User " + customer.getUser().getUserName() + " |");
        System.out.println("=====================================================================================");
        System.out.print("Route number > ");
        //Здесь ограничиваем число маршрутов. У на всего 2 маршрута.
        int numRoute;
        try {
            numRoute = inputInt(1, 2);
        } catch (RuntimeException ex) {
            System.out.println(ex.getMessage());
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
            System.out.println(ex.getMessage());
            System.out.println("=====================================================================================");
            return null;
        }
        System.out.println("=====================================================================================");
        return date;
    }

    private void printAllTickets(List<ITicket> ticks) {
        for (var t : ticks) {
            System.out.println(t.toString());
        }
        System.out.println("=====================================================================================");
    }


    private void buyTicketMenu() {
        System.out.println("Confirm to buy. | User " + customer.getUser().getUserName() + " |");
        System.out.println("=====================================================================================");
        System.out.print("To buy a ticket for bus route " + ticketRouteNumber + " on the " + ticketDate + " enter" +
                " \"Yes\" > ");
        String answer = inputString();
        System.out.println("=====================================================================================");
        if (answer.equalsIgnoreCase("YES")) {
            for (var t : customer.getSelectedTickets()) {
                if (t.getDate().equals(ticketDate) && t.getRouteNumber() == ticketRouteNumber && t.getValid()) {
                    boolean flag = false;
                    try {
                        flag = customer.buyTicket(t);
                    } catch (RuntimeException ex) {
                        System.out.println(ex.getMessage());
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
