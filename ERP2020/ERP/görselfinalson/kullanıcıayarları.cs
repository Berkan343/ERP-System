using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace erp
{
    public partial class kullanıcıayarları : Form
    {
        public kullanıcıayarları()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = ERPSİSTEMİ; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("INSERT INTO kullanıcılar(kullanıcıad,kullanıcısifre,kullanıcıseviye)VALUES('" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "')", baglan);
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            komut.ExecuteNonQuery();
            SqlDataAdapter sqlda = new SqlDataAdapter(("Select * from kullanıcılar"), baglan);
            DataTable dtable = new DataTable();
            sqlda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglan.Close();
            foreach (DataRow drow in dtable.Rows)
            {
                listBox1.Items.Add(drow["kullanıcıad"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("DELETE FROM kullanıcılar WHERE kullanıcıad = ('" + textBox8.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(("Select * from kullanıcılar"), baglan);
            DataTable dtable = new DataTable();
            sqlda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglan.Close();
            listBox1.Items.Clear();
            foreach (DataRow drow in dtable.Rows)
            {
                listBox1.Items.Add(drow["kullanıcıad"]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("Update kullanıcılar set kullanıcıad=('" + textBox1.Text + "'),kullanıcısifre=('" + textBox2.Text + "'),kullanıcıadsoyad=('" + textBox3.Text + "'),kullanıcıno=('" + textBox4.Text + "'),kullanıcıeposta=('" + textBox7.Text + "',kullanıcıseviye=('" + comboBox2.Text + "')WHERE kullanıcıid='" + textBox9.Text + "'", baglan);
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(("Select * from kullanıcılar"), baglan);
            DataTable dtable = new DataTable();
            sqlda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglan.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from malzeme where malzemead=('" + textBox10.Text + "')", baglan);
                DataTable dtable = new DataTable();
                sqlda.Fill(dtable);
                dataGridView2.DataSource = dtable;
                baglan.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("INSERT INTO malzeme(malzemead,malzemetur,malzemekonum,malzemesorumlukisi,malzemedurum,malzemetarih,malzemediger)VALUES('" + textBox11.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox15.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')", baglan);
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            komut.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SqlCommand komut;
            komut = new SqlCommand("Update malzeme set malzemead=('" + textBox24.Text + "'),malzemetur=('" + textBox23.Text + "'),malzemekonum=('" + textBox22.Text + "'),malzemesorumlukisi=('" + textBox21.Text + "'),malzemedurum=('" + textBox20.Text + "',malzemetarih=('" + textBox19.Text + "',malzemediger=('" + textBox18.Text + "')WHERE malzemetur='" + textBox26.Text + "'", baglan);
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("DELETE FROM malzeme WHERE malzemead = ('" + textBox25.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = listBox1.SelectedItem.ToString();
        }
    }
}
