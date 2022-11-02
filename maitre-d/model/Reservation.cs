using kata.model.contact;

namespace maitre_d.model;

public class Reservation
{
    private readonly DateTime _dateTime;
    public PersonCount PersonCount{ get; }
    private readonly Contact _contact;
        
    public Reservation(DateTime dateTime, PersonCount personCount, Contact contact)
    {
        _dateTime = dateTime;
        PersonCount = personCount;
        _contact = contact;
    }
}