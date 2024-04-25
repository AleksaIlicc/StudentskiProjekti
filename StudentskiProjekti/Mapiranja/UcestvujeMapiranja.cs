namespace StudentskiProjekti.Mapiranja
{
	public class UcestvujeMapiranja : ClassMap<Ucestvuje>
	{
		public UcestvujeMapiranja()
		{
			Table("UCESTVUJE");

			// TO DO, ALTER TABLE, IZMENITI TRENUTNI PK, DODATI ID ZA PK, NAPRAVITI SEKVENCU
			Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16323.SEFUJE_ID_SEQ");

			Map(x => x.DatumPocetkaIzrade, "DATUM_POCETKA_IZRADE");
			Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");
			Map(x => x.RokZaZavrsetak, "ROK_ZA_ZAVRSETAK");
			Map(x => x.ProjekatZavrsen, "PROJEKAT_ZAVRSEN");
			Map(x => x.OdabranProgramskiJezik, "ODABRAN_PROG_JEZIK");
			Map(x => x.UrlDokumentacijeProgJezika, "URL_DOKUMENTACIJE_PROG_JEZIKA");
			Map(x => x.DopunskaLiteratura, "DOPUNSKA_LITERATURA");

			References(x => x.Student).Column("STUDENT_ID");
			References(x => x.Projekat).Column("PROJEKAT_ID");
		}
	}
}
