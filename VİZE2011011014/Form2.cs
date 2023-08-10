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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Anket Tamamlanmıştır. İlginiz İçin Teşekkürler " );
        }

        private void bt_kapa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
