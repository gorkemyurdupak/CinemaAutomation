using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.BLL.SingletonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.FormUI
{
    public partial class BuyTicket : Form
    {
        MovieRepository movp = new MovieRepository();
        Movie m = new Movie();
        MyContext db;
        SalonRepository salonrp = new SalonRepository();
        public BuyTicket()
        {
            InitializeComponent();
        }
        int sayac = 0;
        public void FilmAfisGoster()
        {
            pictureBox1.ImageLocation = m.ImagePath;
        }
        private void BuyTicket_Load(object sender, EventArgs e)
        {
            BosKoltuklar();
            cmbFilmAdı.DataSource = movp.SelectAll();
            cmbSalonGetir.DataSource = salonrp.SelectAll();


            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        foreach (Seat item in db.Seats.ToList())
            //        {
            //            Button btn = new Button();
            //            btn.Size = new Size(30, 30);
            //            if (item.IsEmpty == true)
            //            {
            //                btn.BackColor = Color.White;
            //            }
            //            else
            //            {
            //                btn.BackColor = Color.Red;
            //            }

            //            btn.Location = new Point(12 + j, 21 + i);

            //            btn.Text = $"{item.SeatLetter}{item.SeatNumber.ToString()}";
            //            //btn.Name = $"{item.SeatLetter}-{item.SeatNumber.ToString()}";

            //            if (j == 4)
            //            {
            //                continue;
            //            }



            //            this.panel1.Controls.Add(btn);
            //            btn.Click += Btn_Click;

            //            j++;
            //        }
            //    }
            //}


        }
        public void ComboDoluKoltuklar()
        {
            foreach (Control item in panel1.Controls)
            {
                cmbKoltukIptal.Items.Clear();
                cmbKoltukIptal.Text = "";
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        cmbKoltukIptal.Items.Add(item.Text);
                    }
                }
            }
        }
        public void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        public void DoluKoltuklar()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Red;
                }
            }
        }
        private void BosKoltuklar()
        {
            db = DBTool.DBInstance;

            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    btn.BackColor = Color.White;
                    if (j == 4)
                    {
                        continue;
                    }

                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor==Color.White)
            {
                cmbKoltukNo.Text = b.Text;
            }
        }

        private void cmbFilmAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmAfisGoster();
        }
    }
}

