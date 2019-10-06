using Project.BLL.RepositoryPattern.ConcreteRepository;
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
    public partial class AddMovie : Form
    {
        MovieRepository mvp = new MovieRepository();
        public AddMovie()
        {
            InitializeComponent();
        }

        public void FilmEkle()
        {
            Movie m = new Movie();
            m.MovieName = txtName.Text;
            m.ShowDate = Convert.ToDateTime(txtShowDate.Text);
            m.MovieSummary = txtSum.Text;
            m.Format = txtFormat.Text;
            m.ScreenTime = Convert.ToInt32(txtTime.Text);
            m.Director = txtDirector.Text;
            m.Actors = txtActors.Text;
            m.ImagePath = pcAfis.ImageLocation;
            
            mvp.Add(m);
            mvp.Save();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FilmEkle();
        }

        private void cmbFilmTur_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        GenreRepository grp = new GenreRepository();
        private void AddMovie_Load(object sender, EventArgs e)
        {
             
            cmbFilmTur.DataSource = grp.SelectAll();
        }
    }
}
