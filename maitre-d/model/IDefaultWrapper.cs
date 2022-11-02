namespace maitre_d.model;

public interface IDefaultWrapper<out T>
{
    public T Value { get; }
}