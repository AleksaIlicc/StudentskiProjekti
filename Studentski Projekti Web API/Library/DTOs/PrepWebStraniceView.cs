namespace Library.DTOs;

public class PreporucenaWebStranicaView
{
    public string? Naziv { get; set; }
    internal PreporucenaWebStranicaView(PProjektiWebStranice p)
    {
        Naziv = p.PreporucenaWebStrana;
    }

    public PreporucenaWebStranicaView() {}
}
