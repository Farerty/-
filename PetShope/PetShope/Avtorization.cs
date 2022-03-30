using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetShope
{
    public partial class Avtorization : Form
    {
        public Form ReturnForm;
        bool flag = false;
        bool flagRole = false;
        public Avtorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nick = textBox1.Text;
            string pass = textBox2.Text;
            string login, login2, password, password2;
            login = "Admin";
            login2 = "Subscriber";
            password = "12345";
            password2 = "54321";
            /*string myConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=Зоомагазин; Integrated Security=True";
            string mySelectQuery = "SELECT [login] FROM [Зоомагазин] WHERE [login] = '" + nick + "'and [password]='" + pass + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, myConnectionString))
            {

                DataTable table = new DataTable();
                
                if (table.Rows.Count == 0)
                {
                    
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Такого логина нет в базе данных или нет логина с таким паролем");
                }
            }*/
            if(login == nick && password == pass)
            {
                flag = true;
                flagRole = true;
                Customer fmCustomer = new Customer();
                Employee fmEmployee = new Employee();
                Manufacturer fmManufacturer = new Manufacturer();
                Order fmOrder = new Order();
                Posts fmPosts = new Posts();
                Product fmProduct = new Product();
                Product_Manufacturer fmProduct_Manufacturer = new Product_Manufacturer();
                Provider fmProvider = new Provider();
                Provider_Purchase fmProvider_Purchase = new Provider_Purchase();
                Purchase fmPurchase = new Purchase();
                Stock fmStock = new Stock();
                fmCustomer.flag = flagRole;
                fmEmployee.flag = flagRole;
                fmManufacturer.flag = flagRole;
                fmOrder.flag = flagRole;
                fmPosts.flag = flagRole;
                fmProduct.flag = flagRole;
                fmProduct_Manufacturer.flag = flagRole;
                fmProvider.flag = flagRole;
                fmProvider_Purchase.flag = flagRole;
                fmPurchase.flag = flagRole;
                fmStock.flag = flagRole;
            }
            else if(login2 == nick && password2 == pass)
            {
                flag = true;
            }
            if(flag == true)
            {
                this.Hide();
                new Form1() { ReturnForm = this }.Show();
            }
            else
            {
                MessageBox.Show("Такого логина нет в базе данных или нет логина с таким паролем");
            }

        }
    }
}
