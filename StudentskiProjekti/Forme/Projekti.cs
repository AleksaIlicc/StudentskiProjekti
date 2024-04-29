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
    public partial class Projekti : Form
    {
        public Projekti()
        {
            InitializeComponent();
        }

        private void DodajPredmet_Btn_Click(object sender, EventArgs e)
        {

            DodajProjekat dodajProjekat = new DodajProjekat()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            dodajProjekat.ShowDialog();

        }

        private void IzmeniPredmet_Btn_Click(object sender, EventArgs e)
        {
            IzmeniProjekat izmeniProjekat = new IzmeniProjekat()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            izmeniProjekat.ShowDialog();
        }
    }
}
