using maitre_d.model.contact;

namespace kata.model.contact;

public class Contact
{
    public Name Name { get; }
    public PhoneNumber? PhoneNumber { get; }
    public Email? Email { get; }

    public Contact(Name name)
    {
        Name = name;
    }

    public Contact(Name name, PhoneNumber phoneNumber, Email email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}