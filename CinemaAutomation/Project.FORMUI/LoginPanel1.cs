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
    public partial class LoginPanel1 : Form
    {
        MyContext db = DBTool.DBInstance;
        EmployeeRepository emprep;
        AppUserRepository aprep;

        public void ListEmployees()
        {
            db.Employees.ToList();
        }

        public LoginPanel1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
            {
                string userName = txtUser.Text;
                string password = txtPass.Text;

                if (aprep.Any(x => x.UserName == userName) && aprep.Any(x => x.Password == password))
                {
                    AppUser yakalanan=aprep.Default(x=> x.UserName==userName&& x.Password==password);
                    if (yakalanan.UserRole==MODEL.Enums.Role.SuperAdmin)
                    {
                        this.Hide();
                        SuperAdminPanel sp = new SuperAdminPanel();
                        sp.Show();
                    }
                    else if (yakalanan.UserRole == MODEL.Enums.Role.Admin)
                    {
                        this.Hide();
                        FilmDüzenleme admp = new FilmDüzenleme();
                        admp.Show();
                    }
                    else
                    {
                        this.Hide();
                        HomePage2 h = new HomePage2();
                        h.Show();
                    }
                          
                  
                }
                else if (aprep.Any(x => x.UserName == userName) && (aprep.Any(x => x.Password != password)))
                {
                    MessageBox.Show("Şifreniz hatalıdır.Lütfen şifrenizi kontrol ediniz.");
                    Temizle();
                }
                else if (aprep.Any(x => x.UserName != userName) && (aprep.Any(x => x.Password == password)))
                {
                    MessageBox.Show("Kullanıcı adınız hataılıdır.Lütfen kullanıcı adınıız kontrol ediniz.");
                    Temizle();

                }
                else if (userName == String.Empty && password == String.Empty)
                {
                    MessageBox.Show("Lütfen alanları doldurunuz.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen doğru bilgileri giriniz.");
            }
        }

        public void Temizle()
        {
            txtUser.Clear();
            txtPass.Clear();
        }
        private void LoginPanel1_Load(object sender, EventArgs e)
        {
            emprep = new EmployeeRepository();
            aprep = new AppUserRepository();
        }
    }
}
