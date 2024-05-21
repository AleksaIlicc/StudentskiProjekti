using System;
using System.Security.Policy;
using System.Text.RegularExpressions;
using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajRad : Form
{
	RadPregled rad = new RadPregled();
	int projekatId;
	public DodajRad(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}

	private void DodajRad_Load(object sender, EventArgs e)
	{
		List<string> opcije = new List<string>
		{
			"pdf",
			"word",
			"post-script"
		};

		Format_CB.DataSource = opcije;
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novi rad?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(Naziv_TB.Text))
			{
				MessageBox.Show("Morate uneti naziv rada!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (!string.IsNullOrEmpty(URL_TB.Text) && !IsValidUrl(URL_TB.Text))
			{
				MessageBox.Show("Uneti URL nije validan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			rad.Naziv = Naziv_TB.Text;
			rad.Url = URL_TB.Text;
			rad.KonferencijaObjavljivanja = KonfObjavljivanja_TB.Text;
			rad.Format = (string)Format_CB.SelectedItem;

			List<AutorPregled> autori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled(detaljiAutora);
				autori.Add(noviAutor);
			}

			DTOManager.DodajRad(projekatId, rad, autori);
			MessageBox.Show("Uspesno ste dodali novi rad!");
			this.Close();
		}
	}

	private void Autori_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Enter && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private bool IsValidUrl(string url)
	{
		return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
			   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
	}
}
