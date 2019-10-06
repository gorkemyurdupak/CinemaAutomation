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
    public partial class AdminPanel3 : Form
    {
        MyContext db;
        public AdminPanel3()
        {
            InitializeComponent();
        }
        public void ListMovie()
        {
            
        }
        private void btnFilmDuzenle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilmDüzenleme filmDuzenle = new FilmDüzenleme();
            filmDuzenle.Show();
        }

        private void AdminPanel3_Load(object sender, EventArgs e)
        {
            db = DBTool.DBInstance;
        }

        private void btnTürDüzenle_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FilmDüzenleme filmDuzenle = new FilmDüzenleme();
            //filmDuzenle.Show();
        }
    }
}
