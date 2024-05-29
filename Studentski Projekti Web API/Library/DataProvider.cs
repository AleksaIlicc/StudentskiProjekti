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
                                .Select(s => new StudentiView(s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer))
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
                            (string.IsNullOrEmpty(smer) || s.Smer.StartsWith(smer)))
                .Select(s => new StudentiView(s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer))
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
            return "Greška prilikom brisanja studenta.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

		return true;
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

    #endregion

    #region PrakticniProjekti 
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

            data =(await s.Query<PrakticniProjekat>()
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

    #endregion
}
