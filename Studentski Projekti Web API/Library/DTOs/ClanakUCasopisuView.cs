namespace Library.DTOs;

public class ClanakUCasopisuView : LiteraturaView
{
    public string? ISSN { get; set; }
    public string? ImeCasopisa { get; set; }
    public int? Broj { get; set; }
    public int? Godina { get; set; }

    internal ClanakUCasopisuView(ClanakUCasopisu c) : base(c.Literatura)
    {
        this.ImeCasopisa = c.ImeCasopisa;
        this.ISSN = c.ISSN;
        this.Broj = c.Broj;
        this.Godina = c.Godina;
    }
    public ClanakUCasopisuView() { }
}