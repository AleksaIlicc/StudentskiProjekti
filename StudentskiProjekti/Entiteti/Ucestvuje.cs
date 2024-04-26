namespace StudentskiProjekti.Entiteti
{
	public class Ucestvuje
	{
		public virtual int Id {  get; protected set; }
		public virtual int ProjekatId { get; set; }
		public virtual int StudentId { get; set; }
		public virtual DateTime DatumPocetkaIzrade { get; set; }
		public virtual DateTime? DatumZavrsetka { get; set; }
		public virtual DateTime RokZaZavrsetak { get; set; }
		public virtual string? ProjekatZavrsen { get; set; }
		public virtual string? OdabranProgramskiJezik { get; set; }
		public virtual string? UrlDokumentacijeProgJezika { get; set; }
		public virtual string? DopunskaLiteratura { get; set; }

		public virtual Student Student { get; set; }
		public virtual Projekat Projekat { get; set; }

		public Ucestvuje()
		{

		}

	}
}
