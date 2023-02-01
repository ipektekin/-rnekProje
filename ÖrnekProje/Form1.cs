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

        int üç;
        private void button3_Click(object sender, EventArgs e)
        {
            üç = 3;
        }

        int dört;
        private void button4_Click(object sender, EventArgs e)
        {
            dört = 4;
        }

        int beş;
        private void button5_Click(object sender, EventArgs e)
        {
            beş = 5;
        }

        int altı;
        private void button6_Click(object sender, EventArgs e)
        {
            altı = 6;
        }

        int yedi;
        private void button7_Click(object sender, EventArgs e)
        {
            yedi = 7;
        }

        int sekiz;
        private void button8_Click(object sender, EventArgs e)
        {
            sekiz = 8;
        }

        int dokuz;
        private void button9_Click(object sender, EventArgs e)
        {
            dokuz = 9;
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
                int toplam = bir + iki + üç + dört + beş + altı + yedi + sekiz + dokuz;
                sonuctextbox.Text = Convert.ToString(toplam);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SıfırlaButon_Click(object sender, EventArgs e)
        {
            bir = 0; iki = 0; üç = 0; dört = 0; beş = 0; altı = 0; yedi = 0; sekiz = 0; dokuz = 0;
            işlem = "";
            sonuctextbox.Text = "";
        }
    
}
