﻿using FluentNHibernate.Conventions;
using NHibernate.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                            (string.IsNullOrEmpty(smer) || s.Smer.StartsWith(smer)))
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
            return "Greška prilikom brisanja studenta.".ToError(400);
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

	public static Result<TeorijskiProjekatView,ErrorMessage> VratiTeorijskiProjekat(int id)
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
		ProjekatUcesceDetaljiView? projektiInfo = null;
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

			projektiInfo = s.Query<Ucestvuje>()
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

        return projektiInfo!;
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

            foreach (var uPojavljivanje in ucestvujePojavljivanja)
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
        try
        {

            PrakticniProjekat o = s.Load<PrakticniProjekat>(p.Id);
			o.Naziv = p.Naziv!;
			o.SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja!;
			o.PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik!;
			o.TipProjekta = p.TipProjekta!;
			o.KratakOpis = p.KratakOpis!;

            s.SaveOrUpdate(o);
            s.Flush();
        }
        catch (Exception)
        {
            return "Greska pri azuriranju predmeta.".ToError(400);
        }
        return true;
    }
    private static Result<bool, ErrorMessage> AzurirajStranicePrakticnogProjekta(int? id, List<PreporucenaWebStranicaView> stranice, ISession s)
    {
		try
		{
			var projekat = s.Load<PrakticniProjekat>(id);

			foreach (var postojecaStranica in projekat.PreporuceneWebStranice)
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
		}
		catch (Exception)
		{
			return "Greska pri azuriranju predmeta.".ToError(400);
		}
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
                Console.WriteLine(ex.Message);
            }
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
            return "Došlo je do greške prilikom prikupljanja informacija o predmetima.".ToError(400);
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
					.Where(p => p.PProjekat.Id == idProjekta)
					.OrderBy(p => p.PreporucenaWebStrana)
					.Select(ws => new PreporucenaWebStranicaView(ws.PreporucenaWebStrana))
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
			return "Greska pri dodavanju web stranice.".ToError(404);
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
											 .FirstOrDefault(p => p.PProjekat.Id == idProjekta && p.PreporucenaWebStrana == ps.Naziv);

            s.Delete(stranica);

            s.Flush();

        }
        catch (Exception)
        {
            return "Greška prilikom brisanja web stranice.".ToError(400);
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
    public static Result<IzvestajView, ErrorMessage> VratiIzvestaj(int Id_Izvestaj)
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

			Izvestaj izvestaj = s.Load<Izvestaj>(Id_Izvestaj);

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
                         .Where(p => p.Student.BrIndeksa == brIndkesa && p.Projekat.Id == projekatID)
                         .Join(s.Query<Izvestaj>(),
                             predao => predao.Izvestaj.Id,
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
                        .Where(p => p.Projekat.Id == projid)
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
