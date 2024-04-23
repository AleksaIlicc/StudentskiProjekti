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
    public partial class Predmeti : Form
    {
        public Predmeti()
        {
            InitializeComponent();
        }


        private void DodajPredmetBtn_Click(object sender, EventArgs e)
        {
            DodajPredmet DodajPred = new();
            DodajPred.StartPosition = FormStartPosition.CenterParent;
            DodajPred.ShowDialog();
        }
    }
}
