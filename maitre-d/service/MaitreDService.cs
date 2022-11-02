using maitre_d.model;

namespace maitre_d.service;

public class MaitreDService: IMaitreDService
{
    public bool ProcessReservation(Restaurant restaurant, Reservation reservation)
    {
        return restaurant.PersonCount.Value >= reservation.PersonCount.Value;
    }
}