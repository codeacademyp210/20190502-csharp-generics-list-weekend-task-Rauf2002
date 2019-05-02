using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.Name = nameBox.Text;
            e1.Surname = surnameBox.Text;
            e1.Email = emailBox.Text;
            e1.Position = positionBox.Text;
            e1.Salary = Convert.ToDouble(salaryBox.Text);

            empTable.Rows.Add(e1.CountId(),e1.Name,e1.Surname,e1.Email,e1.Position,e1.Salary);

            foreach (var c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
        private void DeleteRow(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.empTable.SelectedRows)
            {
                empTable.Rows.RemoveAt(item.Index);
            }
        }

        private void EditRow(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in empTable.SelectedRows)
            {
                nameBox.Text = row.Cells[1].Value.ToString();
                surnameBox.Text = row.Cells[2].Value.ToString();
                emailBox.Text = row.Cells[3].Value.ToString();
                positionBox.Text = row.Cells[4].Value.ToString();
                salaryBox.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
