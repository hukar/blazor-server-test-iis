namespace BlazorServerTestIis.Domain;

public class Robot
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public int Power { get; set; }
    public CyberBrain? CyberBrain { get; set; }
}
