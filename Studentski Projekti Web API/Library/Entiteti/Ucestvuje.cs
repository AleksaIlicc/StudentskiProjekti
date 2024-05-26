namespace Library.Entiteti;
internal class Ucestvuje
{
    internal protected virtual int Id {  get; protected set; }
    internal protected required virtual DateTime DatumPocetkaIzrade { get; set; }
    internal protected virtual DateTime? DatumZavrsetka { get; set; }
    internal protected required virtual DateTime RokZaZavrsetak { get; set; }
    internal protected virtual string ProjekatZavrsen { get; set; }
    internal protected virtual string OdabranProgramskiJezik { get; set; }
    internal protected virtual string UrlDokumentacijeProgJezika { get; set; }
    internal protected virtual string DopunskaLiteratura { get; set; }

    internal protected required virtual Student Student { get; set; }
    internal protected required virtual Projekat Projekat { get; set; }

    internal Ucestvuje()
	{

	}
}

