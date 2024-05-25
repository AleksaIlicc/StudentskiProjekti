using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti;
public class DTOManager
{
    #region Predmeti

    public static List<PredmetPregled> VratiSvePredmete()
    {
        List<PredmetPregled> predmeti = new List<PredmetPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            predmeti = s.Query<Predmet>()
                        .OrderBy(p => p.Naziv)
                        .Select(p => new PredmetPregled(p.Id, p.Naziv, p.Semestar, p.Katedra))
                        .ToList();

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

            predmeti = s.Query<Predmet>()
                        .Where(p =>
                            (string.IsNullOrEmpty(semestarFilter) || p.Semestar.ToString() == semestarFilter) &&
                            (string.IsNullOrEmpty(katedraFilter) || p.Katedra.StartsWith(katedraFilter, StringComparison.OrdinalIgnoreCase)))
                        .OrderBy(p => p.Naziv)
                        .Select(p => new PredmetPregled(p.Id, p.Naziv, p.Semestar, p.Katedra))
                        .ToList();

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

    #region Studenti

    public static List<StudentPregled> VratiSveStudente()
    {
        List<StudentPregled> studenti = new List<StudentPregled>();
        try
        {
            ISession session = DataLayer.GetSession();

            studenti = session.Query<Student>()
                                .OrderBy(s => s.BrIndeksa)
                                .Select(s => new StudentPregled(s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer))
                                .ToList();

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

            studenti = session.Query<Student>()
                .Where(s => (string.IsNullOrEmpty(brIndeksa) || s.BrIndeksa.StartsWith(brIndeksa)) &&
                            (string.IsNullOrEmpty(ime) || s.LIme.StartsWith(ime)) &&
                            (string.IsNullOrEmpty(prezime) || s.Prezime.StartsWith(prezime)) &&
                            (string.IsNullOrEmpty(smer) || s.Smer.StartsWith(smer)))
                .Select(s => new StudentPregled(s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer))
                .ToList();

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

    public static List<ProjekatUcesceDetalji> VratiProjekteZaStudenta(string studentId)
    {
        List<ProjekatUcesceDetalji> projektiInfo = new List<ProjekatUcesceDetalji>();
        try
        {
            ISession s = DataLayer.GetSession();

            projektiInfo = s.Query<Ucestvuje>()
                            .Where(ucestvuje => ucestvuje.Student.BrIndeksa == studentId)
                            .Join(s.Query<Projekat>(),
                                  ucestvuje => ucestvuje.Projekat.Id,
                                  projekat => projekat.Id,
                                  (ucestvuje, projekat) => new ProjekatUcesceDetalji
                                  {
                                      IdProjekta = projekat.Id,
                                      NazivProjekta = projekat.Naziv,
                                      DatumPocetkaIzrade = ucestvuje.DatumPocetkaIzrade,
                                      DatumZavrsetkaIzrade = ucestvuje.DatumZavrsetka,
                                      RokZaZavrsetak = ucestvuje.RokZaZavrsetak,
                                      ProjekatZavrsen = ucestvuje.ProjekatZavrsen,
                                      VrstaProjekta = projekat.VrstaProjekta,
                                      NazivPredmeta = projekat.PripadaPredmetu.Naziv,
                                  })
                            .ToList();

            s.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return projektiInfo;
    }

    public static ProjekatUcesceDetalji VratiUcesceDetalji(string studentId, int projId)
    {
        ProjekatUcesceDetalji projektiInfo = new ProjekatUcesceDetalji();
        try
        {
            ISession s = DataLayer.GetSession();

            projektiInfo = s.Query<Ucestvuje>()
                            .Where(ucestvuje => ucestvuje.Student.BrIndeksa == studentId && ucestvuje.Projekat.Id == projId)
                            .Join(s.Query<Projekat>(),
                                  ucestvuje => ucestvuje.Projekat.Id,
                                  projekat => projekat.Id,
                                  (ucestvuje, projekat) => new ProjekatUcesceDetalji
                                  {
                                      IdProjekta = projekat.Id,
                                      NazivProjekta = projekat.Naziv,
                                      DatumPocetkaIzrade = ucestvuje.DatumPocetkaIzrade,
                                      DatumZavrsetkaIzrade = ucestvuje.DatumZavrsetka,
                                      RokZaZavrsetak = ucestvuje.RokZaZavrsetak,
                                      ProjekatZavrsen = ucestvuje.ProjekatZavrsen,
                                      VrstaProjekta = projekat.VrstaProjekta,
                                      DopunskaLiteratura = ucestvuje.DopunskaLiteratura,
                                      OdabranProgramskiJezik = ucestvuje.OdabranProgramskiJezik,
                                      UrlDokumentacijeProgJezika = ucestvuje.UrlDokumentacijeProgJezika
                                  })
                            .FirstOrDefault();

            s.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return projektiInfo;
    }

    public static List<StudentPregled> VratiStudenteNaProjektu(int idProjekta)
    {
        List<StudentPregled> studenti = new List<StudentPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            studenti = s.Query<Ucestvuje>().Where(p => p.Projekat.Id == idProjekta)
                            .Join(s.Query<Student>(),
                                  ucestvuje => ucestvuje.Student.BrIndeksa,
                                  student => student.BrIndeksa,
                                  (ucestvuje, student) => new StudentPregled
                                  {
                                      BrIndeksa = student.BrIndeksa,
                                      ImeRoditelja = student.ImeRoditelja,
                                      LIme = student.LIme,
                                      Prezime = student.Prezime,
                                      Smer = student.Smer
                                  })
                            .ToList();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return studenti;
    }

    public static int VratiBrPredIzvestajaNaGrupi(int projid)
    {
        int brojizv = 0;
        try
        {
            ISession s = DataLayer.GetSession();
            brojizv = s.Query<Predao>()
                        .Where(p => p.Projekat.Id == projid)
                        .Count();
            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return brojizv;
    }

    public static List<IzvestajPregled> VratiIzvestajeZaStudenta(string brIndkesa, int projekatID)
    {
        List<IzvestajPregled> izvestaji = new List<IzvestajPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            izvestaji = s.Query<Predao>()
                         .Where(p => p.Student.BrIndeksa == brIndkesa && p.Projekat.Id == projekatID)
                         .Join(s.Query<Izvestaj>(),
                             predao => predao.Izvestaj.Id,
                             izvestaj => izvestaj.Id,
                             (predao, izvestaj) => new IzvestajPregled
                             {
                                 Opis = izvestaj.Opis,
                                 DatumPredaje = izvestaj.DatumPredaje,
                                 Id = izvestaj.Id
                             })
                          .ToList();
            s.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return izvestaji;
    }

    public static void DodajUcesce(string brind, int projId, UcestvujePregled up)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Student stud = s.Load<Student>(brind);
            Projekat p = s.Load<Projekat>(projId);
            Ucestvuje ucesce = s.Query<Ucestvuje>()
                                .Where(p => p.Student.BrIndeksa == brind && p.Projekat.Id == projId)
                                .FirstOrDefault();

            if (ucesce != null)
            {
                return;
            }
            
            ucesce = new Ucestvuje()
            {
                DatumPocetkaIzrade = up.DatumPocetkaIzrade,
                DatumZavrsetka = up.DatumZavrsetka,
                RokZaZavrsetak = up.RokZaZavrsetak,
                OdabranProgramskiJezik = up.OdabranProgramskiJezik,
                UrlDokumentacijeProgJezika = up.UrlDokumentacijeProgJezika,
                DopunskaLiteratura = up.DopunskaLiteratura,
                Student = stud,
                Projekat = p,
            };

            ucesce.ProjekatZavrsen = ucesce.DatumZavrsetka.HasValue ? "da" : "ne";

            s.Save(ucesce);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void AzurirajUcesce(UcestvujePregled up)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Ucestvuje o = s.Load<Ucestvuje>(up.Id);

            o.RokZaZavrsetak = up.RokZaZavrsetak;
            o.DatumZavrsetka = up.DatumZavrsetka;
            o.DatumPocetkaIzrade = up.DatumPocetkaIzrade;
            o.OdabranProgramskiJezik = up.OdabranProgramskiJezik;
            o.UrlDokumentacijeProgJezika = up.UrlDokumentacijeProgJezika;
            o.DopunskaLiteratura = up.DopunskaLiteratura;

            o.ProjekatZavrsen = o.DatumZavrsetka.HasValue ? "da" : "ne";

            s.SaveOrUpdate(o);
            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static UcestvujePregled VratiUcesce(int projid , string studid)
    {
        UcestvujePregled up = null;
        try
        {   
            ISession s = DataLayer.GetSession();

            up = s.Query<Ucestvuje>()
                           .Where(p => p.Student.BrIndeksa == studid && p.Projekat.Id == projid)
                           .Select(o => new UcestvujePregled(
                               o.Id, 
                               o.DatumPocetkaIzrade, 
                               o.DatumZavrsetka,
                               o.RokZaZavrsetak, 
                               o.OdabranProgramskiJezik, 
                               o.UrlDokumentacijeProgJezika, 
                               o.DopunskaLiteratura)
                           )
                           .FirstOrDefault();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }

        return up;
    }

    public static void ObrisiUcesce(UcestvujePregled ucescep)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Ucestvuje ucesce = s.Load<Ucestvuje>(ucescep.Id);

            s.Delete(ucesce);

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

    public static ProjekatPregled VratiProjekat(int id)
    {
		ProjekatPregled projekatPregled = new ProjekatPregled();
		try
		{
			ISession s = DataLayer.GetSession();

            var projekat = s.Load<Projekat>(id);
            projekatPregled.Id = id;
            projekatPregled.TipProjekta = projekat.TipProjekta;
            projekatPregled.VrstaProjekta = projekat.VrstaProjekta;
            projekatPregled.SkolskaGodinaZadavanja = projekat.SkolskaGodinaZadavanja;
            projekatPregled.Naziv = projekat.Naziv;

			s.Close();
		}
		catch (Exception ec)
		{
			Console.WriteLine(ec);
		}

		return projekatPregled;
	}

	public static List<ProjekatPregled> VratiProjekteZaPredmet(string idPredmeta)
    {
        List<ProjekatPregled> projektiPregled = [];
        try
        {
            ISession s = DataLayer.GetSession();


            projektiPregled = s.Query<Projekat>()
                                .Where(p => p.PripadaPredmetu.Id == idPredmeta)
                                .OrderBy(p => p.SkolskaGodinaZadavanja)
                                .Select(p => new ProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta))
                                .ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projektiPregled;
    }

    public static List<ProjekatPregled> VratiSortiraneProjekteZaPredmet(string idPredmeta, string vrstaProjekta, string tipProjekta, string skolskaGodina)
    {
        List<ProjekatPregled> projektiPregled = [];
        try
        {
            ISession s = DataLayer.GetSession();

            projektiPregled = s.Query<Predmet>()
                .Where(p => p.Id == idPredmeta)
                .SelectMany(p => p.Projekti)
                .Where(pr => (string.IsNullOrEmpty(vrstaProjekta) || pr.VrstaProjekta == vrstaProjekta) &&
                                 (string.IsNullOrEmpty(tipProjekta) || pr.TipProjekta == tipProjekta) &&
                                 (string.IsNullOrEmpty(skolskaGodina) || pr.SkolskaGodinaZadavanja == skolskaGodina))
                .OrderBy(pr => pr.SkolskaGodinaZadavanja)
                .Select(p => new ProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta))
                .ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projektiPregled;
    }

    public static List<TeorijskiProjekatPregled> VratiSortiraneTProjekteZaPredmet(string idPredmeta, string tipProjekta, string skolskaGodina)
    {
        List<TeorijskiProjekatPregled> projektiPregled = [];
        try
        {
            ISession s = DataLayer.GetSession();



            projektiPregled = s.Query<TeorijskiProjekat>()
                             .Where(p => p.PripadaPredmetu.Id == idPredmeta
                                     && (string.IsNullOrEmpty(tipProjekta) || p.TipProjekta == tipProjekta)
                                     && (string.IsNullOrEmpty(skolskaGodina) || p.SkolskaGodinaZadavanja == skolskaGodina))
                             .Select(p=> new TeorijskiProjekatPregled { Id = p.Id, Naziv = p.Naziv, SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja, TipProjekta = p.TipProjekta, MaksBrojStrana = p.MaksBrojStrana })
                             .ToList();
            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projektiPregled;
    }

    public static List<PrakticniProjekatPregled> VratiSortiranePProjekteZaPredmet(string idPredmeta, string tipProjekta, string skolskaGodina)
    {
        List<PrakticniProjekatPregled> projektiPregled = [];
        try
        {
            ISession s = DataLayer.GetSession();



            var projekti = s.Query<PrakticniProjekat>()
                             .Where(p => p.PripadaPredmetu.Id == idPredmeta
                                     && (string.IsNullOrEmpty(tipProjekta) || p.TipProjekta == tipProjekta)
                                     && (string.IsNullOrEmpty(skolskaGodina) || p.SkolskaGodinaZadavanja == skolskaGodina))
                             .Select(p => new PrakticniProjekatPregled { 
                                 Id = p.Id, 
                                 Naziv = p.Naziv, 
                                 SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja, 
                                 TipProjekta = p.TipProjekta, 
                                 PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik }
                             )
                             .ToList();


            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projektiPregled;
    }

	public static List<PrakticniProjekatPregled> VratiPrakticneProjekteZaPredmet(string idPredmeta)
	{
		List<PrakticniProjekatPregled> projekti = [];
		try
		{
			ISession s = DataLayer.GetSession();

			projekti = s.Query<PrakticniProjekat>()
									  .Where(p => p.PripadaPredmetu.Id == idPredmeta)
									  .OrderBy(p => p.SkolskaGodinaZadavanja)
									  .Select(p => new PrakticniProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.PreporuceniProgramskiJezik))
									  .ToList();


			s.Close();
		}
		catch (Exception ec)
		{
			Console.WriteLine(ec);
		}

		return projekti;
	}

	public static List<TeorijskiProjekatPregled> VratiTeorijskeProjekteZaPredmet(string idPredmeta)
	{
		List<TeorijskiProjekatPregled> projekti = [];
		try
		{
			ISession s = DataLayer.GetSession();
			projekti = s.Query<TeorijskiProjekat>()
									  .Where(p => p.PripadaPredmetu.Id == idPredmeta)
									  .OrderBy(p => p.SkolskaGodinaZadavanja)
                                      .Select(p => new TeorijskiProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.MaksBrojStrana))
									  .ToList();

			s.Close();
		}
		catch (Exception ec)
		{
			Console.WriteLine(ec);
		}

		return projekti;
	}

	#endregion

	#region TeorijskiProjekti

	public static int DodajTeorijskiProjekat(TeorijskiProjekatPregled p)
    {
        int id = 0;
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet pred = s.Load<Predmet>(p.PripadaPredmetu.Id);

            TeorijskiProjekat o = new TeorijskiProjekat()
            {
                Naziv = p.Naziv,
                SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja,
                MaksBrojStrana = p.MaksBrojStrana,
                VrstaProjekta = p.VrstaProjekta,
                TipProjekta = p.TipProjekta,
                PripadaPredmetu = pred,
            };
            id = (int)s.Save(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return id;
    }

    public static void ObrisiTeorijskiProjekat(int id)
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

	public static void ObrisiUcesnikeTeorijskogProjekta(int id)
	{
		try
		{
			ISession s = DataLayer.GetSession();

			var ucestvujePojavljivanja = s.Query<Ucestvuje>()
							.Where(u => u.Projekat.Id == id)
							.ToList();

			foreach (var uPojavljivanje in ucestvujePojavljivanja)
			{
				s.Delete(uPojavljivanje);
			}

			s.Flush();

			s.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

	public static void AzurirajTeorijskiProjekat(TeorijskiProjekatPregled p)
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

    public static TeorijskiProjekatPregled VratiTeorijskiProjekat(int id)
    {
        TeorijskiProjekatPregled p = null;
        try
        {
            ISession s = DataLayer.GetSession();

            TeorijskiProjekat o = s.Load<TeorijskiProjekat>(id);
            p = new TeorijskiProjekatPregled(o.Id, o.Naziv, o.SkolskaGodinaZadavanja, o.TipProjekta, o.MaksBrojStrana);

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }

        return p;
    }

    #region Literatura

    public static void DodajAutora(int idLiterature, string nazivAutora)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Literatura lit = s.Load<Literatura>(idLiterature);

            LitAutor la = new LitAutor { Autor = nazivAutora, Literatura = lit };

            lit.Autori.Add(la);

            s.Save(lit);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static List<LiteraturaPregled> VratiSveLiterature()
    {
        List<LiteraturaPregled> sveLiterature = [];
        try
        {
            ISession s = DataLayer.GetSession();
            sveLiterature = s.Query<Literatura>()
                            .OrderBy(l => l.Naziv)
                             .Select(l => new LiteraturaPregled
                             {
                                 Naziv = l.Naziv,
                                 Id = l.LitId
                             })
                            .ToList();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return sveLiterature;
    }

    public static List<LiteraturaPregled> VratiPretrazeneLiterature(string search)
    {
        List<LiteraturaPregled> pretrazeneLiterature = [];
        try
        {
            ISession s = DataLayer.GetSession();
            pretrazeneLiterature = s.Query<Literatura>()
                                    .Where(lit => lit.Naziv.ToLower().Contains(search.ToLower()))
                                    .OrderBy(l => l.Naziv)
                                    .Select(l => new LiteraturaPregled
                                    {
                                        Naziv = l.Naziv,
                                        Id = l.LitId
                                    })
                                    .ToList();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return pretrazeneLiterature;
    }

    public static List<AutorPregled> VratiAutoreZaLiteraturu(int id)
    {
        List<AutorPregled> sviAutori = [];
        try
        {
            ISession s = DataLayer.GetSession();
            sviAutori = s.Query<LitAutor>()
                            .Where(a => a.Literatura.LitId == id)
                            .Select(a => new AutorPregled(a.Autor))
                            .ToList();
            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return sviAutori;
    }

    public static void DodajLiteraturuZaProjekat(int projekatId, int literaturaId)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            var lit = s.Load<Literatura>(literaturaId);
            var tproj = s.Load<TeorijskiProjekat>(projekatId);

            var postojeciSadrzi = s.Query<Sadrzi>()
                .Where(x => x.Literatura.LitId == literaturaId && x.TProjekat.Id == projekatId)
                .SingleOrDefault();

            if (postojeciSadrzi == null)
            {
                Sadrzi sadrzi = new Sadrzi { Literatura = lit, TProjekat = tproj };
                s.Save(sadrzi);
                s.Flush();
            }

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void ObrisiLiteraturu(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            var sadrziPojavljivanja = s.Query<Sadrzi>()
                                    .Where(x => x.Literatura.LitId == id)
                                    .ToList();

            foreach (var pojavljivanje in sadrziPojavljivanja)
            {
                s.Delete(pojavljivanje);
            }

            var literatura = s.Load<Literatura>(id);

            s.Delete(literatura);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #region Knjiga

    public static List<KnjigaPregled> VratiSveKnjigeZaTProj(int teorijskiProjekatId)
    {
        List<KnjigaPregled> knjige = [];
        try
        {
            ISession s = DataLayer.GetSession();

            knjige = s.Query<Sadrzi>()
                .Where(p => p.TProjekat.Id == teorijskiProjekatId)
                .Join(s.Query<Knjiga>(),
                sadrzi => sadrzi.Literatura.LitId,
                knjiga => knjiga.Literatura.LitId,
                (sadrzi, knjiga) => new KnjigaPregled
                {
                    Naziv = knjiga.Literatura.Naziv,
                    GodinaIzdanja = knjiga.GodinaIzdanja,
                    Izdavac = knjiga.Izdavac,
                    ISBN = knjiga.ISBN
                }
                ).ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return knjige;
    }

    public static List<AutorPregled> VratiAutoreZaKnjigu(string isbn)
    {
        List<AutorPregled> autori = [];
        try
        {
            ISession s = DataLayer.GetSession();
            var knjiga = s.Load<Knjiga>(isbn);
            autori = s.Query<LitAutor>()
                                      .Where(p => p.Literatura.LitId == knjiga.Literatura.LitId)
                                      .Select(la => new AutorPregled(la.Autor))
                                      .ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return autori;
    }

    public static int VratiIdLiteratureKnjige(string isbn)
    {
        int idLiterature = 0;
        try
        {
            ISession s = DataLayer.GetSession();
            var knjiga = s.Load<Knjiga>(isbn);
            idLiterature = s.Query<Literatura>()
                            .Where(p => p.LitId == knjiga.Literatura.LitId)
                            .Select(l => l.LitId)
                            .FirstOrDefault();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return idLiterature;
    }

    public static void ObrisiKnjigu(int projekatId, string isbn)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Knjiga o = s.Load<Knjiga>(isbn);
            var sadrzi = s.Query<Sadrzi>()
                .Where(x => x.Literatura.LitId == o.Literatura.LitId && projekatId == x.TProjekat.Id)
                .FirstOrDefault();

            s.Delete(sadrzi);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void ObrisiAutoraKnjige(string isbn, string nazivAutora)
    {
        try
        {
            ISession s = DataLayer.GetSession();
            var knjiga = s.Load<Knjiga>(isbn);
            LitAutor la = s.Query<LitAutor>()
                            .Where(p => p.Autor == nazivAutora && p.Literatura.LitId == knjiga.Literatura.LitId)
                            .FirstOrDefault();

            s.Delete(la);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void DodajKnjigu(int tProjekatId, KnjigaPregled p, List<AutorPregled> autori)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Literatura lit = new Literatura { Naziv = p.Naziv };

            List<LitAutor> listaAutora = new List<LitAutor>();
            foreach (AutorPregled ap in autori)
            {
                listaAutora.Add(new LitAutor() { Autor = ap.Autor, Literatura = lit });
            }
            lit.Autori = listaAutora;

            Knjiga r = new Knjiga()
            {
                ISBN = p.ISBN,
                Izdavac = p.Izdavac,
                GodinaIzdanja = p.GodinaIzdanja,
                Literatura = lit
            };

            lit.Knjiga = r;

            s.Save(lit);

            Sadrzi sadrzi = new Sadrzi()
            {
                Literatura = lit,
                TProjekat = s.Load<TeorijskiProjekat>(tProjekatId)
            };

            s.Save(sadrzi);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static KnjigaPregled VratiKnjigu(string isbn)
    {
        KnjigaPregled knjiga = null;
        try
        {
            ISession s = DataLayer.GetSession();

            knjiga = s.Query<Knjiga>()
                         .Select(k => new KnjigaPregled(k.Literatura.Naziv, k.ISBN, k.Izdavac, k.GodinaIzdanja))
                         .FirstOrDefault(k => k.ISBN == isbn);

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return knjiga;
    }

    private static void AzurirajKnjigu(KnjigaPregled knjigaPregled, ISession s)
    {
        Knjiga knjiga = s.Load<Knjiga>(knjigaPregled.ISBN);
        knjiga.Izdavac = knjigaPregled.Izdavac;
        knjiga.GodinaIzdanja = knjigaPregled.GodinaIzdanja;
        knjiga.Literatura.Naziv = knjigaPregled.Naziv;

        s.SaveOrUpdate(knjiga);
    }

    private static void AzurirajAutoreKnjige(string isbn, List<AutorPregled> azuriraniAutori, ISession s)
    {
        var knjiga = s.Load<Knjiga>(isbn);
        var lit = knjiga.Literatura;

        foreach (var postojeciAutori in lit.Autori.ToList())
        {
            s.Delete(postojeciAutori);
        }

        List<LitAutor> autori = new List<LitAutor>();
        foreach (var autorPregled in azuriraniAutori)
        {
            autori.Add(new LitAutor() { Autor = autorPregled.Autor, Literatura = lit });
        }

        lit.Autori = autori;

        s.Update(lit);
    }

    public static void AzurirajKnjiguSaAutorima(KnjigaPregled knjigaPregled, List<AutorPregled> azuriraniAutori)
    {
        try
        {
            using ISession s = DataLayer.GetSession();
            using ITransaction t = s.BeginTransaction();
            try
            {
                AzurirajKnjigu(knjigaPregled, s);
                AzurirajAutoreKnjige(knjigaPregled.ISBN, azuriraniAutori, s);

                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine(ex.Message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #endregion

    #region Rad

    public static List<RadPregled> VratiSveRadoveZaTProj(int teorijskiProjekatId)
    {
        List<RadPregled> radovi = new List<RadPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            radovi = s.Query<Sadrzi>()
                .Where(p => p.TProjekat.Id == teorijskiProjekatId)
                .Join(s.Query<Rad>(),
                sadrzi => sadrzi.Literatura.LitId,
                rad => rad.Literatura.LitId,
                (sadrzi, rad) => new RadPregled
                {
                    Format = rad.Format,
                    Naziv = rad.Literatura.Naziv,
                    Url = rad.Url,
                    KonferencijaObjavljivanja = rad.KonferencijaObjavljivanja,
                    Id = rad.Id
                }
                ).ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return radovi;
    }

    public static List<AutorPregled> VratiAutoreZaRad(int id)
    {
        List<AutorPregled> autori = [];
        try
        {
            ISession s = DataLayer.GetSession();
            var rad = s.Load<Rad>(id);
            autori = s.Query<LitAutor>()
                                      .Where(p => p.Literatura.LitId == rad.Literatura.LitId)
                                      .Select(la => new AutorPregled(la.Autor))
                                      .ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return autori;
    }

    public static void ObrisiRad(int projekatId, int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Rad o = s.Load<Rad>(id);
            var sadrzi = s.Query<Sadrzi>()
                .Where(x => x.Literatura.LitId == o.Literatura.LitId && projekatId == x.TProjekat.Id)
                .FirstOrDefault();

            s.Delete(sadrzi);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static int VratiIdLiteratureRada(int id)
    {
        int idLiterature = 0;
        try
        {
            ISession s = DataLayer.GetSession();
            var rad = s.Load<Rad>(id);
            idLiterature = s.Query<Literatura>()
                            .Where(p => p.LitId == rad.Literatura.LitId)
                            .Select(l => l.LitId)
                            .FirstOrDefault();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return idLiterature;
    }

    public static void ObrisiAutoraRada(int id, string nazivAutora)
    {
        try
        {
            ISession s = DataLayer.GetSession();
            var rad = s.Load<Rad>(id);
            LitAutor la = s.Query<LitAutor>()
                .Where(p => (p.Autor == nazivAutora && p.Literatura.LitId == rad.Literatura.LitId))
                .FirstOrDefault();

            s.Delete(la);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void DodajRad(int tProjekatId, RadPregled p, List<AutorPregled> autori)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Literatura lit = new Literatura { Naziv = p.Naziv };

            List<LitAutor> listaAutora = new List<LitAutor>();
            foreach (AutorPregled ap in autori)
            {
                listaAutora.Add(new LitAutor() { Autor = ap.Autor, Literatura = lit });
            }
            lit.Autori = listaAutora;

            Rad r = new Rad()
            {
                Url = p.Url,
                Format = p.Format,
                KonferencijaObjavljivanja = p.KonferencijaObjavljivanja,
                Literatura = lit
            };

            lit.Rad = r;

            s.Save(lit);

            Sadrzi sadrzi = new Sadrzi()
            {
                Literatura = lit,
                TProjekat = s.Load<TeorijskiProjekat>(tProjekatId)
            };

            s.Save(sadrzi);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static RadPregled VratiRad(int id)
    {
        RadPregled radPregled = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Rad rad = s.Load<Rad>(id);

            radPregled = new RadPregled(rad.Id, rad.Literatura.Naziv, rad.Url, rad.KonferencijaObjavljivanja, rad.Format);

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return radPregled;
    }

    private static void AzurirajRad(RadPregled radPregled, ISession s)
    {
        Rad rad = s.Load<Rad>(radPregled.Id);
        rad.Format = radPregled.Format;
        rad.KonferencijaObjavljivanja = radPregled.KonferencijaObjavljivanja;
        rad.Url = radPregled.Url;
        rad.Literatura.Naziv = radPregled.Naziv;

        s.SaveOrUpdate(rad);
    }

    private static void AzurirajAutoreRada(int id, List<AutorPregled> azuriraniAutori, ISession s)
    {
        var rad = s.Load<Rad>(id);
        var lit = rad.Literatura;

        foreach (var postojeciAutori in lit.Autori.ToList())
        {
            s.Delete(postojeciAutori);
        }

        List<LitAutor> autori = new List<LitAutor>();
        foreach (var autorPregled in azuriraniAutori)
        {
            autori.Add(new LitAutor() { Autor = autorPregled.Autor, Literatura = lit });
        }

        lit.Autori = autori;

        s.Update(lit);
    }

    public static void AzurirajRadSaAutorima(RadPregled radPregled, List<AutorPregled> azuriraniAutori)
    {
        try
        {
            using ISession s = DataLayer.GetSession();
            using ITransaction t = s.BeginTransaction();
            try
            {
                AzurirajRad(radPregled, s);
                AzurirajAutoreRada(radPregled.Id, azuriraniAutori, s);

                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine(ex.Message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #endregion

    #region ClanakUCaspisu

    public static List<ClanakUCasopisuPregled> VratiSveClankeZaTProj(int teorijskiProjekatId)
    {
        List<ClanakUCasopisuPregled> clanci = [];
        try
        {
            ISession s = DataLayer.GetSession();

            clanci = s.Query<Sadrzi>()
                .Where(p => p.TProjekat.Id == teorijskiProjekatId)
                .Join(s.Query<ClanakUCasopisu>(),
                sadrzi => sadrzi.Literatura.LitId,
                clanak => clanak.Literatura.LitId,
                (sadrzi, clanak) => new ClanakUCasopisuPregled
                {
                    ISSN = clanak.ISSN,
                    Broj = clanak.Broj,
                    Godina = clanak.Godina,
                    ImeCasopisa = clanak.ImeCasopisa,
                    Naziv = clanak.Literatura.Naziv,
                }
                ).ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return clanci;
    }

    public static void ObrisiClanak(int projekatId, string issn)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            ClanakUCasopisu o = s.Load<ClanakUCasopisu>(issn);

            var sadrzi = s.Query<Sadrzi>()
                            .Where(x => x.Literatura.LitId == o.Literatura.LitId && projekatId == x.TProjekat.Id)
                            .FirstOrDefault();

            s.Delete(sadrzi);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void ObrisiAutoraClanka(string issn, string nazivAutora)
    {
        try
        {
            ISession s = DataLayer.GetSession();
            var clanak = s.Load<ClanakUCasopisu>(issn);
            LitAutor la = s.Query<LitAutor>()
                            .Where(p => (p.Autor == nazivAutora && p.Literatura.LitId == clanak.Literatura.LitId))
                            .FirstOrDefault();

            s.Delete(la);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static int VratiIdLiteratureClanka(string issn)
    {
        int idLiterature = 0;
        try
        {
            ISession s = DataLayer.GetSession();
            var clanak = s.Load<ClanakUCasopisu>(issn);
            idLiterature = s.Query<Literatura>()
                            .Where(p => p.LitId == clanak.Literatura.LitId)
                            .Select(l => l.LitId)
                            .FirstOrDefault();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return idLiterature;
    }

    public static void DodajClanak(int tProjekatId, ClanakUCasopisuPregled p, List<AutorPregled> autori)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Literatura lit = new Literatura { Naziv = p.Naziv };

            List<LitAutor> listaAutora = new List<LitAutor>();
            foreach (AutorPregled ap in autori)
            {
                listaAutora.Add(new LitAutor() { Autor = ap.Autor, Literatura = lit });
            }
            lit.Autori = listaAutora;

            ClanakUCasopisu r = new ClanakUCasopisu()
            {
                ImeCasopisa = p.ImeCasopisa,
                ISSN = p.ISSN,
                Broj = p.Broj,
                Godina = p.Godina,
                Literatura = lit
            };

            lit.ClanakUCasopisu = r;
            s.Save(lit);

            Sadrzi sadrzi = new Sadrzi()
            {
                Literatura = lit,
                TProjekat = s.Load<TeorijskiProjekat>(tProjekatId)
            };

            s.Save(sadrzi);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static List<AutorPregled> VratiAutoreZaClanak(string issn)
    {
        List<AutorPregled> autori = [];
        try
        {
            ISession s = DataLayer.GetSession();
            var clanak = s.Load<ClanakUCasopisu>(issn);
            autori = s.Query<LitAutor>()
                                      .Where(p => p.Literatura.LitId == clanak.Literatura.LitId)
                                      .Select(la => new AutorPregled(la.Autor))
                                      .ToList();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return autori;
    }

    public static ClanakUCasopisuPregled VratiClanak(string issn)
    {
        ClanakUCasopisuPregled clanak = null;
        try
        {
            ISession s = DataLayer.GetSession();

            clanak = s.Query<ClanakUCasopisu>()
                                            .Select(c => new ClanakUCasopisuPregled(c.Literatura.Naziv, c.ISSN, c.ImeCasopisa, c.Broj, c.Godina))
                                            .FirstOrDefault(c => c.ISSN == issn);

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return clanak;
    }

    private static void AzurirajClanak(ClanakUCasopisuPregled clanakPregled, ISession s)
    {
        ClanakUCasopisu clanak = s.Load<ClanakUCasopisu>(clanakPregled.ISSN);
        clanak.Broj = clanakPregled.Broj;
        clanak.ImeCasopisa = clanakPregled.ImeCasopisa;
        clanak.Literatura.Naziv = clanakPregled.Naziv;
        clanak.Godina = clanakPregled.Godina;

        s.SaveOrUpdate(clanak);
    }

    private static void AzurirajAutoreClanka(string issn, List<AutorPregled> azuriraniAutori, ISession s)
    {
        var clanak = s.Load<ClanakUCasopisu>(issn);
        var lit = clanak.Literatura;

        foreach (var postojeciAutori in lit.Autori.ToList())
        {
            s.Delete(postojeciAutori);
        }

        List<LitAutor> autori = new List<LitAutor>();
        foreach (var autorPregled in azuriraniAutori)
        {
            autori.Add(new LitAutor() { Autor = autorPregled.Autor, Literatura = lit });
        }

        lit.Autori = autori;

        s.Update(lit);
    }

    public static void AzurirajClanakSaAutorima(ClanakUCasopisuPregled clanakPregled, List<AutorPregled> azuriraniAutori)
    {
        try
        {
            using ISession s = DataLayer.GetSession();
            using ITransaction t = s.BeginTransaction();
            try
            {
                AzurirajClanak(clanakPregled, s);
                AzurirajAutoreClanka(clanakPregled.ISSN, azuriraniAutori, s);

                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine(ex.Message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #endregion

    #endregion

    #endregion

    #region PrakticniProjekti

    public static string VratiOpisPrakticnogProjekta(int idProjekta)
    {
        string kratakOpis = null;
        try
        {
            ISession s = DataLayer.GetSession();

            kratakOpis = s.Query<PrakticniProjekat>()
                                      .Where(p => p.Id == idProjekta)
                                      .Select(p => p.KratakOpis)
                                      .FirstOrDefault();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return kratakOpis;
    }

    public static List<PreporucenaWebStranicaPregled> VratiPreporuceneWebStranicePProjekta(int idProjekta)
    {
        List<PreporucenaWebStranicaPregled> webStranice = [];
        try
        {
            ISession s = DataLayer.GetSession();

            webStranice = s.Query<PProjektiWebStranice>()
                                      .Where(p => p.PProjekat.Id == idProjekta)
                                      .OrderBy(p => p.PreporucenaWebStrana)
                                      .Select(ws => new PreporucenaWebStranicaPregled(ws.PreporucenaWebStrana))
                                      .ToList();


            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return webStranice;
    }

    public static void DodajPrakticniProjekat(PrakticniProjekatPregled p, List<PreporucenaWebStranicaPregled> stranice)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet pred = s.Load<Predmet>(p.PripadaPredmetu.Id);

            PrakticniProjekat o = new PrakticniProjekat()
            {
                Naziv = p.Naziv,
                SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja,
                PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik,
                VrstaProjekta = p.VrstaProjekta,
                TipProjekta = p.TipProjekta,
                KratakOpis = p.KratakOpis,
                PripadaPredmetu = pred
            };

            List<PProjektiWebStranice> prepStranice = [];

            foreach (var stranica in stranice)
            {
                prepStranice.Add(new PProjektiWebStranice() { PreporucenaWebStrana = stranica.Naziv, PProjekat = o });
            }

            o.PreporuceneWebStranice = prepStranice;

            s.Save(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void ObrisiUcesnikePrakticnogProjekta(int id)
    {
		try
		{
			ISession s = DataLayer.GetSession();

            var ucestvujePojavljivanja = s.Query<Ucestvuje>()
                            .Where(u => u.Projekat.Id == id)
                            .ToList();

            foreach(var uPojavljivanje in ucestvujePojavljivanja)
            {
                s.Delete(uPojavljivanje);
            }

            var izvestajiPojavljivanja = s.Query<Predao>()
                                    .Where(s => s.Projekat.Id == id)
                                    .ToList();

			foreach (var iPojavljivanje in izvestajiPojavljivanja)
			{
				s.Delete(iPojavljivanje);
			}

			s.Flush();

			s.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

	public static void ObrisiPrakticniProjekat(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            PrakticniProjekat o = s.Load<PrakticniProjekat>(id);

            s.Delete(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void AzurirajPrakticniProjekat(PrakticniProjekatPregled p, ISession s)
    {
        PrakticniProjekat o = s.Load<PrakticniProjekat>(p.Id);
        o.Naziv = p.Naziv;
        o.SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja;
        o.PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik;
        o.TipProjekta = p.TipProjekta;
        o.KratakOpis = p.KratakOpis;

        s.SaveOrUpdate(o);
    }

    private static void AzurirajStranicePrakticnogProjekta(int id, List<PreporucenaWebStranicaPregled> stranice, ISession s)
    {
        var projekat = s.Load<PrakticniProjekat>(id);

        foreach (var postojecaStranica in projekat.PreporuceneWebStranice)
        {
            s.Delete(postojecaStranica);
        }

        List<PProjektiWebStranice> noveStranice = [];
        foreach (var stranica in stranice)
        {
            noveStranice.Add(new PProjektiWebStranice() { PreporucenaWebStrana = stranica.Naziv, PProjekat = projekat });
        }

        projekat.PreporuceneWebStranice = noveStranice;

        s.Update(projekat);
    }

    public static void AzurirajPrakticniProjekatSaStranicama(PrakticniProjekatPregled p, List<PreporucenaWebStranicaPregled> stranice)
    {
        try
        {
            using ISession s = DataLayer.GetSession();
            using ITransaction t = s.BeginTransaction();
            try
            {
                AzurirajPrakticniProjekat(p, s);
                AzurirajStranicePrakticnogProjekta(p.Id, stranice, s);

                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine(ex.Message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static PrakticniProjekatPregled VratiPrakticniProjekat(int id)
    {
        PrakticniProjekatPregled p = null;
        try
        {
            ISession s = DataLayer.GetSession();

            PrakticniProjekat o = s.Load<PrakticniProjekat>(id);
            p = new PrakticniProjekatPregled(o.Id, o.Naziv, o.SkolskaGodinaZadavanja, o.TipProjekta, o.PreporuceniProgramskiJezik);

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }

        return p;
    }

    public static void DodajPreporucenuWebStranicuZaProjekat(int idProjekta, string nazivWebStranice)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            PrakticniProjekat pProjekat = s.Load<PrakticniProjekat>(idProjekta);

            PProjektiWebStranice novaWebStranica = new PProjektiWebStranice()
            {
                PreporucenaWebStrana = nazivWebStranice,
                PProjekat = pProjekat
            };

            s.Save(novaWebStranica);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void ObrisiPreporucenuWebStranicuZaProjekat(int idProjekta, string nazivWebStranice)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            PProjektiWebStranice stranica = s.Query<PProjektiWebStranice>()
                                        .FirstOrDefault(p => p.PProjekat.Id == idProjekta && p.PreporucenaWebStrana == nazivWebStranice);

            s.Delete(stranica);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #region Izvestaj

    public static void DodajIzvestaj(int prakProjId, string studBrInd, IzvestajPregled izvesPreg)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            PrakticniProjekat pp = s.Load<PrakticniProjekat>(prakProjId);
            Student st = s.Load<Student>(studBrInd);

            Izvestaj iz = new Izvestaj()
            {
                Opis = izvesPreg.Opis,
                DatumPredaje = izvesPreg.DatumPredaje,
            };

            Predao pred = new Predao()
            {
                Student = st,
                Projekat = pp,
                Izvestaj = iz
            };

            iz.PredaoIzvestaj = pred;

            s.Save(iz);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void AzurirajIzvestaj(IzvestajPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Izvestaj o = s.Load<Izvestaj>(p.Id);
            o.Opis = p.Opis;
            o.DatumPredaje = p.DatumPredaje;

            s.SaveOrUpdate(o);
            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static IzvestajPregled VratiIzvestaj(int Id_Izvestaj)
    {
        IzvestajPregled ip = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Izvestaj izvestaj = s.Load<Izvestaj>(Id_Izvestaj);

            ip = new IzvestajPregled()
            {
                Opis = izvestaj.Opis,
                DatumPredaje = izvestaj.DatumPredaje,
                Id = izvestaj.Id,
            };

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return ip;
    }

    public static void ObrisiIzvestaj(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Izvestaj o = s.Load<Izvestaj>(id);

            s.Delete(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    #endregion

    #endregion
}
