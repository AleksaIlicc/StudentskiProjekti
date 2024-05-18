using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiProjekti.Forme
{
    public partial class PrakticniUcesceDetalji : Form
    {

        DTOs.StudentPregled sp = new DTOs.StudentPregled();
        DTOs.PrakticniProjekatPregled pp = new DTOs.PrakticniProjekatPregled();
        DTOs.ProjekatUcesceDetalji pd = new DTOs.ProjekatUcesceDetalji();
        public PrakticniUcesceDetalji(DTOs.StudentPregled sp, DTOs.PrakticniProjekatPregled pp, DTOs.ProjekatUcesceDetalji pd)
        {
            InitializeComponent();
            this.pp = pp;
            this.sp = sp;
            this.pd = pd;
        }


        private void PrakticniUcesceDetalji_Load(object sender, EventArgs e)
        {
            PopuniPodacimaLabele();
            if (pp.TipProjekta == "grupni")
            {
                PrikaziStudenteNaIstom_Btn.Visible = false;
                PopuniPodacimaListView();
            }
            else if (pp.TipProjekta == "pojedinacni")
            {
                OstaliClanovi_GB.Visible = false;
                OstaliClanovi_ListV.Visible = false;
            }

        }
        private void PopuniPodacimaLabele()
        {
            Naziv_LB.Text = pp.Naziv;
            DatumPocetka_LB.Text = pd.DatumPocetkaIzrade.ToString();
            DatumZavrsetka_LB.Text = pd.DatumZavrsetkaIzrade.ToString();
            RokZaZavrsetak_LB.Text = pd.RokZaZavrsetak.ToString();
            ProjekatZavrsen_LB.Text = pd.ProjekatZavrsen;
            SkolskaGodinaZad_LB.Text = pp.SkolskaGodinaZadavanja.ToString();
            OdabraniProgJezik_LB.Text = DTOManager.VratiOdabraniProgJezik(pp.Id, sp.BrIndeksa);
        }

        private void PopuniPodacimaListView()
        {
            OstaliClanovi_ListV.Items.Clear();
            List<DTOs.StudentPregled> studenti = DTOManager.VratiStudNaGrupnomProj(pp.Id);

            foreach (DTOs.StudentPregled s in studenti)
            {
                if (s.BrIndeksa == sp.BrIndeksa)
                {
                    continue;
                }
                ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.Prezime });
                OstaliClanovi_ListV.Items.Add(item);
            }

            OstaliClanovi_ListV.Refresh();
        }

        private void PrikaziStudenteNaIstom_Btn_Click(object sender, EventArgs e)
        {
            OstaliStudentiNaPProjektu studenti = new OstaliStudentiNaPProjektu(sp, pp)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            studenti.ShowDialog();
        }

        private void Izvestaji_Btn_Click(object sender, EventArgs e)
        {
            PredatiIzvestaji izvestaji = new PredatiIzvestaji()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            izvestaji.ShowDialog();
        }
    }
}
