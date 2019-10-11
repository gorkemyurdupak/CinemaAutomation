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
            dataGridView1.DataSource = emp.SelectActives();
        }
        private void SuperAdminPanel_Load(object sender, EventArgs e)
        {
            ListEmployee();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            this.Show();
            AddEmployee adep = new AddEmployee();
            adep.Show();
            ListEmployee();
            //Employee employee = new Employee();
            //employee.EmpFirstName = txtName.Text;
            //employee.EmpLastName = txtLastName.Text;
            //emp.Add(employee);
        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            UpdateEmployee upe = new UpdateEmployee();
            upe.Show();
        }
        Employee modifiye;
        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                modifiye = emp.GetByID(id);
                if (modifiye != null)
                {
                    emp.Delete(modifiye);
                    modifiye = null;
                    ListEmployee();
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Silinecek veriyi seçmemişsiniz");
                }
                ListEmployee();

            }
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {

        }
    }
}
