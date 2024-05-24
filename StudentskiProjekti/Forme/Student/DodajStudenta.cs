using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class DodajStudenta : Form
{
	StudentPregled student = new StudentPregled();
	public DodajStudenta()
	{
		InitializeComponent();
	}

	private void Dodaj_Btn_Click(object sender, EventArgs e)
	{
		string poruka = "Da li zelite da dodate novog studenta?";
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

			student.BrIndeksa = BrIndeksa_TB.Text;
			student.LIme = Ime_TB.Text;
			student.ImeRoditelja = ImeRoditelja_TB.Text;
			student.Prezime = Prezime_TB.Text;
			student.Smer = Smer_TB.Text;

			DTOManager.DodajStudenta(student);
			MessageBox.Show("Uspešno ste dodali novog studenta!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
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
