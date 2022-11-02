namespace maitre_d.model.contact;

public class Id: IDefaultWrapper<string>
{
    public string Value { get; }
    
    public Id(string value)
    {
        Value = value;
    }
}