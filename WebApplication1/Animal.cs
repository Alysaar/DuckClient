namespace WebApplication1;

public abstract class Animal
{
    protected Animal(string sound)
    {
        Sound = sound;
    }
    
    public virtual string Sound { get; }
    public abstract string TypeName { get; }
}