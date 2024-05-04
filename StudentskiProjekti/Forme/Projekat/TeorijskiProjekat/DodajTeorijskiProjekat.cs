﻿using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class DodajTeorijskiProjekat : Form
{
    TeorijskiProjekatPregled projekat = new TeorijskiProjekatPregled();
    public DodajTeorijskiProjekat(PredmetPregled predmet)
    {
        InitializeComponent();
        projekat.PripadaPredmetu = predmet;
    }
    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novi teorijski projekat?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            this.projekat.Naziv = Naziv_TB.Text;
            this.projekat.SkolskaGodinaZadavanja = SkoslaGodIzdavanja_TB.Text;
            if (Pojedinacni_RB.Checked)
            {
                this.projekat.TipProjekta = "pojedinacni";
            }
            else if (Grupni_RB.Checked)
            {
                this.projekat.TipProjekta = "grupni";
            }
            this.projekat.MaksBrojStrana = int.TryParse(MaxBrStranica_TB.Text, out int maksBrojStranica) ? maksBrojStranica : default(int);
            this.projekat.VrstaProjekta = "teorijski";

            DTOManager.DodajTeorijskiProjekat(projekat);
            MessageBox.Show("Uspesno ste dodali novi projekat!");
            this.Close();
        }
    }

    private void SkoslaGodIzdavanja_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
        {
            e.Handled = true;
        }
    }

    private void MaxBrStranica_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }
}

