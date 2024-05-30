namespace Library.DTOs;

public class IzvestajView
{
    public int? Id { get; set; }
    public DateTime? DatumPredaje { get; set; }
    public string? Opis { get; set; }

    internal IzvestajView(Izvestaj i)
    {
        Opis = i.Opis;
        DatumPredaje = i.DatumPredaje;
    }
    public IzvestajView() { }
}
