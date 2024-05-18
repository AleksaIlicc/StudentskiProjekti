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
    public partial class OstaliIzvestaji : Form
    {
        DTOs.PrakticniProjekatPregled pp = new DTOs.PrakticniProjekatPregled();
        DTOs.StudentPregled sp = new DTOs.StudentPregled();
        public OstaliIzvestaji(DTOs.PrakticniProjekatPregled pp, DTOs.StudentPregled sp)
        {
            InitializeComponent();
            this.pp = pp;
            this.sp = sp;
        }

        private void OstaliIzvestaji_Load(object sender, EventArgs e)
        {
            PopuniPodacimaListView();
        }

        private void PopuniPodacimaListView()
        {
            Izvestaji_ListV.Items.Clear();

            List<DTOs.StudentPregled> studenti = DTOManager.VratiStudNaGrupnomProj(pp.Id);

            foreach (DTOs.StudentPregled student in studenti)
            {
                if (student.BrIndeksa == sp.BrIndeksa)
                {
                    continue;
                }
                List<DTOs.IzvestajPregled> izvestaji = DTOManager.VratiIzvestajeZaStudenta(student.BrIndeksa , pp.Id);

                foreach (DTOs.IzvestajPregled izvestaj in izvestaji)
                {
                    ListViewItem item = new ListViewItem(new string[] { student.BrIndeksa, student.LIme, student.Prezime,
                                                                  izvestaj.DatumPocIzrade.ToString("dd.MM.yyyy"),
                                                                  izvestaj.DatumZavrIzrade?.ToString("dd.MM.yyyy"),
                                                                  izvestaj.RokZaZavr.ToString("dd.MM.yyyy") });
                    item.Tag = izvestaj.OpisIzvest;
                    Izvestaji_ListV.Items.Add(item);
                }
            }
            Izvestaji_ListV.Refresh();
        }

        private void Izvestaji_ListV_DoubleClick(object sender, EventArgs e)
        {
            if (Izvestaji_ListV.SelectedItems.Count > 0)
            {
                string opisIzvestaja = Izvestaji_ListV.SelectedItems[0].Tag as string;
                MessageBox.Show(opisIzvestaja, "Opis izveštaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
