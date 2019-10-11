using Project.BLL.RepositoryPattern.ConcreteRepository;
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
    public partial class UpdateMovie : Form
    {
        MovieRepository movp = new MovieRepository();
        public UpdateMovie()
        {
            InitializeComponent();
        }
        Movie modifiye;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                modifiye = movp.GetByID(id);
                if (modifiye != null)
                {
                    modifiye.MovieName = txtName.Text;
                    modifiye.ScreenTime = Convert.ToInt32(txtTime.Text);
                    modifiye.ShowDate = Convert.ToDateTime(txtVisionDate.Text);
                    modifiye.Format = txtFormat.Text;
                    modifiye.Director = txtDirector.Text;
                    modifiye.Actors = txtActors.Text;
                    modifiye.MovieSummary = txtSummary.Text;
                    movp.Update(modifiye);
                    modifiye = null;

                    dataGridView1.ClearSelection();

                }
                else
                {
                    MessageBox.Show("Güncellenecek veriyi seçmemişsiniz");
                }

            }
        }
    }
}
