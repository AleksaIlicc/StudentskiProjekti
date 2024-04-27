namespace StudentskiProjekti;

public class DTOManager
{
    public static List<PredmetPregled> vratiSvePredmete()
    {
        List<PredmetPregled> predmeti = new List<PredmetPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Predmet> sviPredmeti = from o in s.Query<Predmet>() select o;

            foreach (Predmet p in sviPredmeti)
            {

                predmeti.Add(new PredmetPregled(p.Id, p.Naziv, p.Semestar, p.Katedra));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return predmeti;
    }

    public static void dodajPredmet(PredmetPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet o = new Predmet();

            o.Id = p.Id;
            o.Naziv = p.Naziv;
            o.Katedra = p.Katedra;
            o.Semestar = p.Semestar;


            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }
    }
    public static void obrisiPredmet(string id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet o = s.Load<Predmet>(id);

            s.Delete(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }
    }
    public static PredmetPregled azurirajPredmet(PredmetPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet o = s.Load<Predmet>(p.Id);
            o.Id = p.Id;
            o.Naziv = p.Naziv;
            o.Katedra = p.Katedra;
            o.Semestar = p.Semestar;
            

            s.Update(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }

        return p;
    }

    public static PredmetPregled vratiPredmet(string id)
    {
        PredmetPregled pb = new PredmetPregled();
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet o = s.Load<Predmet>(id);
            pb = new PredmetPregled(o.Id, o.Naziv, o.Semestar, o.Katedra);

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }

        return pb;
    }

}
