namespace maitre_d.model;

public class PersonCount: IDefaultWrapper<ushort>
{
    public ushort Value { get; }

    public PersonCount(ushort value)
    {
        this.Value = value;
    }
}