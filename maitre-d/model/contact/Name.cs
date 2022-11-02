namespace maitre_d.model.contact;

public class Name: IDefaultWrapper<string>
{
    public string Value { get; }
    
    public Name(string value)
    {
        Value = value;
    }
}