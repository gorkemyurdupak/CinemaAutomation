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
    public partial class FilmDüzenleme : Form
    {
        MovieRepository mp = new MovieRepository();
        public FilmDüzenleme()
        {
            InitializeComponent();
        }

        public void ListMovies()
        {
            dataFilmSırala.DataSource = mp.SelectActives();
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel3 admp = new AdminPanel3();
            admp.Show();
        }

        private void FilmDüzenleme_Load(object sender, EventArgs e)
        {
            ListMovies();
            
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            AddMovie adm = new AddMovie();
            adm.Show();
            ListMovies();

        }
        Movie modifiye;
        
        private void FilmSil_Click(object sender, EventArgs e)
        {
            if (dataFilmSırala.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataFilmSırala.SelectedRows[0].Cells[1].Value);

                modifiye = mp.GetByID(id);
                if (modifiye != null)
                {
                    mp.Delete(modifiye);
                    modifiye = null;
                    ListMovies();
                    dataFilmSırala.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Silinecek veriyi seçmemişsiniz");
                }
                ListMovies();

            }
            
           
        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {
            
            UpdateMovie upm = new UpdateMovie();
            upm.Show();
            foreach (Control item in upm.Controls)
            {
                if (item.Name=="txtName")
                {
                    item.Text= dataFilmSırala.SelectedRows[0].Cells[2].Value.ToString();
                }
                if (item.Name=="txtTime")
                {
                    item.Text= dataFilmSırala.SelectedRows[0].Cells[3].Value.ToString();
                }
                if (item.Name=="txtVisionDate")
                {
                    item.Text= dataFilmSırala.SelectedRows[0].Cells[4].Value.ToString();
                }
                if (item.Name=="txtFormat")
                {
                    item.Text= dataFilmSırala.SelectedRows[0].Cells[8].Value.ToString();
                }
                if (item.Name=="txtDirector")
                {
                    item.Text= dataFilmSırala.SelectedRows[0].Cells[6].Value.ToString();
                }
                if (item.Name == "txtActors")
                {
                    item.Text = dataFilmSırala.SelectedRows[0].Cells[7].Value.ToString();
                }
                if (item.Name == "txtSummary")
                {
                    item.Text = dataFilmSırala.SelectedRows[0].Cells[9].Value.ToString();
                }
            }

        }
    }
}
