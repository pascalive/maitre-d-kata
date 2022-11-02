namespace maitre_d.model;

public class Restaurant: IRestaurant
{
    public PersonCount PersonCount { get; }
    
    public Restaurant(PersonCount personCount)
    {
        PersonCount = personCount;
    }
}