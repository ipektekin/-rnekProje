using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖrnekProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona Basıldı");

            this.Close();
        }

        int bir;
        private void button2_Click(object sender, EventArgs e)
        {
            bir = 1;
        }
        int iki;
        private void Buton2_Click(object sender, EventArgs e)
        {
            iki = 2;
        }

        string işlem ;
        private void ToplaButon_Click(object sender, EventArgs e)
        {
            işlem = "topla";
        }

        private void HesaplaButon_Click(object sender, EventArgs e)
        {
            if(işlem == "topla")
            {
                sonuctextbox.Text = Convert.ToString(bir + iki);
            }
        }
    }
}
