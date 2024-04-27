﻿using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class Predmeti : Form
{
    public Predmeti()
    {
        InitializeComponent();
    }
    private void Predmeti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {

        Predmeti_ListV.Items.Clear();
        List<PredmetPregled> predmeti = DTOManager.VratiSvePredmete();
        predmeti = predmeti.OrderBy(p => p.Naziv).ToList();

        foreach (PredmetPregled p in predmeti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Semestar.ToString(), p.Katedra });
            Predmeti_ListV.Items.Add(item);
        }

        Predmeti_ListV.Refresh();
    }
    private void DodajPredmet_Btn_Click(object sender, EventArgs e)
    {
        DodajPredmet dodajPredmet = new DodajPredmet()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajPredmet.ShowDialog();
        this.PopuniPodacima();
    }
    private void IzmeniPredmet_Btn_Click(object sender, EventArgs e)
    {

        if (Predmeti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet koji zelite da izmenite!");
        }
        else
        {
            string idPredmeta = Predmeti_ListV.SelectedItems[0].SubItems[0].Text;
            PredmetPregled ob = DTOManager.VratiPredmet(idPredmeta);

            IzmeniPredmet formaUpdate = new IzmeniPredmet(ob)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            formaUpdate.ShowDialog();

            this.PopuniPodacima();
        }
    }

    private void ObrisiPredmet_Btn_Click(object sender, EventArgs e)
    {
        if (Predmeti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite predmet koji zelite da obrisete!");
            return;
        }

        string idPredmeta = Predmeti_ListV.SelectedItems[0].SubItems[0].Text;
        string poruka = "Da li zelite da obrisete izabrani predmet?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
			DTOManager.ObrisiPredmet(idPredmeta);
            MessageBox.Show("Brisanje predmeta je uspesno obavljeno!");
            this.PopuniPodacima();
        }
        else
        {

        }
    }

}

