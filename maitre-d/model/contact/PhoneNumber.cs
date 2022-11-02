namespace maitre_d.model.contact;

public class PhoneNumber: IDefaultWrapper<ushort>
{
    public ushort Value { get; }
    
    public PhoneNumber(ushort value)
    {
        Value = value;
    }
}