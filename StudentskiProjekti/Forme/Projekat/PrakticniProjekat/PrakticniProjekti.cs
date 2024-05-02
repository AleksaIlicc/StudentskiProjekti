﻿using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class PrakticniProjekti : Form
{
	PredmetPregled izabraniPredmet;
	public PrakticniProjekti(DTOs.PredmetPregled predmet)
	{
		izabraniPredmet = predmet;
		InitializeComponent();
	}

	private void PrakticniProjekti_Load(object sender, EventArgs e)
	{
		PrakticniProjekti_ListV.Items.Clear();
		IList<PrakticniProjekatPregled> prakticniProjekat = DTOManager.VratiPrakticneProjekteZaPredmet(izabraniPredmet.Id);

		foreach (PrakticniProjekatPregled p in prakticniProjekat)
		{
			ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta, p.PreporuceniProgramskiJezik });
			PrakticniProjekti_ListV.Items.Add(item);
		}

		PrakticniProjekti_ListV.Refresh();
	}

	private void DodajProjekatP_Btn_Click(object sender, EventArgs e)
	{
		DodajPrakticniProjekat dodajPproj = new DodajPrakticniProjekat()
		{
			StartPosition = FormStartPosition.CenterParent
		};
		dodajPproj.ShowDialog();
	}

	private void IzmeniProjekatP_Btn_Click(object sender, EventArgs e)
	{
		IzmeniPrakticniProjekat izmeniPproj = new IzmeniPrakticniProjekat()
		{
			StartPosition = FormStartPosition.CenterParent
		};
		izmeniPproj.ShowDialog();
	}

	private void KratakOpis_Btn_Click(object sender, EventArgs e)
	{
		if (PrakticniProjekti_ListV.SelectedItems.Count == 0)
		{
			MessageBox.Show("Izaberite predmet koji zelite da izmenite!");
		}
		else
		{
			int.TryParse(PrakticniProjekti_ListV.SelectedItems[0].SubItems[0].Text, out int idProjekta);
			string opisProjekta = DTOManager.VratiOpisPrakticnogProjekta(idProjekta);
			MessageBox.Show(opisProjekta, "Kratak opis projekta");
		}
	}
}
