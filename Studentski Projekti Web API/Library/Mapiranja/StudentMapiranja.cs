namespace Library.Mapiranja;
internal class StudentMapiranja : ClassMap<Student>
{
    public StudentMapiranja()
    {
        Table("STUDENT");

        Id(x => x.BrIndeksa, "BR_INDEKSA").GeneratedBy.Assigned();
        Map(x => x.LIme, "LIME"); 
        Map(x => x.ImeRoditelja, "IME_RODITELJA");
        Map(x => x.Prezime, "PREZIME");
        Map(x => x.Smer, "SMER");

		HasMany(x => x.UcestvujeProjekti).KeyColumn("STUDENT_ID").Cascade.All().Inverse();
		HasMany(x => x.PredaoIzvestaji).KeyColumn("STUDENT_ID").Cascade.All().Inverse();
	}
}
