namespace maitre_d.model.contact;

public class Email: IDefaultWrapper<string>
{
    public string Value { get; }

    public Email(string value)
    {
        Value = value;
    }
}