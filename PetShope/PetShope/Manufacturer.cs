using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShope
{
    public partial class Manufacturer : Form
    {
        public Form ReturnForm;

        public Form1 form;
        public bool flag = false;
        public bool flagRolForUser
        {
            set { flag = value; }
            get { return flag; }
        }

        public Manufacturer()
        {
            InitializeComponent();
        }

        private void manufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Manufacturer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.dataSet1.Manufacturer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag)
                manufacturerBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                manufacturerBindingSource.EndEdit();
                manufacturerTableAdapter.Update(dataSet1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1() { ReturnForm = this }.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(flag)
                manufacturerBindingSource.RemoveCurrent();
        }
    }
}
