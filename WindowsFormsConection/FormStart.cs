using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConection
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void BtnEJ01_Click(object sender, EventArgs e)
        {
            var formConection = new FormEJ01();
            formConection.Show();
        }
        private void BtnEJ02_Click(object sender, EventArgs e)
        {
            var formConection = new FormEJ02();
            formConection.Show();
        }

        private void BtnEJ03_Click(object sender, EventArgs e)
        {
            var formConection = new FormEJ03();
            formConection.Show();
        }

        private void BtnEJ04_Click(object sender, EventArgs e)
        {
            var formConection = new FormEJ04();
            formConection.Show();
        }

        private void BtnEJ05_Click(object sender, EventArgs e)
        {
            var formConection = new FormEJ05();
            formConection.Show();
        }

        private void BtnEJ06_Click(object sender, EventArgs e)
        {
            var formConection = new FormEJ06_arquitectura_por_capas_DAL();
            formConection.Show();
        }

        private void BtnEJ06Extendido_Click(object sender, EventArgs e)
        {
            var formConection = new FormEJ06_extendido();
            formConection.Show();
        }

        private void BtnFormLINQ_Click(object sender, EventArgs e)
        {
            var formConection = new FormLINQ();
            formConection.Show();
        }
    }
}
