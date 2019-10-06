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
    public partial class SuperAdminPanel : Form
    {
        MyContext db = DBTool.DBInstance;
        EmployeeRepository emp = new EmployeeRepository();
        public SuperAdminPanel()
        {
            InitializeComponent();
        }
        public void ListEmployee()
        {
            lstEmployee.DataSource = emp.SelectActives();
        }
        private void SuperAdminPanel_Load(object sender, EventArgs e)
        {
            ListEmployee();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {

            //Employee employee = new Employee();
            //employee.EmpFirstName = txtName.Text;
            //employee.EmpLastName = txtLastName.Text;
            //emp.Add(employee);
        }
    }
}
