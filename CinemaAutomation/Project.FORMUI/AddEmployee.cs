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
    public partial class AddEmployee : Form
    {
        MyContext db = DBTool.DBInstance;
        EmployeeRepository emp = new EmployeeRepository();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
