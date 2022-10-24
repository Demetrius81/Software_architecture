package Models;

import Interfaces.ITicket;

import java.util.Date;

public class Ticket implements ITicket {
    private int routeNumber;
    private int place;
    private int price;
    private Date date;
    private boolean isValid;

    public Ticket(int routeNumber, int place, int price, Date date, boolean isValid) {
        this.routeNumber = routeNumber;
        this.place = place;
        this.price = price;
        this.date = date;
        this.isValid = isValid;
    }

    @Override
    public int getRouteNumber() {
        return routeNumber;
    }

    @Override
    public int getPlace() {
        return place;
    }

    @Override
    public int getPrice() {
        return price;
    }

    @Override
    public Date getDate() {
        return date;
    }

    @Override
    public boolean getValid() {
        return isValid;
    }

    @Override
    public void setValid(boolean valid) {
        isValid = valid;
    }

    @Override
    public String toString() {
        return "Ticket" +
                " Route Number " + routeNumber +
                ", Place " + place +
                ", Price " + price + " rub." +
                ", Date " + date +
                ", " + (isValid?"Free":"Busy");
    }

    @Override
    public String toPrint() {
        return "Ticket" +
                "\nRoute Number " + routeNumber +
                "\nPlace " + place +
                "\nPrice " + price + "rub." +
                "\nDate " + date;
    }

    @Override
    public int hashCode() {
        return date.hashCode() ^ (routeNumber + place + price);
    }

    @Override
    public boolean equals(Object obj) {
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }
        return this.equals((Ticket) obj);
    }

    @Override
    public boolean equals(Ticket ticket) {
        boolean isIt = ticket != null
                && ticket.getRouteNumber() == this.routeNumber
                && ticket.getPlace() == this.place
                && ticket.getPrice() == this.price
                && ticket.getDate() == this.date
                && ticket.hashCode() == this.hashCode();

        if(isIt) {
            return true;
        }
        return false;
    }
}
