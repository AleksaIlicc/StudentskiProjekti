using StudentskiProjekti.Entiteti;
using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class DodajKnjigu : Form
{
	KnjigaPregled knjiga = new KnjigaPregled();
	int projekatId;
	public DodajKnjigu(int projekatId)
	{
		InitializeComponent();
		this.projekatId = projekatId;
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novu knjigu?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);

		if (result == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(ISBN_TB.Text))
			{
				MessageBox.Show("Morate uneti ISBN knjige!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(Naziv_TB.Text))
			{
				MessageBox.Show("Morate uneti naziv knjige!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (int.TryParse(GodinaIzdanja_TB.Text, out int godinaIzdanja))
			{
				if (godinaIzdanja < 1900 || godinaIzdanja > DateTime.Now.Year)
				{
					MessageBox.Show($"Godina izdanja knjige mora biti broj izmedju 1900 i {DateTime.Now.Year} godine!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				knjiga.GodinaIzdanja = godinaIzdanja;
			}

			knjiga.ISBN = ISBN_TB.Text;
			knjiga.Naziv = Naziv_TB.Text;
			knjiga.Izdavac = Izdavac_TB.Text;

			List<AutorPregled> autori = new List<AutorPregled>();

			string[] unosiAutora = Autori_TB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string unosAutora in unosiAutora)
			{
				string detaljiAutora = unosAutora.Trim();
				AutorPregled noviAutor = new AutorPregled(detaljiAutora);
				autori.Add(noviAutor);
			}

			DTOManager.DodajKnjigu(projekatId, knjiga, autori);
			MessageBox.Show("Uspesno ste dodali novu knjigu!");
			this.Close();
		}
	}

	private void ISSN_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Autori_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Enter && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Godina_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}
}
