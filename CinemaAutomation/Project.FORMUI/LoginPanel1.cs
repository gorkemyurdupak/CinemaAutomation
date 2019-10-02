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
        MyContext db;
        EmployeeRepository emprep;
        public LoginPanel1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUser.Text!=string.Empty&& txtPass.Text!=string.Empty)
            {
                string UserName = txtUser.Text;
                string password = txtPass.Text;
                if (emprep.Any(x => x.EmpUserName == UserName) && (emprep.Any(x => x.Password==password)))
                {
                    MessageBox.Show("Helal beee giriş başarılı");
                }
                else if (emprep.Any(x=> x.EmpUserName==UserName)&&(emprep.Any(x=> x.Password!=password)))
                {
                    MessageBox.Show("Şifreniz hatalıdır.Lütfen şifrenizi kontrol ediniz.");
                    Temizle();
                }
                else if (emprep.Any(x=> x.EmpUserName!=UserName)&&(emprep.Any(x=> x.Password==password)))
                {
                    MessageBox.Show("Kullanıcı adınız hataılıdır.Lütfen kullanıcı adınıız kontrol ediniz.");
                    Temizle();
                   
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız.Lütfen bilgilerinizi kontrol ediniz.");
                }

            }
        }

        public void Temizle()
        {
            txtUser.Clear();
            txtPass.Clear();
        }
        private void LoginPanel1_Load(object sender, EventArgs e)
        {
            db = DBTool.DBInstance;
            emprep = new EmployeeRepository();
        }
    }
}
