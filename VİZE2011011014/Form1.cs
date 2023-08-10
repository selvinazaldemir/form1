using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VİZE2011011014
{
    public partial class SENCE : Form
    {
        public SENCE()
        {
            InitializeComponent();
        }

        private void bt_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" Bilgisayar Mühendisliği ");

            comboBox1.Items.Add(" Bilgisayar Mühendisliği ");
            comboBox1.Items.Add(" Bilgisayar Mühendisliği (İÖ) ");
            comboBox1.Items.Add(" Çevre Mühendisliği ");
            comboBox1.Items.Add(" Elektrik Elektronik Mühendisliği ");
            comboBox1.Items.Add(" Elektrik Elektronik Mühendisliği (İÖ)");
            comboBox1.Items.Add(" Endüstri Mühendisliği ");
            comboBox1.Items.Add(" Endüstri Mühendisliği (İÖ)");
            comboBox1.Items.Add(" Gıda Mühendisliği ");
            comboBox1.Items.Add(" İnşaat Mühendisliği ");
            comboBox1.Items.Add(" Jeoloji Mühendisliği ");

            comboBox1.Items.Add(" Kimya Mühendisliği ");
            comboBox1.Items.Add(" Maden Mühendisliği ");
            comboBox1.Items.Add(" Makina Mühendisliği ");
            comboBox1.Items.Add(" Otomotiv Mühendisliği ");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add(" Hazırlık");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");

        }

       

       

        private void bt_onayla_Click(object sender, EventArgs e)
        {
           
            {
                if (tb_ad.Text == "") 
                    MessageBox.Show("İsim Alanı Boş Geçilemez!!", " HATA", MessageBoxButtons.OK , MessageBoxIcon.Error);              
                else  if (tb_soyad.Text == "")        
                    MessageBox.Show("Soyad Alanı Boş Geçilemez!!", " HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                else if (tb_no.Text == "")      
                    MessageBox.Show("Numara Alanı Boş Geçilemez!!", " HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);        
                else                 
                {        
                    Form2 frm = new Form2();            
                    frm.ShowDialog();               
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                panelanket.Visible = true;
                panel1.Enabled = false;
            }
            else
            panelanket.Visible = false;
            panel1.Enabled = true;
             
        }

       
    }
}







