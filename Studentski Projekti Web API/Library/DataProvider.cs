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
			return GetError("Greska pri dodavanju predmeta.", 404);
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
}
