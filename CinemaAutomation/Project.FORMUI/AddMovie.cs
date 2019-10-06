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
using System.Drawing.Imaging;
using System.Text.RegularExpressions;


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
            Genre g = new Genre();
            Movie m = new Movie();
            m.MovieName = txtName.Text;
            m.ShowDate = Convert.ToDateTime(txtShowDate.Text);
            m.MovieSummary = txtSum.Text;
            m.Format = txtFormat.Text;
            m.ScreenTime = Convert.ToInt32(txtTime.Text);
            m.Director = txtDirector.Text;
            m.Actors = txtActors.Text;
            string path = pcAfis.ImageLocation;
            string newPath = path.Remove(0, 102).Replace("\\", " /");
            //pcAfis.ImageLocation = newPath;
            m.ImagePath = newPath;
            m.GenreID = cmbFilmTur.SelectedIndex;
            g.GenreID = m.GenreID;
            mvp.Add(m);
           
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FilmEkle();
        }
        GenreRepository grp = new GenreRepository();
        public void AddMovie_Load(object sender, EventArgs e)
        {
             
            cmbFilmTur.DataSource = grp.SelectAll();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            pcAfis.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            pcAfis.Image = Image.FromFile(op.FileName);
            pcAfis.ImageLocation = op.FileName;


        }
    }
}
