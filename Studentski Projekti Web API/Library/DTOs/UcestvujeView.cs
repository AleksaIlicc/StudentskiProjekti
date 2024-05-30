namespace Library.DTOs;
public class UcestvujeView
{
	public int? Id { get; set; }
	public DateTime? DatumPocetkaIzrade { get; set; }
	public DateTime? DatumZavrsetka { get; set; }
	public DateTime? RokZaZavrsetak { get; set; }
	public string? OdabranProgramskiJezik { get; set; }
	public string? UrlDokumentacijeProgJezika { get; set; }
	public string? DopunskaLiteratura { get; set; }
	public string? ProjekatZavrsen { get; set; }

	internal UcestvujeView(Ucestvuje u)
	{
		Id = u.Id;
		DatumPocetkaIzrade = u.DatumPocetkaIzrade;
		DatumZavrsetka = u.DatumZavrsetka;
		RokZaZavrsetak = u.RokZaZavrsetak;
		OdabranProgramskiJezik = u.OdabranProgramskiJezik;
		UrlDokumentacijeProgJezika = u.UrlDokumentacijeProgJezika;
		DopunskaLiteratura = u.DopunskaLiteratura;
		ProjekatZavrsen = u.ProjekatZavrsen;
	}
	public UcestvujeView() { }
}
