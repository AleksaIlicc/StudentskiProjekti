using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiProjekti
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void button_1_Click(object sender, EventArgs e)
		{
			ISession session = null;

			try
			{
				session = DataLayer.GetSession();

				if (session != null)
				{
					Predmet p = await session.LoadAsync<Predmet>(1);
					MessageBox.Show($"Prodavnica sa ID: 61 \"{p.Naziv}\" je pronađena.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				session.Close();
			}
		}
	}
}
