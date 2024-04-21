using DotNetEnv;
using System.Collections.Specialized;

namespace StudentskiProjekti;

public static class DataLayer
{
	private static ISessionFactory factory;
	private static object lockObj;
	

	static DataLayer()
	{
		factory = null;
		lockObj = new object();
		Env.Load();
	}

	public static ISession GetSession()
	{
		if (factory == null)
		{
			lock (lockObj)
			{
				if (factory == null)
				{
					factory = CreateSessionFactory();
				}
			}
		}

		return factory.OpenSession();
	}

	private static ISessionFactory CreateSessionFactory()
	{
		try
		{
			// ShowSql prikazuje SQL koji je generisan, ali u .NET Core aplikacijama se prikazuju u konzoli.
			// Ako se aplikacija pokrene sa dotnet bin\Debug\net8.0-windows\ProdavnicaIgracaka.dll, mogu da se vide
			/*string cs = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;*/
	
			string dataSource = Environment.GetEnvironmentVariable("DATA_SOURCE");
			string userId = Environment.GetEnvironmentVariable("USER_ID");
			string password = Environment.GetEnvironmentVariable("PASSWORD");

			var cfg = OracleManagedDataClientConfiguration.Oracle10
			.ShowSql()
			.ConnectionString(c => c.Is($"Data Source ={dataSource};User Id={userId};Password={password}"));
			// Ili
			//.ConnectionString(c => c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=prodavnica;Password=prodavnica"));

			return Fluently.Configure()
					.Database(cfg)
					.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Predmet>())
					//.ExposeConfiguration(BuildSchema)
					.BuildSessionFactory();
		}
		catch (Exception e)
		{
			MessageBox.Show(e.Message);
			return null;
		}
	}

	/*private static void BuildSchema(NHibernate.Cfg.Configuration cfg)
    {
        // Konfiguracija
    }*/
}
