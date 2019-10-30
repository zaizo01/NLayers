using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayers
{
    public partial class Form1 : Form
    {
        NLayers.Class_E obje = new NLayers.Class_E();
        NLayers.Class_N objn = new NLayers.Class_N();


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.user = tbuser.Text;
            obje.pass = tbpass.Text;
            dt = objn.N_login(obje);

            if (dt.Rows.Count > 0) {
                obje.user = dt.Rows[0][0].ToString();
                obje.pass = dt.Rows[0][1].ToString();
                MessageBox.Show("welcome " + obje.user);

                this.Hide();
                welcome xd = new welcome();
                xd.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
