namespace WebApplication1;

public class Duck : Animal
{
    public Duck(string sound) : base(sound)
    {
    }
    
    public override string TypeName { get; } = nameof(Duck);
}