
namespace PetShope
{
    partial class Order
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
            System.Windows.Forms.Label iD_OrderLabel;
            System.Windows.Forms.Label o_registrationdateLabel;
            System.Windows.Forms.Label iD_ProductLabel;
            System.Windows.Forms.Label iD_CustomerLabel;
            System.Windows.Forms.Label iD_employeeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataSet1 = new PetShope.DataSet1();
            this.ordeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordeTableAdapter = new PetShope.DataSet1TableAdapters.OrdeTableAdapter();
            this.tableAdapterManager = new PetShope.DataSet1TableAdapters.TableAdapterManager();
            this.ordeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ordeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ordeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_OrderTextBox = new System.Windows.Forms.TextBox();
            this.o_registrationdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_ProductTextBox = new System.Windows.Forms.TextBox();
            this.iD_CustomerTextBox = new System.Windows.Forms.TextBox();
            this.iD_employeeTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iD_OrderLabel = new System.Windows.Forms.Label();
            o_registrationdateLabel = new System.Windows.Forms.Label();
            iD_ProductLabel = new System.Windows.Forms.Label();
            iD_CustomerLabel = new System.Windows.Forms.Label();
            iD_employeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordeBindingNavigator)).BeginInit();
            this.ordeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_OrderLabel
            // 
            iD_OrderLabel.AutoSize = true;
            iD_OrderLabel.Location = new System.Drawing.Point(31, 254);
            iD_OrderLabel.Name = "iD_OrderLabel";
            iD_OrderLabel.Size = new System.Drawing.Size(50, 13);
            iD_OrderLabel.TabIndex = 2;
            iD_OrderLabel.Text = "ID Order:";
            // 
            // o_registrationdateLabel
            // 
            o_registrationdateLabel.AutoSize = true;
            o_registrationdateLabel.Location = new System.Drawing.Point(31, 281);
            o_registrationdateLabel.Name = "o_registrationdateLabel";
            o_registrationdateLabel.Size = new System.Drawing.Size(93, 13);
            o_registrationdateLabel.TabIndex = 4;
            o_registrationdateLabel.Text = "O registrationdate:";
            // 
            // iD_ProductLabel
            // 
            iD_ProductLabel.AutoSize = true;
            iD_ProductLabel.Location = new System.Drawing.Point(31, 306);
            iD_ProductLabel.Name = "iD_ProductLabel";
            iD_ProductLabel.Size = new System.Drawing.Size(61, 13);
            iD_ProductLabel.TabIndex = 6;
            iD_ProductLabel.Text = "ID Product:";
            // 
            // iD_CustomerLabel
            // 
            iD_CustomerLabel.AutoSize = true;
            iD_CustomerLabel.Location = new System.Drawing.Point(31, 332);
            iD_CustomerLabel.Name = "iD_CustomerLabel";
            iD_CustomerLabel.Size = new System.Drawing.Size(68, 13);
            iD_CustomerLabel.TabIndex = 8;
            iD_CustomerLabel.Text = "ID Customer:";
            // 
            // iD_employeeLabel
            // 
            iD_employeeLabel.AutoSize = true;
            iD_employeeLabel.Location = new System.Drawing.Point(31, 358);
            iD_employeeLabel.Name = "iD_employeeLabel";
            iD_employeeLabel.Size = new System.Drawing.Size(69, 13);
            iD_employeeLabel.TabIndex = 10;
            iD_employeeLabel.Text = "ID employee:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordeBindingSource
            // 
            this.ordeBindingSource.DataMember = "Orde";
            this.ordeBindingSource.DataSource = this.dataSet1;
            // 
            // ordeTableAdapter
            // 
            this.ordeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrdeTableAdapter = this.ordeTableAdapter;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.Product_ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurchaseTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShope.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordeBindingNavigator
            // 
            this.ordeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordeBindingNavigator.BindingSource = this.ordeBindingSource;
            this.ordeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordeBindingNavigatorSaveItem});
            this.ordeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordeBindingNavigator.Name = "ordeBindingNavigator";
            this.ordeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordeBindingNavigator.Size = new System.Drawing.Size(629, 25);
            this.ordeBindingNavigator.TabIndex = 0;
            this.ordeBindingNavigator.Text = "bindingNavigator1";
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
            // ordeBindingNavigatorSaveItem
            // 
            this.ordeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordeBindingNavigatorSaveItem.Image")));
            this.ordeBindingNavigatorSaveItem.Name = "ordeBindingNavigatorSaveItem";
            this.ordeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ordeBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordeBindingNavigatorSaveItem_Click);
            // 
            // ordeDataGridView
            // 
            this.ordeDataGridView.AutoGenerateColumns = false;
            this.ordeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ordeDataGridView.DataSource = this.ordeBindingSource;
            this.ordeDataGridView.Location = new System.Drawing.Point(20, 26);
            this.ordeDataGridView.Name = "ordeDataGridView";
            this.ordeDataGridView.Size = new System.Drawing.Size(557, 191);
            this.ordeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Order";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Order";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "O_registrationdate";
            this.dataGridViewTextBoxColumn2.HeaderText = "O_registrationdate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Product";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Product";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Customer";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Customer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_employee";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_employee";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iD_OrderTextBox
            // 
            this.iD_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordeBindingSource, "ID_Order", true));
            this.iD_OrderTextBox.Location = new System.Drawing.Point(130, 251);
            this.iD_OrderTextBox.Name = "iD_OrderTextBox";
            this.iD_OrderTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_OrderTextBox.TabIndex = 3;
            // 
            // o_registrationdateDateTimePicker
            // 
            this.o_registrationdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordeBindingSource, "O_registrationdate", true));
            this.o_registrationdateDateTimePicker.Location = new System.Drawing.Point(130, 277);
            this.o_registrationdateDateTimePicker.Name = "o_registrationdateDateTimePicker";
            this.o_registrationdateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.o_registrationdateDateTimePicker.TabIndex = 5;
            // 
            // iD_ProductTextBox
            // 
            this.iD_ProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordeBindingSource, "ID_Product", true));
            this.iD_ProductTextBox.Location = new System.Drawing.Point(130, 303);
            this.iD_ProductTextBox.Name = "iD_ProductTextBox";
            this.iD_ProductTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ProductTextBox.TabIndex = 7;
            // 
            // iD_CustomerTextBox
            // 
            this.iD_CustomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordeBindingSource, "ID_Customer", true));
            this.iD_CustomerTextBox.Location = new System.Drawing.Point(130, 329);
            this.iD_CustomerTextBox.Name = "iD_CustomerTextBox";
            this.iD_CustomerTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_CustomerTextBox.TabIndex = 9;
            // 
            // iD_employeeTextBox
            // 
            this.iD_employeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordeBindingSource, "ID_employee", true));
            this.iD_employeeTextBox.Location = new System.Drawing.Point(130, 355);
            this.iD_employeeTextBox.Name = "iD_employeeTextBox";
            this.iD_employeeTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_employeeTextBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 28;
            this.button3.Text = "Главная страница";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "New record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 392);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_OrderLabel);
            this.Controls.Add(this.iD_OrderTextBox);
            this.Controls.Add(o_registrationdateLabel);
            this.Controls.Add(this.o_registrationdateDateTimePicker);
            this.Controls.Add(iD_ProductLabel);
            this.Controls.Add(this.iD_ProductTextBox);
            this.Controls.Add(iD_CustomerLabel);
            this.Controls.Add(this.iD_CustomerTextBox);
            this.Controls.Add(iD_employeeLabel);
            this.Controls.Add(this.iD_employeeTextBox);
            this.Controls.Add(this.ordeDataGridView);
            this.Controls.Add(this.ordeBindingNavigator);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordeBindingNavigator)).EndInit();
            this.ordeBindingNavigator.ResumeLayout(false);
            this.ordeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ordeBindingSource;
        private DataSet1TableAdapters.OrdeTableAdapter ordeTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ordeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iD_OrderTextBox;
        private System.Windows.Forms.DateTimePicker o_registrationdateDateTimePicker;
        private System.Windows.Forms.TextBox iD_ProductTextBox;
        private System.Windows.Forms.TextBox iD_CustomerTextBox;
        private System.Windows.Forms.TextBox iD_employeeTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}