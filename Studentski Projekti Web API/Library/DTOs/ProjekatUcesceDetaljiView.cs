namespace Library.DTOs;

public class ProjekatUcesceDetaljiView
{
    public int? IdProjekta { get; set; }
    public string? NazivProjekta { get; set; }
    public DateTime? DatumPocetkaIzrade { get; set; }
    public DateTime? DatumZavrsetkaIzrade { get; set; }
    public DateTime? RokZaZavrsetak { get; set; }
    public string? ProjekatZavrsen { get; set; }
    public string? VrstaProjekta { get; set; }
    public string? NazivPredmeta { get; set; }
    public string? OdabranProgramskiJezik { get; set; }
    public string? UrlDokumentacijeProgJezika { get; set; }
    public string? DopunskaLiteratura { get; set; }

    public ProjekatUcesceDetaljiView() { }
}
