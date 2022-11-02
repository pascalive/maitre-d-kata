using maitre_d.model;

namespace maitre_d.service;

public interface IMaitreDService
{
    public bool ProcessReservation(Restaurant restaurant, Reservation reservation);
}