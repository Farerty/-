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
    public partial class Purchase : Form
    {
        public Form ReturnForm;
        public Form1 form;
        public bool flag = false;
        public bool flagRolForUser
        {
            set { flag = value; }
            get { return flag; }
        }

        public Purchase()
        {
            InitializeComponent();
        }

        private void purchaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.dataSet1.Purchase);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag)
                purchaseBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                purchaseBindingSource.EndEdit();
                purchaseTableAdapter.Update(dataSet1);
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
                purchaseBindingSource.RemoveCurrent();
        }
    }
}
