namespace Library.DTOs;
public class LiteraturaView
{
    public int? Id { get; set; }
    public string? Naziv { get; set; }

    internal LiteraturaView(Literatura l)
    {
        Id = l.LitId;
        Naziv = l.Naziv;
    }
    public LiteraturaView() { }
}