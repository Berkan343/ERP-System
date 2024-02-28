using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
        }
        kullanıcıayarları formkullanıcı = new kullanıcıayarları();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "berkansukut" && textBox2.Text == "716953")
            {
                formkullanıcı.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yapıldı.");
            }
        }
    }
}
