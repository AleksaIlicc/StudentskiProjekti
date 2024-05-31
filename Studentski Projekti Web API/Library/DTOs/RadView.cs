namespace Library.DTOs;

public class RadView : LiteraturaView
{
    public int? Id { get; set; }
    public string? Url { get; set; }
    public string? KonferencijaObjavljivanja { get; set; }
    public string? Format { get; set; }

    internal RadView(Rad r) : base(r.Literatura!)
    {
        this.Id = r.Id;
        this.Url = r.Url;
        this.KonferencijaObjavljivanja = r.KonferencijaObjavljivanja;
        this.Format = r.Format;
    }

    public RadView() { }
}
