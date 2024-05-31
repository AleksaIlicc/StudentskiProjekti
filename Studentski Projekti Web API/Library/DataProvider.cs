using NHibernate.Linq;

namespace Library;
public static class DataProvider
{
    #region Predmeti

    public static async Task<Result<List<PredmetView>, ErrorMessage>> VratiSvePredmeteAsync()
    {
        List<PredmetView> data = [];

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = (await s.QueryOver<Predmet>().ListAsync())
                            .OrderBy(p => p.Naziv)
                           .Select(p => new PredmetView(p))
                           .ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o predmetima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public static Result<List<PredmetView>, ErrorMessage> VratiSortiranePredmete(string? semestarFilter, string? katedraFilter)
    {
        List<PredmetView> data = [];
        
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = s.Query<Predmet>()
                        .Where(p =>
                            (string.IsNullOrEmpty(semestarFilter) || p.Semestar.ToString() == semestarFilter) &&
                            (string.IsNullOrEmpty(katedraFilter) || p.Katedra != null && p.Katedra.StartsWith(katedraFilter, StringComparison.OrdinalIgnoreCase)))
                        .OrderBy(p => p.Naziv)
                        .Select(p => new PredmetView(p))
                        .ToList();

        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o predmetima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

	public static Result<bool,ErrorMessage> DodajPredmet(PredmetView p)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Predmet o = new Predmet()
			{
				Id = p.Id!,
				Naziv = p.Naziv!,
				Katedra = p.Katedra,
				Semestar = (int)p.Semestar!
			};

			s.Save(o);

			s.Flush();

		}
		catch (Exception)
		{
			return "Greska pri dodavanju predmeta.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<bool, ErrorMessage> ObrisiPredmet(string id)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Predmet o = s.Load<Predmet>(id);

			s.Delete(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška prilikom brisanja predmeta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<bool, ErrorMessage> AzurirajPredmet(PredmetView p)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Predmet o = s.Load<Predmet>(p.Id);
			o.Naziv = p.Naziv!;
			o.Katedra = p.Katedra;
			o.Semestar = (int)p.Semestar!;

			s.SaveOrUpdate(o);
			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri azuriranju predmeta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<PredmetView, ErrorMessage> VratiPredmet(string id)
	{
		PredmetView? data = null;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Predmet o = s.Load<Predmet>(id);
			data = new PredmetView(o);
		}
		catch (Exception)
		{
			return "Greška prilikom pribavljanja predmeta.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	#endregion

    #region Studenti

    public static async Task<Result<List<StudentiView>, ErrorMessage>> VratiSveStudenteAsync()
    {
		List<StudentiView> data = [];
		ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }
            data = (await s.QueryOver<Student>().ListAsync())
                                .OrderBy(s => s.BrIndeksa)
                                .Select(s => new StudentiView(s))
                                .ToList();

        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o studentima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public static Result<List<StudentiView>, ErrorMessage> VratiSortiraneStudente(string? brIndeksa, string? ime, string? prezime, string? smer)
    {
        List<StudentiView> data = [];
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = s.Query<Student>()
                .Where(s => (string.IsNullOrEmpty(brIndeksa) || s.BrIndeksa.StartsWith(brIndeksa)) &&
                            (string.IsNullOrEmpty(ime) || s.LIme.StartsWith(ime)) &&
                            (string.IsNullOrEmpty(prezime) || s.Prezime.StartsWith(prezime)) &&
                            (string.IsNullOrEmpty(smer) || s.Smer!.StartsWith(smer)))
                .Select(s => new StudentiView(s))
                .ToList();


        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o studentima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public static Result<bool, ErrorMessage> DodajStudenta(StudentiView sp)
    {

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Student o = new Student()
            {
                BrIndeksa = sp.BrIndeksa!,
                LIme = sp.LIme!,
                Prezime = sp.Prezime!,
                ImeRoditelja = sp.ImeRoditelja!,
                Smer = sp.Smer!
            };

            s.Save(o);

            s.Flush();

        }
        catch (Exception)
        {
            return "Greska pri dodavanju studenta.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<bool, ErrorMessage> AzurirajStudenta(StudentiView sp)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Student o = s.Load<Student>(sp.BrIndeksa);
            o.LIme = sp.LIme!;
            o.ImeRoditelja = sp.ImeRoditelja!;
            o.Prezime = sp.Prezime!;
            o.Smer = sp.Smer!;

            s.SaveOrUpdate(o);
            s.Flush();

        }
        catch (Exception)
        {
            return "Greska pri azuriranju studenta.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiStudenta(string brIndeksa)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Student o = s.Load<Student>(brIndeksa);

            s.Delete(o);

            s.Flush();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja studenta.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

		return true;
	}

	public static Result<StudentiView,ErrorMessage> VratiStudenta(string brIndeksa)
	{
		StudentiView? data = null;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Student o = s.Load<Student>(brIndeksa);
			data = new StudentiView(o);
		}
		catch (Exception)
		{
			return "Greška prilikom pribavljanja studenta.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

    public static Result<List<ProjekatUcesceDetaljiView>, ErrorMessage> VratiProjekteZaStudenta(string studentId)
    {
        List<ProjekatUcesceDetaljiView> data = [];

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = s.Query<Ucestvuje>()
                    .Where(ucestvuje => ucestvuje.Student.BrIndeksa == studentId)
                    .Join(s.Query<Projekat>(),
                            ucestvuje => ucestvuje.Projekat.Id,
                            projekat => projekat.Id,
                            (ucestvuje, projekat) => new ProjekatUcesceDetaljiView
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
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o projektima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }
    #endregion

    #region Projekti

    public static async Task<Result<List<ProjekatView>, ErrorMessage>> VratiSveProjektePredmetaAsync(string idPredmeta)
	{
		List<ProjekatView> data = [];

		ISession? s = null;
		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.Query<Projekat>()
						.Where(p => p.PripadaPredmetu.Id == idPredmeta)
						.OrderBy(p => p.SkolskaGodinaZadavanja)
						.ToListAsync())
						.Select(p => new ProjekatView(p))
						.ToList();

		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom prikupljanja informacija o projektima predmeta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

    public static Result<List<ProjekatView>, ErrorMessage> VratiSortiraneProjekteZaPredmet(string idPredmeta, string vrstaProjekta, string tipProjekta, string skolskaGodina)
    {
        List<ProjekatView> data = [];

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

			data = s.Query<Projekat>()
				.Where(p => p.PripadaPredmetu.Id == idPredmeta &&
				(string.IsNullOrEmpty(vrstaProjekta) || p.VrstaProjekta == vrstaProjekta) &&
				(string.IsNullOrEmpty(tipProjekta) || p.TipProjekta == tipProjekta) &&
				(string.IsNullOrEmpty(skolskaGodina) || p.SkolskaGodinaZadavanja == skolskaGodina))
				.OrderBy(pr => pr.SkolskaGodinaZadavanja)
				.Select(p => new ProjekatView(p))
				.ToList();
		
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom prikupljanja informacija o projektima predmeta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static async Task<Result<List<TeorijskiProjekatView>,ErrorMessage>> VratiTeorijskeProjekteZaPredmetAsync(string idPredmeta)
	{
		List<TeorijskiProjekatView> data = [];

		ISession? s = null;
		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = (await s.Query<TeorijskiProjekat>()
				.Where(p => p.PripadaPredmetu.Id == idPredmeta)
				.ToListAsync())
				.OrderBy(pr => pr.SkolskaGodinaZadavanja)
				.Select(p => new TeorijskiProjekatView(p))
				.ToList();
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom prikupljanja informacija o teorijskim projektima predmeta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

    public static async Task<Result<List<PrakticniProjekatView>, ErrorMessage>> VratiPrakticneProjekteZaPredmetAsync(string idPredmeta)
    {
        List<PrakticniProjekatView> data = [];

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = (await s.Query<PrakticniProjekat>()
                                      .Where(p => p.PripadaPredmetu.Id == idPredmeta)
                                      .OrderBy(p => p.SkolskaGodinaZadavanja)
                                      .ToListAsync())
                                      .Select(p => new PrakticniProjekatView(p))
                                      .ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o prakticnim projektima predmeta.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

	public static Result<List<StudentiView>, ErrorMessage> VratiStudenteNaProjektu(int id)
	{
		ISession? s = null;
		List<StudentiView> data = [];

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			data = s.Query<Ucestvuje>()
				.Where(u => u.Projekat.Id == id)
				.Select(u => new StudentiView(u.Student))
				.ToList();
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom prikupljanja informacija o studentima na projektu.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return data;
	}
		
	#endregion

    #region TeorijskiProjekti

    public static Result<bool, ErrorMessage> DodajTeorijskiProjekat(TeorijskiProjekatView p)
	{

		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Predmet pred = s.Load<Predmet>(p.PripadaPredmetu!.Id);

			TeorijskiProjekat o = new TeorijskiProjekat()
			{
				Naziv = p.Naziv!,
				SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja!,
				MaksBrojStrana = (int)p.MaksBrojStrana!,
				VrstaProjekta = "teorijski",
				TipProjekta = p.TipProjekta!,
				PripadaPredmetu = pred,
			};

			s.Save(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri dodavanju projekta".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<bool, ErrorMessage> ObrisiTeorijskiProjekat(int id)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			TeorijskiProjekat o = s.Load<TeorijskiProjekat>(id);

			s.Delete(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška pri brisanju projekta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<bool, ErrorMessage> AzurirajTeorijskiProjekat(TeorijskiProjekatView p)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			TeorijskiProjekat o = s.Load<TeorijskiProjekat>(p.Id);
			o.Naziv = p.Naziv!;
			o.SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja!;
			o.MaksBrojStrana = (int)p.MaksBrojStrana!;
			o.TipProjekta = p.TipProjekta!;

			s.SaveOrUpdate(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška prilikom azuriranja projekta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<TeorijskiProjekatView, ErrorMessage> VratiTeorijskiProjekat(int id)
	{
		TeorijskiProjekatView? data = null;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			TeorijskiProjekat o = s.Load<TeorijskiProjekat>(id);
			data = new TeorijskiProjekatView(o);
		}
		catch (Exception)
		{
			return "Greška prilikom pribavljanja projekta.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

    public static Result<bool, ErrorMessage> ObrisiUcesnikeProjekta(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            var ucestvujePojavljivanja = s.Query<Ucestvuje>()
                                            .Where(u => u.Projekat.Id == id)
                                            .ToList();

            foreach (var uPojavljivanje in ucestvujePojavljivanja)
            {
                s.Delete(uPojavljivanje);
            }

            s.Flush();

        }
        catch (Exception)
        {
            return "Greška prilikom brisanja ucesnika teorijskog projekta.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }

    #region Literatura

    public static Result<bool, ErrorMessage> DodajAutora(int idLiterature, AutorView autor)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Literatura l = s.Load<Literatura>(idLiterature);

			LitAutor? o = s.Query<LitAutor>()
				.Where(l => l.Literatura!.LitId == idLiterature && l.Autor == autor.Autor)
				.FirstOrDefault();

			if (o != null)	
				return "Autor već postoji.".ToError(409);
			
			o = new LitAutor()
			{
				Autor = autor.Autor!,
				Literatura = l
			};

			s.Save(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri dodavanju autora.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	public static Result<List<AutorView>, ErrorMessage> VratiAutoreZaLiteraturu(int idLiterature)
	{
		List<AutorView> data = [];
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = s.Query<LitAutor>()
				.Where(l => l.Literatura!.LitId == idLiterature)
				.Select(l => new AutorView(l))
				.ToList();
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom prikupljanja informacija o autorima literature.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return data;
	}

	public static Result<bool, ErrorMessage> ObrisiAutora(int idLiterature, AutorView autor)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			LitAutor? o = s.Query<LitAutor>()
							.Where(l => l.Literatura!.LitId == idLiterature && l.Autor == autor.Autor)
							.FirstOrDefault();

			if (o == null)
				return "Autor ne postoji.".ToError(404);

			s.Delete(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška prilikom brisanja autora.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	public static Result<bool, ErrorMessage> ObrisiLiteraturu(int id)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

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
		}
		catch (Exception)
		{
			return "Greška prilikom brisanja literature.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

    public static async Task<Result<List<LiteraturaView>, ErrorMessage>> VratiSveLiteratureAsync()
    {
        List<LiteraturaView> data = [];
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }
            data =(await s.Query<Literatura>()
                            .OrderBy(l => l.Naziv).ToListAsync())
                            .Select(l => new LiteraturaView(l))
                            .ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o literaturama.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public static Result<List<LiteraturaView>, ErrorMessage> VratiPretrazeneLiterature(string search)
    {
        List<LiteraturaView> data = [];
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }
            data = s.Query<Literatura>()
                    .Where(lit => lit.Naziv.ToLower().Contains(search.ToLower()))
                    .OrderBy(l => l.Naziv)
                    .Select(l => new LiteraturaView(l))
                    .ToList();

        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o literaturama.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    #region Rad

    public static Result<bool, ErrorMessage> DodajRad(int tProjekatId, RadView rad, List<AutorView> autori)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			Literatura lit = new Literatura { Naziv = rad.Naziv! };

			List<LitAutor> listaAutora = new List<LitAutor>();
			foreach (AutorView ap in autori)
			{
				listaAutora.Add(new LitAutor() { Autor = ap.Autor, Literatura = lit });
			}
			lit.Autori = listaAutora;

			Rad r = new Rad()
			{
				Url = rad.Url,
				Format = rad.Format,
				KonferencijaObjavljivanja = rad.KonferencijaObjavljivanja,
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
		}
		catch (Exception)
		{
			return "Greska pri dodavanju rada.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	public static Result<RadView, ErrorMessage> VratiRad(int id)
	{
		RadView? data = null;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Rad o = s.Load<Rad>(id);
			data = new RadView(o);
		}
		catch (Exception)
		{
			return "Greška prilikom pribavljanja rada.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data;
	}

	public static Result<int, ErrorMessage> VratiIdLiteratureRada(int id)
	{
		int? data = 0;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			var rad = s.Load<Rad>(id);
			data = s.Query<Literatura>()
						.Where(p => p.LitId == rad.Literatura!.LitId)
						.Select(l => l.LitId)
						.FirstOrDefault();
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom pribavljanja informacija o radu.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return (int)data!;
	}

	public static Result<bool, ErrorMessage> ObrisiRad(int projekatId, int id)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			Rad r = s.Load<Rad>(id);
			Sadrzi? o = s.Query<Sadrzi>()
						.Where(x => x.Literatura.LitId == r.Literatura!.LitId && projekatId == x.TProjekat.Id)
						.FirstOrDefault();

			if (o == null)
				return "Rad ne postoji.".ToError(404);

			s.Delete(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška prilikom brisanja rada.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	public static Result<List<RadView>, ErrorMessage> VratiRadoveZaTProjekat(int id)
	{
		List<RadView> data = [];
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = s.Query<Sadrzi>()
					   .Where(p => p.TProjekat.Id == id)
					   .Join(s.Query<Rad>(),
					   sadrzi => sadrzi.Literatura.LitId,
					   rad => rad.Literatura!.LitId,
					   (sadrzi, rad) => new RadView(rad)
					   )
					   .ToList();
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom prikupljanja informacija o radovima.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return data;
	}

	private static void AzurirajRad(RadView radPregled, ISession s)
	{
		Rad rad = s.Load<Rad>(radPregled.Id);
		rad.Format = radPregled.Format;
		rad.KonferencijaObjavljivanja = radPregled.KonferencijaObjavljivanja;
		rad.Url = radPregled.Url;
		rad.Literatura!.Naziv = radPregled.Naziv!;

		s.SaveOrUpdate(rad);
	}

	private static void AzurirajAutoreRada(int id, List<AutorView> azuriraniAutori, ISession s)
	{
		var rad = s.Load<Rad>(id);
		var lit = rad.Literatura;

		foreach (var postojeciAutori in lit!.Autori!.ToList())
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

	public static Result<bool, ErrorMessage> AzurirajRadSaAutorima(RadView radPregled, List<AutorView> azuriraniAutori)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			using ITransaction t = s.BeginTransaction();
			try
			{
				AzurirajRad(radPregled, s);
				AzurirajAutoreRada((int)radPregled.Id!, azuriraniAutori, s);

				t.Commit();
			}
			catch (Exception)
			{
				t.Rollback();
				return "Greška pri ažuriranju rada.".ToError(400);
			}

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška pri ažuriranju rada.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	#endregion

	#region Knjiga

	public static Result<List<KnjigaView>, ErrorMessage> VratiKnjigeZaTProjekat(int id)
	{
		List<KnjigaView> data = [];
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = s.Query<Sadrzi>()
					   .Where(p => p.TProjekat.Id == id)
					   .Join(s.Query<Knjiga>(),
					   sadrzi => sadrzi.Literatura.LitId,
					   knjiga => knjiga.Literatura.LitId,
					   (sadrzi, knjiga) => new KnjigaView(knjiga)
					   )
					   .ToList();
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom prikupljanja informacija o knjigama.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return data;
	}

	public static Result<int, ErrorMessage> VratiIdLiteratureKnjige(string isbn)
	{
		int data = 0;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = s.Query<Knjiga>()
				.Where(k => k.ISBN == isbn)
				.Select(k => (int)k.Literatura.LitId!)
				.FirstOrDefault();
		}
		catch (Exception)
		{
			return "Došlo je do greške prilikom pribavljanja informacija o knjigama.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return data;
	}

	public static Result<bool, ErrorMessage> ObrisiKnjigu(int projekatId, string isbn)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			Knjiga k = s.Load<Knjiga>(isbn);
			Sadrzi? o = s.Query<Sadrzi>()
						.Where(x => x.Literatura.LitId == k.Literatura.LitId && projekatId == x.TProjekat.Id)
						.FirstOrDefault();

			if (o == null)
				return "Knjiga ne postoji.".ToError(404);

			s.Delete(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška prilikom brisanja knjige.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	public static Result<bool, ErrorMessage> DodajKnjigu(int tProjekatId, KnjigaView knjiga, List<AutorView> autori)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			Literatura lit = new Literatura()
			{
				Naziv = knjiga.Naziv!,
			};

			List<LitAutor> listaAutora = new List<LitAutor>();
			foreach (AutorView ap in autori)
			{
				listaAutora.Add(new LitAutor() { Autor = ap.Autor!, Literatura = lit });
			}
			lit.Autori = listaAutora;

			Knjiga r = new Knjiga()
			{
				ISBN = knjiga.ISBN!,
				Izdavac = knjiga.Izdavac!,
				GodinaIzdanja = (int)knjiga.GodinaIzdanja!,
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
		}
		catch (Exception)
		{
			return "Greska pri dodavanju knjige.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	public static Result<KnjigaView, ErrorMessage> VratiKnjigu(string isbn)
	{
		KnjigaView? data = null;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			Knjiga o = s.Load<Knjiga>(isbn);
			data = new KnjigaView(o);
		}
		catch (Exception)
		{
			return "Greška prilikom pribavljanja knjige.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return data;
	}

	private static void AzurirajKnjigu(KnjigaView knjigaPregled, ISession s)
	{
		Knjiga knjiga = s.Load<Knjiga>(knjigaPregled.ISBN);
		knjiga.Izdavac = knjigaPregled.Izdavac!;
		knjiga.GodinaIzdanja = (int)knjigaPregled.GodinaIzdanja!;
		knjiga.Literatura.Naziv = knjigaPregled.Naziv!;

		s.SaveOrUpdate(knjiga);
	}

	private static void AzurirajAutoreKnjige(string isbn, List<AutorView> azuriraniAutori, ISession s)
	{
		var knjiga = s.Load<Knjiga>(isbn);
		var lit = knjiga.Literatura;

		foreach (var postojeciAutori in lit.Autori!.ToList())
		{
			s.Delete(postojeciAutori);
		}

		List<LitAutor> autori = new List<LitAutor>();
		foreach (var autorPregled in azuriraniAutori)
		{
			autori.Add(new LitAutor() { Autor = autorPregled.Autor!, Literatura = lit });
		}

		lit.Autori = autori;

		s.Update(lit);
	}

	public static Result<bool, ErrorMessage> AzurirajKnjiguSaAutorima(KnjigaView knjigaPregled, List<AutorView> azuriraniAutori)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			using ITransaction t = s.BeginTransaction();
			try { 
				AzurirajKnjigu(knjigaPregled, s);
				AzurirajAutoreKnjige(knjigaPregled.ISBN!, azuriraniAutori, s);
				t.Commit();
			}
			catch (Exception)
			{
				t.Rollback();
				return "Greška pri ažuriranju knjige.".ToError(400);
			}

			s.Flush();
		}
		catch (Exception)
		{
			return "Greška pri ažuriranju knjige.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

    #endregion

    #region ClanakUCasopisu
    public static Result<List<ClanakUCasopisuView>, ErrorMessage> VratiSveClanakeZaTProj(int teorijskiProjekatId)
    {
        List<ClanakUCasopisuView> clanaci = new List<ClanakUCasopisuView>();
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            clanaci = s.Query<Sadrzi>()
                .Where(p => p.TProjekat.Id == teorijskiProjekatId)
                .Join(s.Query<ClanakUCasopisu>(),
                    sadrzi => sadrzi.Literatura.LitId,
                    clanak => clanak.Literatura.LitId,
                    (sadrzi, clanak) => new ClanakUCasopisuView(clanak)
                ).ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o člancima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return clanaci;
    }

    public static Result<bool, ErrorMessage> ObrisiClanak(int projekatId, string issn)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ClanakUCasopisu clanak = s.Load<ClanakUCasopisu>(issn);
            var sadrzi = s.Query<Sadrzi>()
						  .Where(x => x.Literatura.LitId == clanak.Literatura.LitId && projekatId == x.TProjekat.Id)
						  .FirstOrDefault();

            s.Delete(sadrzi);

            s.Flush();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja članka.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<int, ErrorMessage> VratiIdLiteratureClanka(string issn)
    {
        int? idLiterature = 0;
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            var clanak = s.Load<ClanakUCasopisu>(issn);
            idLiterature = s.Query<Literatura>()
							.Where(p => p.LitId == clanak.Literatura.LitId)
							.Select(l => l.LitId)
							.FirstOrDefault();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom pribavljanja informacija o članku.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return (int)idLiterature!;
    }

    public static Result<bool, ErrorMessage> DodajClanak(int tProjekatId, ClanakUCasopisuView clanakView, List<AutorView> autori)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Literatura lit = new Literatura
            {
                Naziv = clanakView.Naziv!
            };

            List<LitAutor> listaAutora = [];
            foreach (AutorView ap in autori)
            {
                listaAutora.Add(new LitAutor { Autor = ap.Autor!, Literatura = lit });
            }
            lit.Autori = listaAutora;

            ClanakUCasopisu clanak = new ClanakUCasopisu
            {
                ISSN = clanakView.ISSN!,
                ImeCasopisa = clanakView.ImeCasopisa!,
                Broj = (int)clanakView.Broj!,
                Godina = (int)clanakView.Godina!,
                Literatura = lit
            };

            lit.ClanakUCasopisu = clanak;

            s.Save(lit);

            Sadrzi sadrzi = new Sadrzi
            {
                Literatura = lit,
                TProjekat = s.Load<TeorijskiProjekat>(tProjekatId)
            };

            s.Save(sadrzi);

            s.Flush();
        }
        catch (Exception)
        {
            return "Greska pri dodavanju članka.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<ClanakUCasopisuView, ErrorMessage> VratiClanak(int id)
    {
        ClanakUCasopisuView? clanakView = null;
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ClanakUCasopisu clanak = s.Load<ClanakUCasopisu>(id);
            clanakView = new ClanakUCasopisuView(clanak);
        }
        catch (Exception)
        {
            return "Greška prilikom pribavljanja članka.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return clanakView;
    }

    private static Result<bool, ErrorMessage> AzurirajClanak(ClanakUCasopisuView clanakView, ISession s)
    {

		ClanakUCasopisu clanak = s.Load<ClanakUCasopisu>(clanakView.ISSN);
		clanak.ISSN = clanakView.ISSN!;
		clanak.ImeCasopisa = clanakView.ImeCasopisa!;
		clanak.Broj = (int)clanakView.Broj!;
		clanak.Godina = (int)clanakView.Godina!;
		clanak.Literatura.Naziv = clanakView.Naziv!;

		s.SaveOrUpdate(clanak);

        return true;
    }

    private static Result<bool, ErrorMessage> AzurirajAutoreClanka(string issn, List<AutorView> azuriraniAutori, ISession s)
    {

		var clanak = s.Load<ClanakUCasopisu>(issn);
		var lit = clanak.Literatura;

		foreach (var postojeciAutori in lit.Autori!.ToList())
		{
			s.Delete(postojeciAutori);
		}

		List<LitAutor> autori = new List<LitAutor>();
		foreach (var autorPregled in azuriraniAutori)
		{
			autori.Add(new LitAutor { Autor = autorPregled.Autor!, Literatura = lit });
		}

		lit.Autori = autori;

		s.Update(lit);
		return true;
    }

    public static Result<bool, ErrorMessage> AzurirajClanakSaAutorima(ClanakUCasopisuView clanakView, List<AutorView> azuriraniAutori)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            using ITransaction t = s.BeginTransaction();
            try
            {
                AzurirajClanak(clanakView, s);
                AzurirajAutoreClanka(clanakView.ISSN! , azuriraniAutori, s);

                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                return "Greška prilikom ažuriranja članka.".ToError(400);
            }
        }
        catch (Exception)
        {
            return "Greška prilikom pribavljanja članka.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #endregion

    #endregion

    #region Ucestvuje

    public static Result<bool, ErrorMessage> DodajUcesce(string brind, int projId, UcestvujeView u)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			Student stud = s.Load<Student>(brind);
			Projekat p = s.Load<Projekat>(projId);

			Ucestvuje? ucesce = s.Query<Ucestvuje>()
								.Where(p => p.Student.BrIndeksa == brind && p.Projekat.Id == projId)
								.FirstOrDefault();

			if (ucesce != null)
			{ 
				return "Ucesce vec postoji.".ToError(409);
			}

			Ucestvuje o = new Ucestvuje()
			{
				DatumPocetkaIzrade = (DateTime)u.DatumPocetkaIzrade!,
				DatumZavrsetka = u.DatumZavrsetka!,
				RokZaZavrsetak = (DateTime)u.RokZaZavrsetak!,
				OdabranProgramskiJezik = u.OdabranProgramskiJezik!,
				UrlDokumentacijeProgJezika = u.UrlDokumentacijeProgJezika!,
				DopunskaLiteratura = u.DopunskaLiteratura!,
				Student = stud,
				Projekat = p,
			};

			o!.ProjekatZavrsen = o.DatumZavrsetka.HasValue ? "da" : "ne";

			s.Save(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri dodavanju ucesca.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

	public static Result<bool, ErrorMessage> AzurirajUcesce(UcestvujeView u)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Ucestvuje o = s.Load<Ucestvuje>(u.Id);
			o.DatumPocetkaIzrade = (DateTime)u.DatumPocetkaIzrade!;
			o.DatumZavrsetka = u.DatumZavrsetka!;
			o.RokZaZavrsetak = (DateTime)u.RokZaZavrsetak!;
			o.OdabranProgramskiJezik = u.OdabranProgramskiJezik!;
			o.UrlDokumentacijeProgJezika = u.UrlDokumentacijeProgJezika!;
			o.DopunskaLiteratura = u.DopunskaLiteratura!;

			o.ProjekatZavrsen = o.DatumZavrsetka.HasValue ? "da" : "ne";

			s.SaveOrUpdate(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri azuriranju ucesca.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<bool, ErrorMessage> ObrisiUcesce(int id)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Ucestvuje o = s.Load<Ucestvuje>(id);

			s.Delete(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri brisanju ucesca.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return true;
	}

	public static Result<UcestvujeView, ErrorMessage> VratiUcesce(int projid, string studid)
	{
		UcestvujeView? data = null;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			data = s.Query<Ucestvuje>()
					.Where(p => p.Student.BrIndeksa == studid && p.Projekat.Id == projid)
					.Select(o => new UcestvujeView(o))
					.FirstOrDefault();
		}
		catch (Exception)
		{
			return "Greška prilikom pribavljanja ucesca.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

		return data!;
	}

	public static Result<ProjekatUcesceDetaljiView, ErrorMessage> VratiUcesceDetalji(string studentId, int projId)
    {
		ProjekatUcesceDetaljiView? data = null;
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = s.Query<Ucestvuje>()
							.Where(ucestvuje => ucestvuje.Student.BrIndeksa == studentId && ucestvuje.Projekat.Id == projId)
							.Join(s.Query<Projekat>(),
								  ucestvuje => ucestvuje.Projekat.Id,
								  projekat => projekat.Id,
								  (ucestvuje, projekat) => new ProjekatUcesceDetaljiView
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
        }
        catch (Exception)
        {
            return "Greška prilikom pribavljanja detalja ucesca.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data!;
    }

    #endregion

    #region PrakticniProjekti 

    public static Result<bool, ErrorMessage> DodajPrakticniProjekat(PrakticniProjekatView p, List<PreporucenaWebStranicaView> stranice)
    {
        ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
			Predmet pred = s.Load<Predmet>(p.PripadaPredmetu?.Id);

			PrakticniProjekat o = new PrakticniProjekat()
			{
				Naziv = p.Naziv!,
				SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja!,
				PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik!,
				VrstaProjekta = p.VrstaProjekta!,
				TipProjekta = p.TipProjekta!,
				KratakOpis = p.KratakOpis!,
				PripadaPredmetu = pred
			};

			List<PProjektiWebStranice> prepStranice = [];

			foreach (var stranica in stranice)
			{
				prepStranice.Add(new PProjektiWebStranice() { PreporucenaWebStrana = stranica.Naziv!, PProjekat = o });
			}

			o.PreporuceneWebStranice = prepStranice;

			s.Save(o);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri dodavanju prakticnog projekta.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}

        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiUcesnikePrakticnogProjekta(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            var ucestvujePojavljivanja = s.Query<Ucestvuje>()
                            .Where(u => u.Projekat.Id == id)
                            .ToList();
			if (ucestvujePojavljivanja.Count == 0)
			{
                return "Greška, ne postoje ucesca na ovom projektu.".ToError(404);
            }

            foreach (var uPojavljivanje in ucestvujePojavljivanja)
            {
                s.Delete(uPojavljivanje);
            }

            var izvestajiPojavljivanja = s.Query<Predao>()
                                    .Where(s => s.Projekat!.Id == id)
                                    .ToList();

            foreach (var iPojavljivanje in izvestajiPojavljivanja)
            {
                s.Delete(iPojavljivanje);
            }

            s.Flush();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja ucesnika prakticnog projekta.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiPrakticniProjekat(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PrakticniProjekat o = s.Load<PrakticniProjekat>(id);

            s.Delete(o);

            s.Flush();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja prakticnog projekta.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    private static Result<bool, ErrorMessage> AzurirajPrakticniProjekat(PrakticniProjekatView p , ISession s)
    {

        PrakticniProjekat o = s.Load<PrakticniProjekat>(p.Id);
		o.Naziv = p.Naziv!;
		o.SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja!;
		o.PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik!;
		o.TipProjekta = p.TipProjekta!;
		o.KratakOpis = p.KratakOpis!;

        s.SaveOrUpdate(o);

		return true;
    }

    private static Result<bool, ErrorMessage> AzurirajStranicePrakticnogProjekta(int? id, List<PreporucenaWebStranicaView> stranice, ISession s)
    {

		var projekat = s.Load<PrakticniProjekat>(id);

		foreach (var postojecaStranica in projekat.PreporuceneWebStranice!)
		{
			s.Delete(postojecaStranica);
		}

		List<PProjektiWebStranice> noveStranice = [];
		foreach (var stranica in stranice)
		{
			noveStranice.Add(new PProjektiWebStranice() { PreporucenaWebStrana = stranica.Naziv!, PProjekat = projekat });
		}

		projekat.PreporuceneWebStranice = noveStranice;

		s.Update(projekat);

        return true;
    }

	public static Result<bool, ErrorMessage> AzurirajPrakticniProjekatSaStranicama(PrakticniProjekatView p, List<PreporucenaWebStranicaView> stranice)
	{
		ISession? s = null;
		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}
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
                return "Greska pri azuriranju prakticnog projekta.".ToError(400);
            }
		}
		catch (Exception)
		{
			return "Greska pri azuriranju prakticnog projekta.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

    public static Result<PrakticniProjekatView, ErrorMessage> VratiPrakticniProjekat(int id)
    {
        PrakticniProjekatView? p = null;

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PrakticniProjekat o = s.Load<PrakticniProjekat>(id);
            p = new PrakticniProjekatView(o);
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o prakticnim projektima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return p;
    }

    #region PreporuceneWebStranice
    public static Result<List<PreporucenaWebStranicaView>, ErrorMessage> VratiPreporuceneWebStranicePProjekta(int idProjekta)
    {
        List<PreporucenaWebStranicaView> data = [];

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }
  
            data = s.Query<PProjektiWebStranice>()
					.Where(p => p.PProjekat!.Id == idProjekta)
					.OrderBy(p => p.PreporucenaWebStrana)
					.Select(ws => new PreporucenaWebStranicaView(ws))
					.ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o web stranicama.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return data;
    }

    public static Result<bool, ErrorMessage> DodajPreporucenuWebStranicuZaProjekat(int idProjekta, PreporucenaWebStranicaView p)
    {
        ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			PrakticniProjekat pProjekat = s.Load<PrakticniProjekat>(idProjekta);

			PProjektiWebStranice novaWebStranica = new PProjektiWebStranice()
			{
				PreporucenaWebStrana = p.Naziv!,
				PProjekat = pProjekat
			};

			s.Save(novaWebStranica);

			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri dodavanju preporucene web stranice.".ToError(404);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiPreporucenuWebStranicuZaProjekat(int idProjekta, PreporucenaWebStranicaView ps)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PProjektiWebStranice? stranica = s.Query<PProjektiWebStranice>()
											 .FirstOrDefault(p => p.PProjekat!.Id == idProjekta && p.PreporucenaWebStrana == ps.Naziv);

            s.Delete(stranica);

            s.Flush();

        }
        catch (Exception)
        {
            return "Greška prilikom brisanja preporucene web stranice.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region Izvestaj
    public static Result<bool, ErrorMessage> DodajIzvestaj(int prakProjId, string studBrInd, IzvestajView izvesPreg)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PrakticniProjekat pp = s.Load<PrakticniProjekat>(prakProjId);
            Student st = s.Load<Student>(studBrInd);

            Izvestaj iz = new Izvestaj()
            {
                Opis = izvesPreg.Opis!,
                DatumPredaje = (DateTime)izvesPreg.DatumPredaje!,
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
        }
        catch (Exception)
        {
            return "Greska pri dodavanju izvestaja.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }

	public static Result<bool, ErrorMessage> AzurirajIzvestaj(IzvestajView p)
	{
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Izvestaj o = s.Load<Izvestaj>(p.Id);
			o.Opis = p.Opis!;
			o.DatumPredaje = (DateTime)p.DatumPredaje!;

			s.SaveOrUpdate(o);
			s.Flush();
		}
		catch (Exception)
		{
			return "Greska pri azuriranju izvestaja.".ToError(400);
		}
		finally
		{
			s?.Close();
			s?.Dispose();
		}
		return true;
	}

    public static Result<bool, ErrorMessage> ObrisiIzvestaj(int id)
	{
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Izvestaj o = s.Load<Izvestaj>(id);

			s.Delete(o);

			s.Flush();
		}
        catch (Exception)
        {
            return "Greška prilikom brisanja izvestaja.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }

    public static Result<IzvestajView, ErrorMessage> VratiIzvestaj(int idIzvestaj)
	{
		IzvestajView? ip = null;
		ISession? s = null;

		try
		{
			s = DataLayer.GetSession();

			if (!(s?.IsConnected ?? false))
			{
				return "Nemoguće otvoriti sesiju.".ToError(403);
			}

			Izvestaj izvestaj = s.Load<Izvestaj>(idIzvestaj);

			ip = new IzvestajView()
			{
				Opis = izvestaj.Opis,
				DatumPredaje = izvestaj.DatumPredaje,
				Id = izvestaj.Id,
			};
		}
        catch (Exception)
        {
            return "Greška prilikom pribavljanja izvestaja.".ToError(404);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return ip;
    }

    public static Result<List<IzvestajView>, ErrorMessage> VratiIzvestajeZaStudenta(string brIndkesa, int projekatID)
    {
        List<IzvestajView> data = [];

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = s.Query<Predao>()
                         .Where(p => p.Student!.BrIndeksa == brIndkesa && p.Projekat!.Id == projekatID)
                         .Join(s.Query<Izvestaj>(),
                             predao => predao.Izvestaj!.Id,
                             izvestaj => izvestaj.Id,
                             (predao, izvestaj) => new IzvestajView
                             {
                                 Opis = izvestaj.Opis,
                                 DatumPredaje = izvestaj.DatumPredaje,
                                 Id = izvestaj.Id
                             })
                          .ToList();

        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o izvestajima studenta.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return data;
    }

    public static Result<int, ErrorMessage> VratiBrPredIzvestajaNaGrupi(int projid)
    {
		int brojizv = 0;

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }
            brojizv = s.Query<Predao>()
                        .Where(p => p.Projekat!.Id == projid)
                        .Count();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o broju izvestaja.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return brojizv;
    }
    #endregion

    #endregion
}
