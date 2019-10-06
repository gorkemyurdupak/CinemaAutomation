using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.BLL.SingletonPattern;
using Project.DAL.Context;
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

        }
    }
}
