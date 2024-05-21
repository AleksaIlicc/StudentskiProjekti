namespace StudentskiProjekti;

public static class DataLayer
{
	private static ISessionFactory factory;
	private static object lockObj;
	

	static DataLayer()
	{
		factory = null;
		lockObj = new object();
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
			// Ako se aplikacija pokrene sa dotnet "putanja do build verzije", mogu da se vide

			string dataSource = Environment.GetEnvironmentVariable("DATA_SOURCE");
			string userId = Environment.GetEnvironmentVariable("USER_ID");
			string password = Environment.GetEnvironmentVariable("PASSWORD");

			var cfg = OracleManagedDataClientConfiguration.Oracle10
			.ShowSql()
			.ConnectionString(c => c.Is($"Data Source ={dataSource};User Id={userId};Password={password}"));
		

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

}
