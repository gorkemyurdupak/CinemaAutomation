using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.DAL.Context;
using Project.FormUI;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinema_Programı
{
    public partial class SinemaRezervasyonProjesi : Form
    {
        public SinemaRezervasyonProjesi()
        {
            InitializeComponent();
        }

        MovieRepository movp = new MovieRepository();
        Movie m = new Movie();
        MyContext db;
        SalonRepository salonrp = new SalonRepository();
        string ad, soyad;
        int koltukno, sayac =0, boskoltuk = 35, dolukoltuk = 0;
        Ticket t = new Ticket();
        TicketRepository trep = new TicketRepository();
        SeansRepository srep = new SeansRepository();


        int[] dolukoltukdizi = new int[0];

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (textisim.Text == "" || txtsoyisim.Text == "" || txtkoltukno.Text == "") MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!(rderkek.Checked || rdkadin.Checked)) MessageBox.Show("Lütfen cinsiyet seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                try
                {

                    ad = textisim.Text;
                    soyad = txtsoyisim.Text;
                    koltukno = Convert.ToInt32(txtkoltukno.Text);

                    if (koltukno < 1 || koltukno > 35)
                    {
                        MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtkoltukno.Text = "";
                    }
                    else
                    {
                       
                        if (Array.IndexOf(dolukoltukdizi, koltukno) == -1)
                        {
                          
                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;

                            if (koltukara != null)
                            {
                                koltukara.Text += "\r" + ad + " " + soyad; 
                                koltukara.BackColor = Color.GreenYellow;
                                dolukoltuk++; 
                                boskoltuk--; 

                                Array.Resize(ref dolukoltukdizi, dolukoltukdizi.Length+1);
                                dolukoltukdizi[sayac] = koltukno;
                                sayac++;

                                lbldolu.Text = dolukoltuk.ToString(); 
                                lblbos.Text = boskoltuk.ToString();   

                                textisim.Text = "";    
                                txtsoyisim.Text = "";
                                txtkoltukno.Text = "";


                                Image erkek = Image.FromFile("İconlar/E.png");
                                Image kadin = Image.FromFile("İconlar/K.png");
                                if (rdkadin.Checked)
                                {
                                    koltukara.Image = kadin;
                                }
                                else
                                {
                                    koltukara.Image = erkek;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girmiş olduğunuz koltuk numarasına ait koltuk dolu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkoltukno.Text = "";
                        }
                    }
                }
               
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtkoltukno.Text = "";
                }
            }
        }

        private void btniptalet_Click(object sender, EventArgs e)
        {
            try
            {
                    koltukno = Convert.ToInt32(txtiptalkoltukno.Text);
                  
                    if (koltukno < 1 || koltukno > 35)
                    {
                    MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtiptalkoltukno.Text = "";
                    }

                    else
                    {
                        if (Array.IndexOf(dolukoltukdizi, koltukno) != -1)
                        {

                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;
                            if (koltukara != null) 
                            {
                                koltukara.Text = koltukno + ".koltuk"; 
                                koltukara.BackColor = Color.FloralWhite;   
                                dolukoltuk--;                         
                                boskoltuk++;                           

                                int sirano = Array.IndexOf(dolukoltukdizi, koltukno); 
                                Array.Clear(dolukoltukdizi, sirano, 1);

                                lbldolu.Text = dolukoltuk.ToString();
                                lblbos.Text = boskoltuk.ToString();
                                txtiptalkoltukno.Text = "";

                                Image bos_koltuk = Image.FromFile("İconlar/VarsayılanKoltuk.png");
                                koltukara.Image = bos_koltuk; 
                            }
                        }
                        else
                        {
                            MessageBox.Show("İptal edilmek istenen koltuk zaten boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtiptalkoltukno.Text = "";
                        }
                   }

               }

                catch (Exception)
                {
                MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtiptalkoltukno.Text = "";
                }
        }

        private void anaEkranaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage2 geri = new HomePage2();
            this.Hide();
            geri.Show();
        }

        private void btnbilet_Click(object sender, EventArgs e)
        {
           
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gelistiriciler_Click(object sender, EventArgs e)
        {
           
        }
        
        private void programKullanımıHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           lbldolu.Text = dolukoltuk.ToString();
           lblbos.Text = boskoltuk.ToString();
            foreach (var item in Enum.GetValues(typeof(TicketGenre)))
            {
                comboBox1.Items.Add(item);
            }
            cmbFilmİsmi.DataSource = movp.SelectActives();
            foreach (Seans item in srep.SelectActives().ToList())
            {
                cmbFilmTarihi.Items.Add(item.ToString().Substring(0, 10));
            }

            foreach (Seans item in srep.SelectActives().ToList())
            {
                cmbSeansGetir.Items.Add(item.ToString().Substring(11, 5));
            }
            cmbSalonGetir.DataSource = salonrp.SelectActives();
            //cmbKoltukNo.SelectedIndex.ToString() = txtkoltukno.Text;
        }       
        public void FilmAfisGoster()
        {
            pictureBox1.ImageLocation = m.ImagePath;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnÖdeme_Click(object sender, EventArgs e)
        {
            Salon s = new Salon();
            Seat set = new Seat();

            //s.SalonNumber = cmbSalonGetir.SelectedItem.ToString(); //buraya bi el atılsın
            m.MovieName = cmbFilmİsmi.SelectedItem.ToString();
            //set.SeatNumber = Convert.ToInt16(txtkoltukno.Text.ToString());
            
            comboBox1.DataSource = Enum.GetValues(typeof(TicketGenre));
            TicketGenre ticketGenre;
            Enum.TryParse<TicketGenre>(comboBox1.SelectedValue.ToString(),out ticketGenre);
            nmbSayı.Value = t.TicketCount;


            MessageBox.Show(m.MovieName);
            MessageBox.Show(s.SalonNumber.ToString());
            MessageBox.Show(set.SeatNumber.ToString());
            MessageBox.Show(comboBox1.DataSource.ToString());
            MessageBox.Show(set.SeatNumber.ToString());

        }

        private void cmbFilmİsmi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                cmbKoltukNo.Text = b.Text;
            }
        }

        private void cmbFilmAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmAfisGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
