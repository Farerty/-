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
    public partial class Product_Manufacturer : Form
    {
        public Form ReturnForm;
        public Form1 form;
        public bool flag = false;
        public bool flagRolForUser 
        {
            set { flag = value; }
            get { return flag; }
        }

        public Product_Manufacturer()
        {
            InitializeComponent();
        }

        private void product_ManufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_ManufacturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Product_Manufacturer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Product_Manufacturer". При необходимости она может быть перемещена или удалена.
            this.product_ManufacturerTableAdapter.Fill(this.dataSet1.Product_Manufacturer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag)
                product_ManufacturerBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                product_ManufacturerBindingSource.EndEdit();
                product_ManufacturerTableAdapter.Update(dataSet1);
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
                product_ManufacturerBindingSource.RemoveCurrent();
        }
    }
}
