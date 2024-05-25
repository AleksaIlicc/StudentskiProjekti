﻿using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;

public partial class OdabirProjektaUcesce : Form
{
    PredmetPregled pred = new PredmetPregled();
    StudentPregled sp = new StudentPregled();
    public OdabirProjektaUcesce(PredmetPregled pred, StudentPregled sp)
    {
        InitializeComponent();
        this.pred = pred;
        this.sp = sp;
    }

    private void OdabirProjektaUcesce_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
        Sifra_Lbl.Text = pred.Id;
        Naziv_Lbl.Text = pred.Naziv;
        Semestar_Lbl.Text = pred.Semestar.ToString();
        Katedra_Lbl.Text = pred.Katedra;
    }

    public void PopuniPodacima()
    {
        Projekti_ListV.Items.Clear();
        IList<ProjekatPregled> projekti = DTOManager.VratiProjekteZaPredmet(pred.Id);

        foreach (ProjekatPregled p in projekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta });
            item.Tag = p.Id;
            Projekti_ListV.Items.Add(item);
        }

        Projekti_ListV.Refresh();
    }

    private void IzaberiProjekat_Btn_Click(object sender, EventArgs e)
    {
        if (Projekti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat za koji zelite da dodate ucesce!");
            return;
        }
        this.Hide();
        PrakticniProjekatPregled pp = DTOManager.VratiPrakticniProjekat((int)Projekti_ListV.SelectedItems[0].Tag);
        TeorijskiProjekatPregled tp = DTOManager.VratiTeorijskiProjekat((int)Projekti_ListV.SelectedItems[0].Tag);

        if (pp != null)
        {
            DodajUcesce dodajUcesce = new DodajUcesce(pp, sp)
            {
                StartPosition = FormStartPosition.CenterParent,
                Owner = this
            };
            dodajUcesce.ShowDialog();
        }
        else if (tp != null)
        {
            DodajUcesce dodajUcesce = new DodajUcesce(tp, sp)
            {
                StartPosition = FormStartPosition.CenterParent,
                Owner = this
            };
            dodajUcesce.ShowDialog();
        }
        this.Close();
    }
}
