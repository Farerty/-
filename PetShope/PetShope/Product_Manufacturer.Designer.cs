
namespace PetShope
{
    partial class Product_Manufacturer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label prod_M_IDLabel;
            System.Windows.Forms.Label manufacturer_IDLabel;
            System.Windows.Forms.Label iD_ProductLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Manufacturer));
            this.dataSet1 = new PetShope.DataSet1();
            this.product_ManufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_ManufacturerTableAdapter = new PetShope.DataSet1TableAdapters.Product_ManufacturerTableAdapter();
            this.tableAdapterManager = new PetShope.DataSet1TableAdapters.TableAdapterManager();
            this.product_ManufacturerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.product_ManufacturerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_ManufacturerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_M_IDTextBox = new System.Windows.Forms.TextBox();
            this.manufacturer_IDTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProductTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            prod_M_IDLabel = new System.Windows.Forms.Label();
            manufacturer_IDLabel = new System.Windows.Forms.Label();
            iD_ProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManufacturerBindingNavigator)).BeginInit();
            this.product_ManufacturerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManufacturerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prod_M_IDLabel
            // 
            prod_M_IDLabel.AutoSize = true;
            prod_M_IDLabel.Location = new System.Drawing.Point(28, 267);
            prod_M_IDLabel.Name = "prod_M_IDLabel";
            prod_M_IDLabel.Size = new System.Drawing.Size(58, 13);
            prod_M_IDLabel.TabIndex = 2;
            prod_M_IDLabel.Text = "Prod M ID:";
            // 
            // manufacturer_IDLabel
            // 
            manufacturer_IDLabel.AutoSize = true;
            manufacturer_IDLabel.Location = new System.Drawing.Point(28, 293);
            manufacturer_IDLabel.Name = "manufacturer_IDLabel";
            manufacturer_IDLabel.Size = new System.Drawing.Size(87, 13);
            manufacturer_IDLabel.TabIndex = 4;
            manufacturer_IDLabel.Text = "Manufacturer ID:";
            // 
            // iD_ProductLabel
            // 
            iD_ProductLabel.AutoSize = true;
            iD_ProductLabel.Location = new System.Drawing.Point(28, 319);
            iD_ProductLabel.Name = "iD_ProductLabel";
            iD_ProductLabel.Size = new System.Drawing.Size(61, 13);
            iD_ProductLabel.TabIndex = 6;
            iD_ProductLabel.Text = "ID Product:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_ManufacturerBindingSource
            // 
            this.product_ManufacturerBindingSource.DataMember = "Product_Manufacturer";
            this.product_ManufacturerBindingSource.DataSource = this.dataSet1;
            // 
            // product_ManufacturerTableAdapter
            // 
            this.product_ManufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrdeTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.Product_ManufacturerTableAdapter = this.product_ManufacturerTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurchaseTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShope.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_ManufacturerBindingNavigator
            // 
            this.product_ManufacturerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.product_ManufacturerBindingNavigator.BindingSource = this.product_ManufacturerBindingSource;
            this.product_ManufacturerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.product_ManufacturerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.product_ManufacturerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.product_ManufacturerBindingNavigatorSaveItem});
            this.product_ManufacturerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.product_ManufacturerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.product_ManufacturerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.product_ManufacturerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.product_ManufacturerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.product_ManufacturerBindingNavigator.Name = "product_ManufacturerBindingNavigator";
            this.product_ManufacturerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.product_ManufacturerBindingNavigator.Size = new System.Drawing.Size(410, 25);
            this.product_ManufacturerBindingNavigator.TabIndex = 0;
            this.product_ManufacturerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // product_ManufacturerBindingNavigatorSaveItem
            // 
            this.product_ManufacturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.product_ManufacturerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("product_ManufacturerBindingNavigatorSaveItem.Image")));
            this.product_ManufacturerBindingNavigatorSaveItem.Name = "product_ManufacturerBindingNavigatorSaveItem";
            this.product_ManufacturerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.product_ManufacturerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.product_ManufacturerBindingNavigatorSaveItem.Click += new System.EventHandler(this.product_ManufacturerBindingNavigatorSaveItem_Click);
            // 
            // product_ManufacturerDataGridView
            // 
            this.product_ManufacturerDataGridView.AutoGenerateColumns = false;
            this.product_ManufacturerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_ManufacturerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.product_ManufacturerDataGridView.DataSource = this.product_ManufacturerBindingSource;
            this.product_ManufacturerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.product_ManufacturerDataGridView.Name = "product_ManufacturerDataGridView";
            this.product_ManufacturerDataGridView.Size = new System.Drawing.Size(347, 220);
            this.product_ManufacturerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prod_M_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prod_M_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Manufacturer_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Manufacturer_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Product";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // prod_M_IDTextBox
            // 
            this.prod_M_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_ManufacturerBindingSource, "Prod_M_ID", true));
            this.prod_M_IDTextBox.Location = new System.Drawing.Point(121, 264);
            this.prod_M_IDTextBox.Name = "prod_M_IDTextBox";
            this.prod_M_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.prod_M_IDTextBox.TabIndex = 3;
            // 
            // manufacturer_IDTextBox
            // 
            this.manufacturer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_ManufacturerBindingSource, "Manufacturer_ID", true));
            this.manufacturer_IDTextBox.Location = new System.Drawing.Point(121, 290);
            this.manufacturer_IDTextBox.Name = "manufacturer_IDTextBox";
            this.manufacturer_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturer_IDTextBox.TabIndex = 5;
            // 
            // iD_ProductTextBox
            // 
            this.iD_ProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_ManufacturerBindingSource, "ID_Product", true));
            this.iD_ProductTextBox.Location = new System.Drawing.Point(121, 316);
            this.iD_ProductTextBox.Name = "iD_ProductTextBox";
            this.iD_ProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ProductTextBox.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 37;
            this.button3.Text = "Главная страница";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "New record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Product_Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 364);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(prod_M_IDLabel);
            this.Controls.Add(this.prod_M_IDTextBox);
            this.Controls.Add(manufacturer_IDLabel);
            this.Controls.Add(this.manufacturer_IDTextBox);
            this.Controls.Add(iD_ProductLabel);
            this.Controls.Add(this.iD_ProductTextBox);
            this.Controls.Add(this.product_ManufacturerDataGridView);
            this.Controls.Add(this.product_ManufacturerBindingNavigator);
            this.Name = "Product_Manufacturer";
            this.Text = "Product_Manufacturer";
            this.Load += new System.EventHandler(this.Product_Manufacturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManufacturerBindingNavigator)).EndInit();
            this.product_ManufacturerBindingNavigator.ResumeLayout(false);
            this.product_ManufacturerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManufacturerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource product_ManufacturerBindingSource;
        private DataSet1TableAdapters.Product_ManufacturerTableAdapter product_ManufacturerTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator product_ManufacturerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton product_ManufacturerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView product_ManufacturerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox prod_M_IDTextBox;
        private System.Windows.Forms.TextBox manufacturer_IDTextBox;
        private System.Windows.Forms.TextBox iD_ProductTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}