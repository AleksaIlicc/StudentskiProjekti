namespace StudentskiProjekti.Entiteti;
public class Ucestvuje
{
	public virtual int Id {  get; protected set; }
	public required virtual DateTime DatumPocetkaIzrade { get; set; }
	public virtual DateTime? DatumZavrsetka { get; set; }
	public required virtual DateTime RokZaZavrsetak { get; set; }
	public virtual string ProjekatZavrsen { get; set; }
	public virtual string OdabranProgramskiJezik { get; set; }
	public virtual string UrlDokumentacijeProgJezika { get; set; }
	public virtual string DopunskaLiteratura { get; set; }

	public required virtual Student Student { get; set; }
	public required virtual Projekat Projekat { get; set; }

	public Ucestvuje()
	{

	}
}

