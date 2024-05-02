using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti;
public class DTOManager
{
    #region Predmet
    public static List<PredmetPregled> VratiSvePredmete()
    {
        List<PredmetPregled> predmeti = new List<PredmetPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IList<Predmet> sviPredmeti = s.Query<Predmet>().ToList();

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

    public static List<PredmetPregled> VratiSortiranePredmete(string semestarFilter, string katedraFilter)
    {
        List<PredmetPregled> predmeti = new List<PredmetPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IList<Predmet> sviPredmeti = s.Query<Predmet>().Where(p =>
                (string.IsNullOrEmpty(semestarFilter) || p.Semestar.ToString() == semestarFilter) &&
                (string.IsNullOrEmpty(katedraFilter) || p.Katedra.StartsWith(katedraFilter, StringComparison.OrdinalIgnoreCase))
            )
            .OrderBy(p => p.Naziv)
            .ToList();

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

            s.Save(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
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
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void AzurirajPredmet(PredmetPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet o = s.Load<Predmet>(p.Id);
            o.Id = p.Id;
            o.Naziv = p.Naziv;
            o.Katedra = p.Katedra;
            o.Semestar = p.Semestar;


            s.SaveOrUpdate(o);
            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static PredmetPregled VratiPredmet(string id)
    {
        PredmetPregled pb = null;
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
    #endregion

    #region Student

    public static List<StudentPregled> VratiSveStudente()
    {
        List<StudentPregled> studenti = new List<StudentPregled>();
        try
        {
            ISession session = DataLayer.GetSession();

            IList<Student> sviStudenti = session.Query<Student>().ToList();

            foreach (Student s in sviStudenti)
            {
                studenti.Add(new StudentPregled(s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer));
            }

            session.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return studenti;
    }

    public static List<StudentPregled> VratiSortiraneStudente(string brIndeksa, string ime, string prezime, string smer)
    {
        List<StudentPregled> studenti = new List<StudentPregled>();
        try
        {
            ISession session = DataLayer.GetSession();

            IList<Student> sviStudenti = session.Query<Student>()
                .Where(s => (string.IsNullOrEmpty(brIndeksa) || s.BrIndeksa.StartsWith(brIndeksa)) &&
                            (string.IsNullOrEmpty(ime) || s.LIme.StartsWith(ime)) &&
                            (string.IsNullOrEmpty(prezime) || s.Prezime.StartsWith(prezime)) &&
                            (string.IsNullOrEmpty(smer) || s.Smer.StartsWith(smer)))
                .ToList();

            foreach (Student s in sviStudenti)
            {
                studenti.Add(new StudentPregled(s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer));
            }

            session.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return studenti;
    }

    public static void DodajStudenta(StudentPregled sp)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Student student = new Student()
            {
                BrIndeksa = sp.BrIndeksa,
                LIme = sp.LIme,
                Prezime = sp.Prezime,
                ImeRoditelja = sp.ImeRoditelja,
                Smer = sp.Smer
            };

            s.Save(student);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void ObrisiStudenta(string brIndeksa)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Student student = s.Load<Student>(brIndeksa);

            s.Delete(student);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static StudentPregled VratiStudenta(string brIndeksa)
    {
        StudentPregled sp = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Student student = s.Load<Student>(brIndeksa);

            sp = new StudentPregled()
            {
                BrIndeksa = student.BrIndeksa,
                ImeRoditelja = student.ImeRoditelja,
                LIme = student.LIme,
                Prezime = student.Prezime,
                Smer = student.Smer
            };

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return sp;
    }

    public static void AzurirajStudenta(StudentPregled sp)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Student o = s.Load<Student>(sp.BrIndeksa);
            o.LIme = sp.LIme;
            o.ImeRoditelja = sp.ImeRoditelja;
            o.Prezime = sp.Prezime;
            o.Smer = sp.Smer;

            s.SaveOrUpdate(o);
            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #endregion

    #region Projekti

    public static List<ProjekatPregled> VratiProjekteZaPredmet(string idPredmeta)
    {
        List<ProjekatPregled> projektiPregled = new List<ProjekatPregled>();
        try
        {
            ISession s = DataLayer.GetSession();


            IList<Projekat> projekti = s.Query<Projekat>().Where(p => p.PripadaPredmetu.Id == idPredmeta).OrderBy(p=>p.SkolskaGodinaZadavanja).ToList();


            foreach (Projekat p in projekti)
            {
                projektiPregled.Add(new ProjekatPregled(p.Id ,p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projektiPregled;
    }
    public static IList<ProjekatPregled> VratiSortiraneProjekteZaPredmet(string idPredmeta, string vrstaProjekta, string tipProjekta, string skolskaGodina)
    {
        IList<ProjekatPregled> projektiFinal = new List<ProjekatPregled>();
        try
        {
            ISession s = DataLayer.GetSession();


            IList<Projekat> projekti = s.Query<Predmet>()
                .Where(p => p.Id == idPredmeta)
                .SelectMany(p => p.Projekti)
                .Where(pr => (string.IsNullOrEmpty(vrstaProjekta) || pr.VrstaProjekta == vrstaProjekta) &&
                                 (string.IsNullOrEmpty(tipProjekta) || pr.TipProjekta == tipProjekta) &&
                                 (string.IsNullOrEmpty(skolskaGodina) || pr.SkolskaGodinaZadavanja == skolskaGodina))
                .OrderBy(pr => pr.SkolskaGodinaZadavanja)
                .ToList();


            foreach (Projekat p in projekti)
            {
                projektiFinal.Add(new ProjekatPregled(p.Id , p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projektiFinal;
    }


    #endregion

    #region TeorijskiProjekti

    public static List<TeorijskiProjekatPregled> VratiTeorijskeProjekteZaPredmet(string idPredmeta)
    {
        List<TeorijskiProjekatPregled> projekti = new List<TeorijskiProjekatPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            var teorijskiProjekti = s.Query<TeorijskiProjekat>()
                                      .Where(p => p.PripadaPredmetu.Id == idPredmeta)
                                      .ToList();

            foreach (TeorijskiProjekat p in teorijskiProjekti)
            {

                projekti.Add(new TeorijskiProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.MaksBrojStrana));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projekti;
    }

    public static void DodajTeorijskiProjekat(string id , string naziv , int semestar, string katedra , TeorijskiProjekatPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet pred = new Predmet
            {
                Id = id,
                Naziv = naziv,
                Semestar = semestar,
                Katedra = katedra,
            };

            TeorijskiProjekat o = new TeorijskiProjekat()
            {

                Naziv = p.Naziv,
                SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja,
                MaksBrojStrana = p.MaksBrojStrana,
                VrstaProjekta = p.VrstaProjekta,
                TipProjekta = p.TipProjekta,
                PripadaPredmetu = pred,
            };
            s.Save(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void ObrisiTeorijskiProjekat(string id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            TeorijskiProjekat o = s.Load<TeorijskiProjekat>(id);

            s.Delete(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void AzurirajTeorijskiProjekat(TeorijskiProjekat p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            TeorijskiProjekat o = s.Load<TeorijskiProjekat>(p.Id);
            o.Naziv = p.Naziv;
            o.SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja;
            o.MaksBrojStrana = p.MaksBrojStrana;
            o.TipProjekta = p.TipProjekta;


            s.SaveOrUpdate(o);
            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    #endregion

    #region PrakticniProjekti
    public static List<PrakticniProjekatPregled> VratiPrakticneProjekteZaPredmet(string idPredmeta)
    {
        List<PrakticniProjekatPregled> projekti = new List<PrakticniProjekatPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            var prakticniProjekti = s.Query<PrakticniProjekat>()
                                      .Where(p => p.PripadaPredmetu.Id == idPredmeta)
									  .OrderBy(p => p.SkolskaGodinaZadavanja)
									  .ToList();

            foreach (PrakticniProjekat p in prakticniProjekti)
            {

                projekti.Add(new PrakticniProjekatPregled(p.Id ,p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.PreporuceniProgramskiJezik));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projekti;
    }

	public static string VratiOpisPrakticnogProjekta(int idProjekta)
    {
        string kratakOpis = null;
		try
		{
			ISession s = DataLayer.GetSession();

            var prakticniProjekat = s.Query<PrakticniProjekat>()
                                      .Where(p => p.Id == idProjekta)
                                      .FirstOrDefault();
            kratakOpis = prakticniProjekat.KratakOpis;

			s.Close();
		}
		catch (Exception ec)
		{
			Console.WriteLine(ec);
		}

		return kratakOpis;
	}

	#endregion
}
