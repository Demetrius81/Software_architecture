package Interfaces;

import Models.Ticket;

import java.util.Date;

public interface ITicket {
    int getRouteNumber();

    int getPlace();

    int getPrice();

    Date getDate();

    boolean getValid();

    void setValid(boolean valid);

    @Override
    String toString();

    String toPrint();

    @Override
    int hashCode();

    @Override
    boolean equals(Object obj);

    boolean equals(Ticket ticket);
}
