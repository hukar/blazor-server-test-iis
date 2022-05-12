namespace BlazorServerTestIis.Domain;
public class CyberBrain
{
    public int Id { get; set; }
    public string Label { get; set; } = string.Empty;
    public int CyberQi { get; set; }
    public int Cost { get; set; }

    // Note: this is important so the MudSelect can compare pizzas
    public override bool Equals(object? o) {
        var other = o as CyberBrain ;
        return other is null ? false : other.Label==Label;
    }

    // Note: this is important too!
    public override int GetHashCode() => Label?.GetHashCode() ?? 0;

    public override string ToString() => Label;
}
