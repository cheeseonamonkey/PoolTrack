using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pol
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            listViewEmployees.Items.Clear();

            foreach (string s in Program.employeeList)
            {
                listViewEmployees.Items.Add(s);
            }

        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            string nam = txtEmployeeAdd.Text;

            txtEmployeeAdd.Clear();

            Program.employeeList.Add(nam);
            listViewEmployees.Items.Add(nam);

            Program.SaveLists();


        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listViewEmployees.Items)
            {
                if (i.Selected)
                {
                    
                    foreach (string s in Program.employeeList)
                    {
                        if (i.Text.Equals(s))
                        {
                            Program.employeeList.Remove(s);
                            listViewEmployees.Items.Remove(i);
                            break;
                        }
                    }
                }
            }

            Program.SaveLists();
        }
    }
}
