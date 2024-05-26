namespace Library;

public static class DataProvider
{
	#region Odeljenja
	
    public static async Task<Result<List<PredmetView>, ErrorMessage>> VratiSvePredmeteAsync()
    {
        List<PredmetView> data = new();

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

	/*
    public static async Task<Result<List<OdeljenjeView>, ErrorMessage>> VratiSvaOdeljenjaProdavniceAsync(int id)
    {
        List<OdeljenjeView> data = new();

        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            data = (await s.QueryOver<Odeljenje>().ListAsync())
                           .Where(p => p.PripadaProdavnici?.Id == id)
                           .Select(p => new OdeljenjeView(p)).ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o odeljenjima.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }
    */
	#endregion
}
