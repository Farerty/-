
namespace PetShope
{
    partial class Provider_Purchase
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
            System.Windows.Forms.Label p_Pur_IDLabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label pur_IDLabel;
            System.Windows.Forms.Label prod_M_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provider_Purchase));
            this.dataSet1 = new PetShope.DataSet1();
            this.provider_PurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provider_PurchaseTableAdapter = new PetShope.DataSet1TableAdapters.Provider_PurchaseTableAdapter();
            this.tableAdapterManager = new PetShope.DataSet1TableAdapters.TableAdapterManager();
            this.provider_PurchaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.provider_PurchaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.provider_PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Pur_IDTextBox = new System.Windows.Forms.TextBox();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.pur_IDTextBox = new System.Windows.Forms.TextBox();
            this.prod_M_IDTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            p_Pur_IDLabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            pur_IDLabel = new System.Windows.Forms.Label();
            prod_M_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurchaseBindingNavigator)).BeginInit();
            this.provider_PurchaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Pur_IDLabel
            // 
            p_Pur_IDLabel.AutoSize = true;
            p_Pur_IDLabel.Location = new System.Drawing.Point(489, 31);
            p_Pur_IDLabel.Name = "p_Pur_IDLabel";
            p_Pur_IDLabel.Size = new System.Drawing.Size(50, 13);
            p_Pur_IDLabel.TabIndex = 2;
            p_Pur_IDLabel.Text = "P Pur ID:";
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(489, 57);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(31, 13);
            p_IDLabel.TabIndex = 4;
            p_IDLabel.Text = "P ID:";
            // 
            // pur_IDLabel
            // 
            pur_IDLabel.AutoSize = true;
            pur_IDLabel.Location = new System.Drawing.Point(489, 83);
            pur_IDLabel.Name = "pur_IDLabel";
            pur_IDLabel.Size = new System.Drawing.Size(40, 13);
            pur_IDLabel.TabIndex = 6;
            pur_IDLabel.Text = "Pur ID:";
            // 
            // prod_M_IDLabel
            // 
            prod_M_IDLabel.AutoSize = true;
            prod_M_IDLabel.Location = new System.Drawing.Point(489, 109);
            prod_M_IDLabel.Name = "prod_M_IDLabel";
            prod_M_IDLabel.Size = new System.Drawing.Size(58, 13);
            prod_M_IDLabel.TabIndex = 8;
            prod_M_IDLabel.Text = "Prod M ID:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provider_PurchaseBindingSource
            // 
            this.provider_PurchaseBindingSource.DataMember = "Provider_Purchase";
            this.provider_PurchaseBindingSource.DataSource = this.dataSet1;
            // 
            // provider_PurchaseTableAdapter
            // 
            this.provider_PurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrdeTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.Product_ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurchaseTableAdapter = this.provider_PurchaseTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShope.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // provider_PurchaseBindingNavigator
            // 
            this.provider_PurchaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.provider_PurchaseBindingNavigator.BindingSource = this.provider_PurchaseBindingSource;
            this.provider_PurchaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.provider_PurchaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.provider_PurchaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.provider_PurchaseBindingNavigatorSaveItem});
            this.provider_PurchaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.provider_PurchaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.provider_PurchaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.provider_PurchaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.provider_PurchaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.provider_PurchaseBindingNavigator.Name = "provider_PurchaseBindingNavigator";
            this.provider_PurchaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.provider_PurchaseBindingNavigator.Size = new System.Drawing.Size(730, 25);
            this.provider_PurchaseBindingNavigator.TabIndex = 0;
            this.provider_PurchaseBindingNavigator.Text = "bindingNavigator1";
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
            // provider_PurchaseBindingNavigatorSaveItem
            // 
            this.provider_PurchaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.provider_PurchaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("provider_PurchaseBindingNavigatorSaveItem.Image")));
            this.provider_PurchaseBindingNavigatorSaveItem.Name = "provider_PurchaseBindingNavigatorSaveItem";
            this.provider_PurchaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.provider_PurchaseBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.provider_PurchaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.provider_PurchaseBindingNavigatorSaveItem_Click);
            // 
            // provider_PurchaseDataGridView
            // 
            this.provider_PurchaseDataGridView.AutoGenerateColumns = false;
            this.provider_PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider_PurchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.provider_PurchaseDataGridView.DataSource = this.provider_PurchaseBindingSource;
            this.provider_PurchaseDataGridView.Location = new System.Drawing.Point(12, 28);
            this.provider_PurchaseDataGridView.Name = "provider_PurchaseDataGridView";
            this.provider_PurchaseDataGridView.Size = new System.Drawing.Size(451, 220);
            this.provider_PurchaseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "P_Pur_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "P_Pur_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "P_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "P_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pur_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pur_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prod_M_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prod_M_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // p_Pur_IDTextBox
            // 
            this.p_Pur_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurchaseBindingSource, "P_Pur_ID", true));
            this.p_Pur_IDTextBox.Location = new System.Drawing.Point(553, 28);
            this.p_Pur_IDTextBox.Name = "p_Pur_IDTextBox";
            this.p_Pur_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_Pur_IDTextBox.TabIndex = 3;
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurchaseBindingSource, "P_ID", true));
            this.p_IDTextBox.Location = new System.Drawing.Point(553, 54);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_IDTextBox.TabIndex = 5;
            // 
            // pur_IDTextBox
            // 
            this.pur_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurchaseBindingSource, "Pur_ID", true));
            this.pur_IDTextBox.Location = new System.Drawing.Point(553, 80);
            this.pur_IDTextBox.Name = "pur_IDTextBox";
            this.pur_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pur_IDTextBox.TabIndex = 7;
            // 
            // prod_M_IDTextBox
            // 
            this.prod_M_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurchaseBindingSource, "Prod_M_ID", true));
            this.prod_M_IDTextBox.Location = new System.Drawing.Point(553, 106);
            this.prod_M_IDTextBox.Name = "prod_M_IDTextBox";
            this.prod_M_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.prod_M_IDTextBox.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 43;
            this.button3.Text = "Главная страница";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "New record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Provider_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 287);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(p_Pur_IDLabel);
            this.Controls.Add(this.p_Pur_IDTextBox);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(pur_IDLabel);
            this.Controls.Add(this.pur_IDTextBox);
            this.Controls.Add(prod_M_IDLabel);
            this.Controls.Add(this.prod_M_IDTextBox);
            this.Controls.Add(this.provider_PurchaseDataGridView);
            this.Controls.Add(this.provider_PurchaseBindingNavigator);
            this.Name = "Provider_Purchase";
            this.Text = "Provider_Purchase";
            this.Load += new System.EventHandler(this.Provider_Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurchaseBindingNavigator)).EndInit();
            this.provider_PurchaseBindingNavigator.ResumeLayout(false);
            this.provider_PurchaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource provider_PurchaseBindingSource;
        private DataSet1TableAdapters.Provider_PurchaseTableAdapter provider_PurchaseTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator provider_PurchaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton provider_PurchaseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView provider_PurchaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox p_Pur_IDTextBox;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox pur_IDTextBox;
        private System.Windows.Forms.TextBox prod_M_IDTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}