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

            IList<Predmet> sviPredmeti = s.Query<Predmet>().OrderBy(p => p.Naziv).ToList();

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

            IList<Student> sviStudenti = session.Query<Student>().OrderBy(s => s.BrIndeksa).ToList();

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
                                      Id = projekat.Id,
                                      NazivProjekta = projekat.Naziv,
                                      DatumPocetkaIzrade = ucestvuje.DatumPocetkaIzrade,
                                      DatumZavrsetkaIzrade = ucestvuje.DatumZavrsetka,
                                      RokZaZavrsetak = ucestvuje.RokZaZavrsetak,
                                      ProjekatZavrsen = ucestvuje.ProjekatZavrsen,
                                      VrstaProjekta = projekat.VrstaProjekta
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
    public static List<StudentPregled> VratiStudNaGrupnomProj(int IdTProj)
    {
        List<StudentPregled> studenti = new List<StudentPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            studenti = s.Query<Ucestvuje>().Where(p=> p.Projekat.Id == IdTProj).Join(s.Query<Student>(),
                                  ucestvuje => ucestvuje.Student.BrIndeksa,
                                  student => student.BrIndeksa,
                                  (ucestvuje, student) => new StudentPregled
                                  {
                                      BrIndeksa = student.BrIndeksa,
                                      LIme = student.LIme,
                                      Prezime = student.Prezime,
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


    #endregion

    #region Projekti

    public static List<ProjekatPregled> VratiProjekteZaPredmet(string idPredmeta)
    {
        List<ProjekatPregled> projektiPregled = new List<ProjekatPregled>();
        try
        {
            ISession s = DataLayer.GetSession();


            IList<Projekat> projekti = s.Query<Projekat>()
                .Where(p => p.PripadaPredmetu.Id == idPredmeta)
                .OrderBy(p => p.SkolskaGodinaZadavanja)
                .ToList();


            foreach (Projekat p in projekti)
            {
                projektiPregled.Add(new ProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta));
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
        IList<ProjekatPregled> projektiPregled = new List<ProjekatPregled>();
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
                projektiPregled.Add(new ProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return projektiPregled;
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
                                      .OrderBy(p => p.SkolskaGodinaZadavanja)
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

    public static void DodajTeorijskiProjekat(TeorijskiProjekatPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet pred = new Predmet
            {
                Id = p.PripadaPredmetu.Id,
                Naziv = p.PripadaPredmetu.Naziv,
                Semestar = p.PripadaPredmetu.Semestar,
                Katedra = p.PripadaPredmetu.Katedra,
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

    public static string VratiDopunskuLiteraturu(int idproj , string idstud)
    {
        string dopunskalit = null;
        try
        {
            ISession s = DataLayer.GetSession();

            dopunskalit = s.Query<Ucestvuje>().Where(p => p.Projekat.Id == idproj && p.Student.BrIndeksa == idstud).Select(p => p.DopunskaLiteratura).FirstOrDefault();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }

        return dopunskalit;
    }

	#region Literatura

	public static void DodajAutora(int idLiterature,string nazivAutora)
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

	#region Knjiga

	public static List<KnjigaPregled> VratiSveKnjigeZaTeorijskiProjekat(int teorijskiProjekatId)
    {
        List<KnjigaPregled> knjige = new List<KnjigaPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IList<Sadrzi> LiteraturaID = s.Query<Sadrzi>().Where(p => p.TProjekat.Id == teorijskiProjekatId).ToList();

            var literaturaIds = LiteraturaID.Select(l => l.Literatura.LitId).ToList();

            IList<Knjiga> sveKnjige = s.Query<Knjiga>()
                                     .Where(k => literaturaIds.Contains(k.Literatura.LitId))
                                     .ToList();


            foreach (Knjiga k in sveKnjige)
            {
                knjige.Add(new KnjigaPregled(k.Literatura.Naziv, k.ISBN, k.Izdavac, k.GodinaIzdanja, k.Literatura));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return knjige;
    }

    public static List<AutorPregled> VratiAutoreZaKnjigu(string isbn) {
		List<AutorPregled> autori = new List<AutorPregled>();
		try
		{
			ISession s = DataLayer.GetSession();
            var knjiga = s.Load<Knjiga>(isbn);
			var sviAutori = s.Query<LitAutor>()
									  .Where(p => p.Literatura.LitId == knjiga.Literatura.LitId)
									  .ToList();

			foreach (LitAutor la in sviAutori)
			{
                autori.Add(new AutorPregled(la.Autor));
			}

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
        int idLiterature=0;
		try
		{
			ISession s = DataLayer.GetSession();
			var knjiga = s.Load<Knjiga>(isbn);
            idLiterature = s.Query<Literatura>()
                .Where(p => p.LitId == knjiga.Literatura.LitId)
                .FirstOrDefault()
                .LitId;

			s.Close();
		}
		catch (Exception ec)
		{
			Console.WriteLine(ec);
		}

		return idLiterature;
	}

	public static void ObrisiKnjigu(string isbn)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Knjiga o = s.Load<Knjiga>(isbn);

            s.Delete(o);

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
				.Where(p => (p.Autor == nazivAutora && p.Literatura.LitId == knjiga.Literatura.LitId))
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
                Izdavac =p.Izdavac,
                GodinaIzdanja = p.GodinaIzdanja,
                Literatura = lit
            };

            lit.Knjige.Add(r);

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

            Knjiga knjigaEntity = s.Query<Knjiga>()
                                    .FirstOrDefault(k => k.ISBN == isbn);

            if (knjigaEntity != null)
            {
                knjiga = new KnjigaPregled(knjigaEntity.Literatura.Naziv, knjigaEntity.ISBN, knjigaEntity.Izdavac, knjigaEntity.GodinaIzdanja, knjigaEntity.Literatura);
            }

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return knjiga;
    }

    #endregion

    #region Rad

    public static List<RadPregled> VratiSveRadoveZaTeorijskiProjekat(int teorijskiProjekatId)
    {
        List<RadPregled> radovi = new List<RadPregled>();
        try
        {
            ISession s = DataLayer.GetSession();


            IList<Sadrzi> LiteraturaID = s.Query<Sadrzi>().Where(p => p.TProjekat.Id == teorijskiProjekatId).ToList();

            var literaturaIds = LiteraturaID.Select(l => l.Literatura.LitId).ToList();

            IList<Rad> sviRadovi = s.Query<Rad>()
                                     .Where(k => literaturaIds.Contains(k.Literatura.LitId))
                                     .ToList();

			foreach (Rad r in sviRadovi)
            {
                radovi.Add(new RadPregled(r.Id, r.Literatura.Naziv, r.Url , r.KonferencijaObjavljivanja, r.Format, r.Literatura));
            }

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
		List<AutorPregled> autori = new List<AutorPregled>();
		try
		{
			ISession s = DataLayer.GetSession();
			var rad = s.Load<Rad>(id);
			var sviAutori = s.Query<LitAutor>()
									  .Where(p => p.Literatura.LitId == rad.Literatura.LitId)
									  .ToList();

			foreach (LitAutor la in sviAutori)
			{
				autori.Add(new AutorPregled(la.Autor));
			}

			s.Close();
		}
		catch (Exception ec)
		{
			Console.WriteLine(ec);
		}

		return autori;
	}

	public static void ObrisiRad(int id)
	{
		try
		{
			ISession s = DataLayer.GetSession();

			Rad o = s.Load<Rad>(id);

			s.Delete(o);

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
				.FirstOrDefault()
				.LitId;

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
                .Where(p=>(p.Autor==nazivAutora && p.Literatura.LitId == rad.Literatura.LitId))
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

            lit.Radovi.Add(r);

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
        RadPregled rad = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Rad radEntity = s.Load<Rad>(id);

            if (radEntity != null)
            {
                rad = new RadPregled(radEntity.Literatura.Naziv, radEntity.Url, radEntity.KonferencijaObjavljivanja, radEntity.Format, radEntity.Literatura);
            }

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return rad;
    }

    #endregion

    #region ClanakUCaspisu

    public static List<ClanakUCasopisuPregled> VratiSveClankeZaTeorijskiProjekat(int teorijskiProjekatId)
    {
        List<ClanakUCasopisuPregled> clanci = new List<ClanakUCasopisuPregled>();
        try
        {
            ISession s = DataLayer.GetSession();


            IList<Sadrzi> LiteraturaID = s.Query<Sadrzi>().Where(p => p.TProjekat.Id == teorijskiProjekatId).ToList();

            var literaturaIds = LiteraturaID.Select(l => l.Literatura.LitId).ToList();

            IList<ClanakUCasopisu> sviClanci = s.Query<ClanakUCasopisu>()
                                     .Where(k => literaturaIds.Contains(k.Literatura.LitId))
                                     .ToList();


            foreach (ClanakUCasopisu c in sviClanci)
            {
                clanci.Add(new ClanakUCasopisuPregled(c.Literatura.Naziv, c.ISSN, c.ImeCasopisa , c.Broj, c.Godina, c.Literatura));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return clanci;
    }

    public static void ObrisiClanak(string issn)
    {
        // TO BE DETERMINED
        /*try
        {
            ISession s = DataLayer.GetSession();

			ClanakUCasopisu o = s.Load<ClanakUCasopisu>(issn);

			var sadrziPojavljivanja = s.Query<Sadrzi>().Where(x => x.Literatura.LitId == o.Literatura.LitId).ToList();
			foreach (var pojavljivanje in sadrziPojavljivanja)
			{
				s.Delete(pojavljivanje);
			}

            s.Delete(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }*/
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
				.FirstOrDefault()
				.LitId;

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

            lit.ClanciUCasopisu.Add(r);
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
		List<AutorPregled> autori = new List<AutorPregled>();
		try
		{
			ISession s = DataLayer.GetSession();
			var clanak = s.Load<ClanakUCasopisu>(issn);
			var sviAutori = s.Query<LitAutor>()
									  .Where(p => p.Literatura.LitId == clanak.Literatura.LitId)
									  .ToList();

			foreach (LitAutor la in sviAutori)
			{
				autori.Add(new AutorPregled(la.Autor));
			}

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

            ClanakUCasopisu clanakEntity = s.Query<ClanakUCasopisu>()
                                            .FirstOrDefault(c => c.ISSN == issn);

            if (clanakEntity != null)
            {
                clanak = new ClanakUCasopisuPregled(clanakEntity.Literatura.Naziv, clanakEntity.ISSN, clanakEntity.ImeCasopisa, clanakEntity.Broj, clanakEntity.Godina, clanakEntity.Literatura);
            }

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
		var autor = s.Load<ClanakUCasopisu>(issn);
		var lit = autor.Literatura;

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
                projekti.Add(new PrakticniProjekatPregled(p.Id, p.Naziv, p.SkolskaGodinaZadavanja, p.TipProjekta, p.PreporuceniProgramskiJezik));
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

    public static IList<PreporucenaWebStranicaPregled> VratiPreporuceneWebStranicePProjekta(int idProjekta)
    {
        List<PreporucenaWebStranicaPregled> finalStranice = new List<PreporucenaWebStranicaPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            var webStranice = s.Query<PProjektiWebStranice>()
                                      .Where(p => p.PProjekat.Id == idProjekta)
                                      .OrderBy(p => p.PreporucenaWebStrana)
                                      .ToList();

            foreach (var ws in webStranice)
            {
                finalStranice.Add(new PreporucenaWebStranicaPregled(ws.PreporucenaWebStrana));
            }

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec);
        }

        return finalStranice;
    }

    public static void DodajPrakticniProjekat(PrakticniProjekatPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Predmet pred = new Predmet
            {
                Id = p.PripadaPredmetu.Id,
                Naziv = p.PripadaPredmetu.Naziv,
                Semestar = p.PripadaPredmetu.Semestar,
                Katedra = p.PripadaPredmetu.Katedra,
            };

            PrakticniProjekat o = new PrakticniProjekat()
            {
                Naziv = p.Naziv,
                SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja,
                PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik,
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

    public static void AzurirajPrakticniProjekat(PrakticniProjekatPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            PrakticniProjekat o = s.Load<PrakticniProjekat>(p.Id);
            o.Naziv = p.Naziv;
            o.SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja;
            o.PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik;
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
    public static string VratiOdabraniProgJezik(int idproj, string idstud)
    {
        string odabranijezik = null;
        try
        {
            ISession s = DataLayer.GetSession();

            odabranijezik = s.Query<Ucestvuje>().Where(p => p.Projekat.Id == idproj && p.Student.BrIndeksa == idstud).Select(p => p.OdabranProgramskiJezik).FirstOrDefault();

            s.Close();
        }
        catch (Exception ec)
        {
            Console.WriteLine(ec.Message);
        }

        return odabranijezik;
    }

    #endregion
}
