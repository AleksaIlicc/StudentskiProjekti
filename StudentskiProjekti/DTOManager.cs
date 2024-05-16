using NHibernate.Criterion;
using StudentskiProjekti.Entiteti;
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

    #region Literatura

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

    public static void ObrisiKnjigu(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Knjiga o = s.Load<Knjiga>(id);

            s.Delete(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void DodajKnjigu(KnjigaPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Literatura lit = new Literatura { Naziv = p.Naziv };

            Knjiga r = new Knjiga()
            {
                ISBN = p.ISBN,
                Izdavac =p.Izdavac,
                GodinaIzdanja = p.GodinaIzdanja,
                Literatura = p.Literatura
            };

            lit.Knjige.Add(r);

            s.Save(lit);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static KnjigaPregled VratiKnjiguPoISBN(string isbn)
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

	public static void DodajRad(RadPregled p)
	{
        try
        {
            ISession s = DataLayer.GetSession();

            Literatura lit = new Literatura { Naziv = p.Naziv };

			Rad r = new Rad()
			{
				Url = p.Url,
                Format = p.Format,
                KonferencijaObjavljivanja = p.KonferencijaObjavljivanja,
                Literatura = lit
			};

            lit.Radovi.Add(r);

			s.Save(lit);

			s.Flush();

			s.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
    public static RadPregled VratiRadPoID(int id)
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
    public static List<ClanakUCasopisuPregled> VratiSveCasopiseZaTeorijskiProjekat(int teorijskiProjekatId)
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
    public static void ObrisiClanak(int id)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            ClanakUCasopisu o = s.Load<ClanakUCasopisu>(id);

            s.Delete(o);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void DodajClanak(ClanakUCasopisuPregled p)
    {
        try
        {
            ISession s = DataLayer.GetSession();

            Literatura lit = new Literatura { Naziv = p.Naziv };

            ClanakUCasopisu r = new ClanakUCasopisu()
            {

                ImeCasopisa = p.ImeCasopisa,
                ISSN = p.ISSN,
                Broj = p.Broj,
                Godina = p.Godina,
                Literatura = p.Literatura
            };

            lit.ClanciUCasopisu.Add(r);

            s.Save(lit);

            s.Flush();

            s.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static ClanakUCasopisuPregled VratiClanakPoISSN(string issn)
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
	#endregion
}
