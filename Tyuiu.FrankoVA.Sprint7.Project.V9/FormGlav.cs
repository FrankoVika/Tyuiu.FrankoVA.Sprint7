using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.FrankoVA.Sprint7.Project.V9
{
    public partial class FormGlav : Form
    {
        public FormGlav()
        {
            InitializeComponent();
           
        }

        private void buttonOpen_VA_Click(object sender, EventArgs e)
        {

            FormMain fmen = new FormMain();
            fmen.Visible = true;
            this.Visible = false;
            this.Close();
        }

        private void buttonGuide_VA_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormGuide fmen = new FormGuide();
            fmen.TopMost = true;
            fmen.ShowDialog();
        }

        private void buttonOProg_VA_Click(object sender, EventArgs e)
        {
            FormOProg fmen = new FormOProg();
            fmen.TopMost = true;
            fmen.ShowDialog();
        }

        private void buttonExit_VA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
