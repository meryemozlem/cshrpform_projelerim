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

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kapsam alanı dışı. Scopalanı.
        SqlConnection baglanti = new SqlConnection("Data Source=AYDOGAN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        void temizle()
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbSehir.Text = "";
            MskMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtMeslek.Text = "";
            TxtAd.Focus();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            //normalde this kodu burada. Ama ben açılır açılmaz verilerin görünmesini istemiyorum. BtnListele içine attım.
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //Listeleye bastığında veriler çıkacak.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (perAd,perSoyad,perŞehir,perMaaş,perMeslek,perDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5",TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text ="False";
            }
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            { 
               label8.Text = "True";
            }
            
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            //label8 deki metin değiştiğinde ne olsun?

            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel where Personelid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1" , Txtid.Text);
            komutsil.ExecuteNonQuery(); 
            // insert delete ve update de kullanılan komut çalıştırma kodu.
            baglanti.Close();

            MessageBox.Show("Kayıt silindi");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1, PerSoyad=@a2, PerŞehir=@a3,PerMaaş=@a4,PerDurum=@a5,PerMeslek=@a6 where Personelid=@a7 ", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1",TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2",TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3",CmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", MskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txtid.Text);

            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgi güncellendi");
        }
    }
}