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

namespace GorselP3Ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=gorsel3kelimetahmin;Integrated Security=True");
        string kelime = "";
        string gizli = "";
        string yeni = "";

        private void btnKelimeGetir_Click(object sender, EventArgs e)
        {
            string sql = "Select * from kelimeler";
            SqlDataAdapter da = new SqlDataAdapter(sql,bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int satirsayi = dt.Rows.Count;

            Random rnd = new Random();
            int indexnumber = rnd.Next(0,satirsayi);
            if (checkBoxEN.Checked)
            {
                kelime = dt.Rows[indexnumber][2].ToString();
            }
            else
            {
                kelime = dt.Rows[indexnumber][1].ToString(); 
            }
            kelime = kelime.Trim();
            foreach (var item in kelime)
            {
                gizli += "*";
            }
            lblKelime.Text = gizli;
            btnKelimeGetir.Enabled = false;

            
        }

        private void btnDene_Click(object sender, EventArgs e)
        {
            yeni = "";
            char karakter=Convert.ToChar(txtHarf.Text);
            txtHarf.Clear();
            for (int i = 0; i < kelime.Length; i++)
            {
                if (karakter == kelime[i])
                {
                    yeni += kelime[i];
                }
                else
                {
                    yeni += gizli[i];
                }
            }
            gizli=yeni;
            lblKelime.Text = gizli;
            if (kelime==lblKelime.Text)
            {
                MessageBox.Show("Tebrikler");
            }
        }
    }
}
