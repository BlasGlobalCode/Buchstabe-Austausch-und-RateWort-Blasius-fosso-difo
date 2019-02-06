using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DritteKA_HbFIa_2019
{
    public partial class Form1 : Form
    {
        string[] x;
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Herzlich Willkommen","Begrüßung",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
            txteingabe.MaxLength = 10;
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string eing = txteingabe.Text.ToUpper();
                string zuersetzen = txtzuersetzen.Text.ToUpper();
                for (int i = 0; i < eing.Length; i++)
                {
                //ersetzenden Buchstaben
                    if (zuersetzen.Contains(eing[i].ToString()))
                    {
                        eing = eing.Remove(i,1);
                        eing = eing.Insert(i,txtBuchs2.Text);
                        //i--;
                    }
                }
                txteingabe.Text = eing.ToUpper();
            }
            catch (Exception)
            {
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            pnlGast2.Visible = false;
        }

        private void btnstarten_Click(object sender, EventArgs e)
        {
            x = new string[txtWort.Text.Length];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = "_";
            }

            txtWort.Enabled = false;
            pnlGast1.Visible = false;
            pnlGast2.Visible = true;
            lbleinzelneBuchstaben.Text.Length.ToString(txtWort.Text);
        }

        private void btnausführen_Click(object sender, EventArgs e)
        {


            string Wort = txtWort.Text;
            string einzelneBuchstaben = lbleinzelneBuchstaben.Text;
            txtzumRaten.MaxLength = 1;
            string ZumRaten = txtzumRaten.Text;
            for (int i = 0; i < Wort.Length; i++)
            {
                if (ZumRaten.Contains(Wort[i].ToString()))
                {
                    x[i] = ZumRaten;
                }

            }
            lbleinzelneBuchstaben.Text = "";
            for (int i = 0; i < x.Length; i++)
            {
                lbleinzelneBuchstaben.Text += x[i].ToString();
            }
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
			txtWort.Text = "";
			txtzumRaten.Text = "";
			lbleinzelneBuchstaben.Text = "";
			//this.Show();

        }
    }
}

