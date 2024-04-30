using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti;
public class DTOManager
{
    public static List<PredmetPregled> VratiSvePredmete()
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

    public static void DodajPredmet(PredmetPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet o = new Predmet()
            {
				Id = p.Id,
			    Naziv = p.Naziv,
			    Katedra = p.Katedra,
			    Semestar = p.Semestar
		    };

            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }
    }
    public static void ObrisiPredmet(string id)
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
    public static PredmetPregled AzurirajPredmet(PredmetPregled p)
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

    public static PredmetPregled VratiPredmet(string id)
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


    #region Projekti

    public static List<ProjekatPregled> VratiProjekteZaPredmet(string idPredmeta)
    {
        List<ProjekatPregled> projekti = new List<ProjekatPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

   
            Predmet predmet = s.Query<Predmet>().FirstOrDefault(p => p.Id == idPredmeta);

            if (predmet != null)
            {
                IList<Projekat> projektiZaPredmet = predmet.Projekti;

                foreach (Projekat p in projektiZaPredmet)
                {
                    projekti.Add(new ProjekatPregled(p.Naziv, p.SkolskaGodinaZadavanja,  p.VrstaProjekta, p.TipProjekta));
                }
            }
            else
            {
                Console.WriteLine("Predmet nije pronađen.");
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projekti;
    }



    #endregion

}
