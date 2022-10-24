package Interfaces;

import Models.User;

public interface IUser {
    int getId();

    String getUserName();

    int getHashPassword();

    long getCardNumber();

    @Override
    String toString();

    @Override
    boolean equals(Object o);

    boolean equals(User client);

    @Override
    int hashCode();
}
