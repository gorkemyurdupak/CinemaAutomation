using Project.BLL.RepositoryPattern.ConcreteRepository;
using Sinema_Programı;
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
    public partial class HomePage2 : Form
    {
        AppUserRepository aprep = new AppUserRepository();
        public HomePage2()
        {
            InitializeComponent();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            if (aprep.Any(x=> x.UserRole==MODEL.Enums.Role.Admin))
            {
                this.Hide();
                AdminPanel3 adp = new AdminPanel3();
                adp.Show();
            }
            else
            {
                MessageBox.Show("Bu alana girme yetkiniz bulunmamaktadır.");
            }
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinemaRezervasyonProjesi bt = new SinemaRezervasyonProjesi();
            bt.Show();
        }
    }
}
