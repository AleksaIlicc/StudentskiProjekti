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

			IList<Predmet> sviPredmeti = s.Query<Predmet>().ToList() ;

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
				studenti.Add(new StudentPregled(s.BrIndeksa,s.LIme,s.ImeRoditelja,s.Prezime,s.Smer));
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
            o.ImeRoditelja= sp.ImeRoditelja;
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
