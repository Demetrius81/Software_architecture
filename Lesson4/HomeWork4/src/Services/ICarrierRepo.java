package Services;

import Models.Carrier;

public interface ICarrierRepo {
    Carrier read(int id);
}
