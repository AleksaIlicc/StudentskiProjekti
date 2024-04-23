using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiProjekti
{
    public partial class StudentskiProjekti : Form
    {
        public StudentskiProjekti()
        {
            InitializeComponent();
        }

        private void prodavnica_btn_clk(object sender, EventArgs e)
        {
                Forme.Predmeti Predmeti = new();
                Predmeti.ShowDialog(); 
        }
    }
}
