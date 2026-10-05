public class Scam
{
    public int Id { get; set; }
    public string? ScamDescription { get; set; } // TODO: char max?
    public string? PhoneNumber { get; set; } // TODO: should be number
    public string? EmailAddress { get; set; } // TODO: maybe different type
    public string? Website { get; set; } // TODO: custom validator?
    public string? Secret { get; set; } // part of tutorial, not sure if I should keep it
}