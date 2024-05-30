namespace Library.DTOs;

public class PreporucenaWebStranicaView
{
    public string? Naziv { get; set; }
    internal PreporucenaWebStranicaView(string naziv)
    {
        this.Naziv = naziv;
    }

    public PreporucenaWebStranicaView() {}
}
