using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShope
{
    public partial class Form1 : Form
    {
        public Form ReturnForm;
        public SqlConnection connection = new SqlConnection(Properties.Settings.Default.ЗоомагазинConnectionString);
        SaveFileDialog saveFileDialogBack = new SaveFileDialog();
        OpenFileDialog openFileDialogSQL = new OpenFileDialog();
        OpenFileDialog openFileDialogRes = new OpenFileDialog();

        
        private bool SQLStat = true;
        public Form1()
        {
            InitializeComponent();
            saveFileDialogBack.FileName = "Зоомагазин";
            saveFileDialogBack.DefaultExt = ".bak";
            saveFileDialogBack.Filter = "Bak files(*bak)|*bak";

            openFileDialogSQL.Filter = "Sql files(*.sql)|*.sql| Text files(*.txt)|*.txt| All files(*.*)|*.*";
            openFileDialogRes.Filter = "Bak files(*bak)|*bak";

            if (SQLCheck() != true)
                return;
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("TableInfo", connection))
                {
                    connection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);
                        List<string> names;
                        DataTableForMas(dataTable, out names);
                        
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
               //MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private bool SQLCheck()
        {
            try
            {
                connection.Open();
                SQLStat = true;
            }
            catch (Exception)
            {
                SQLStat = false;
            }
            finally
            {
                connection.Close();
            }
            return SQLStat;
        }
        private void DataTableForMas(DataTable dataTable, out List<string> names)
        {
            names = new List<string>();
            foreach (DataRow row in dataTable.Rows)
                names.Add(row["name"].ToString());
            names.Remove("sysdiagrams");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer() { ReturnForm = this }.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employee() { ReturnForm = this }.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manufacturer() { ReturnForm = this }.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order() { ReturnForm = this }.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Posts() { ReturnForm = this }.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Product() { ReturnForm = this }.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Product_Manufacturer() { ReturnForm = this }.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Provider() { ReturnForm = this }.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Provider_Purchase() { ReturnForm = this }.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Purchase() { ReturnForm = this }.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Stock() { ReturnForm = this }.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormInfo() { ReturnForm = this }.Show();
        }

        private void резернаяКопияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Test() != true) return;

            if (saveFileDialogBack.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialogBack.FileName;
            string sql = @"BACKUP DATABASE[Зоомагазин] TO DISK = N'" + path + "' WITH NOFORMAT, NOINIT, NAME = N'Travel_Company-Полная База данных Резервное копирование', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Резерная копия успешно создана и сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения резервной копии базы данных! {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void восстановлениеБазыДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Test() != true) return;

            DialogResult result = MessageBox.Show("Вы уверены, что хотитевостановить базу данных?", "Восстановление базы данных.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if (openFileDialogRes.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialogRes.FileName;
            string sql = @"USE master RESTORE DATABASE [Зоомагазин] FROM  DISK = N'" + path + "' WITH REPLACE, FILE = 1,  NOUNLOAD,  STATS = 5";
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("База данных успешно востановленна");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка востановления базы данных! {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private bool Test()
        {
            if (SQLStat != true)
            {
                MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Avtorization() { ReturnForm = this }.Show();
        }
    }
}
