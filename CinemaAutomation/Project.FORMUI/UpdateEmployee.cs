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
    public partial class UpdateEmployee : Form
    {
        EmployeeRepository emp = new EmployeeRepository();
        
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        public void ListEmployee()
        {
            dataGridView1.DataSource = emp.SelectActives();
        }
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            ListEmployee();
        }
        Employee modifiye;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                modifiye = emp.GetByID(id);
                if (modifiye != null)
                {
                    modifiye.EmpFirstName = txtName.Text;
                    modifiye.EmpLastName = txtLastName.Text;
                    modifiye.Title = txtTitle.Text;
                    emp.Update(modifiye);
                    modifiye = null;
                    ListEmployee();
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
