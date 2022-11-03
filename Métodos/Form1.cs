using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex09Pag73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] vetor = new int[100];
        private void btngerar_Click(object sender, EventArgs e)
        {
            int i;

            Random numero = new Random();
            lst.Items.Clear();

            for (i = 0; i < vetor.Length; i++)
            {
                vetor[i] = numero.Next(100);
                lst.Items.Add(vetor[i].ToString("0"));
            }
        }

        private void btnmaior_Click(object sender, EventArgs e)
        {
            lblmaior.Text = vetor.Max().ToString();
        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            lblmenor.Text = vetor.Min().ToString();
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            lblmedia.Text = vetor.Average().ToString();
        }
    }   //Luis Henrique Salim Mendes
}
