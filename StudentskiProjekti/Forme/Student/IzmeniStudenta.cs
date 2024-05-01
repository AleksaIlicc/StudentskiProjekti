using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class IzmeniStudenta : Form
{
	StudentPregled sp;
	public IzmeniStudenta(StudentPregled sp)
	{
		InitializeComponent();
		this.sp = sp;
	}

	private void IzmeniStudenta_Load(object sender, EventArgs e)
	{
		PopuniPodacima();
		this.Text = $"Azuriranje studenta {this.sp.BrIndeksa}";
	}

	public void PopuniPodacima()
	{
		BrIndeksa_TB.Text = this.sp.BrIndeksa;
		Ime_TB.Text = this.sp.LIme;
		ImeRoditelja_TB.Text = this.sp.ImeRoditelja;
		Prezime_TB.Text = this.sp.Prezime;
		Smer_TB.Text = this.sp.Smer;
	}
	private void Izmeni_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da izvrsite izmene studenta?";
		string title = "Pitanje";
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
		DialogResult result = MessageBox.Show(poruka, title, buttons);
		if (result == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(BrIndeksa_TB.Text))
			{
				MessageBox.Show("Morate uneti broj indeksa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(Ime_TB.Text))
			{
				MessageBox.Show("Morate uneti ime studenta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(Prezime_TB.Text))
			{
				MessageBox.Show("Morate uneti prezime studenta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (DTOManager.VratiStudenta(BrIndeksa_TB.Text) == null || DTOManager.VratiStudenta(BrIndeksa_TB.Text).BrIndeksa == this.sp.BrIndeksa)
			{
				this.sp.BrIndeksa = BrIndeksa_TB.Text;
				this.sp.LIme = Ime_TB.Text;
				this.sp.ImeRoditelja = ImeRoditelja_TB.Text;
				this.sp.Prezime = Prezime_TB.Text;
				this.sp.Smer = Smer_TB.Text;

				DTOManager.AzurirajStudenta(this.sp);
				MessageBox.Show("Azuriranje studenta je uspesno izvrseno!");
				this.Close();
			}
			else
			{
				MessageBox.Show("Azuriranje studenta nije uspesno, student sa tim brojem indeksa vec postoji!");
			}
		}
	}

	private void Ime_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void ImeRoditelja_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void Prezime_TB_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}
}
