using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_Otomasyonu
{
    public partial class Form2 : Form
    {
        static string baglantiYolu = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Desktop\Kutuphane-Otomasyonu-master\KütüphaneBilgileri.mdb";
        static OleDbConnection baglanti = new OleDbConnection(baglantiYolu);
        private object dataGridView1;

        public Form2()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU PROGRAM BİLGİSAYAR MÜHENDİSLİĞİ ÖĞRENCİSİ CAN KOYUNCU TARAFINDAN YAPILMIŞTIR...");
        }

        private void hESAPMAKİNESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //label7.Text = DateTime.Now.ToString();
        }

        public void kitapListele()
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 yeni = new Form6();
            yeni.Show();
            this.Hide();
        }

        public void üyeleriListele()
        {
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            üyeleriListele();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 kapat = new Form2();
            kapat.Close();
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void kİTAPARAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 kapat = new Form2();
            kapat.Close();
            Form4 yeni = new Form4();
            yeni.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 kapat = new Form2();
            kapat.Close();
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
