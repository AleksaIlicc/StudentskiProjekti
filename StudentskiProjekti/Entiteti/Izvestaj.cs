namespace StudentskiProjekti.Entiteti;

public class Izvestaj
{
    public virtual int Id { get; protected set; } 
    public required virtual string Opis { get; set; }
    public virtual DateTime? DatumPredaje { get; set; }

    // datum_predaje_u_odnosu_na_pocetak_projekta - izvedeni atribut

    public virtual IList<Predao> PredaoIzvestaji { get; set; }

    public Izvestaj()
    {
        PredaoIzvestaji = new List<Predao>();
    }
}

