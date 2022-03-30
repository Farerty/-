using System;
using System.Windows.Forms;

namespace PetShope
{
    public partial class Employee : Form
    {
        public Form ReturnForm;

        public Form1 form;
        public bool flag = false;
        public bool flagRolForUser
        {
            set { flag = value; }
            get { return flag; }
        }

        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag)
                employeeBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(flag)
                employeeBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                employeeBindingSource.EndEdit();
                employeeTableAdapter.Update(dataSet1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1() { ReturnForm = this }.Show();
        }
    }
}
