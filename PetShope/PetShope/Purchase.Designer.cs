
namespace PetShope
{
    partial class Purchase
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
            System.Windows.Forms.Label pur_IDLabel;
            System.Windows.Forms.Label pur_PURCHASEPRICELabel;
            System.Windows.Forms.Label pur_NUMBEROFPURCHASELabel;
            System.Windows.Forms.Label pur_DELIVERYMETHODLabel;
            System.Windows.Forms.Label pur_DELIVERYCOMPANYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.dataSet1 = new PetShope.DataSet1();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTableAdapter = new PetShope.DataSet1TableAdapters.PurchaseTableAdapter();
            this.tableAdapterManager = new PetShope.DataSet1TableAdapters.TableAdapterManager();
            this.purchaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pur_IDTextBox = new System.Windows.Forms.TextBox();
            this.pur_PURCHASEPRICETextBox = new System.Windows.Forms.TextBox();
            this.pur_NUMBEROFPURCHASETextBox = new System.Windows.Forms.TextBox();
            this.pur_DELIVERYMETHODTextBox = new System.Windows.Forms.TextBox();
            this.pur_DELIVERYCOMPANYTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            pur_IDLabel = new System.Windows.Forms.Label();
            pur_PURCHASEPRICELabel = new System.Windows.Forms.Label();
            pur_NUMBEROFPURCHASELabel = new System.Windows.Forms.Label();
            pur_DELIVERYMETHODLabel = new System.Windows.Forms.Label();
            pur_DELIVERYCOMPANYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).BeginInit();
            this.purchaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pur_IDLabel
            // 
            pur_IDLabel.AutoSize = true;
            pur_IDLabel.Location = new System.Drawing.Point(28, 283);
            pur_IDLabel.Name = "pur_IDLabel";
            pur_IDLabel.Size = new System.Drawing.Size(40, 13);
            pur_IDLabel.TabIndex = 2;
            pur_IDLabel.Text = "Pur ID:";
            // 
            // pur_PURCHASEPRICELabel
            // 
            pur_PURCHASEPRICELabel.AutoSize = true;
            pur_PURCHASEPRICELabel.Location = new System.Drawing.Point(28, 309);
            pur_PURCHASEPRICELabel.Name = "pur_PURCHASEPRICELabel";
            pur_PURCHASEPRICELabel.Size = new System.Drawing.Size(120, 13);
            pur_PURCHASEPRICELabel.TabIndex = 4;
            pur_PURCHASEPRICELabel.Text = "Pur PURCHASEPRICE:";
            // 
            // pur_NUMBEROFPURCHASELabel
            // 
            pur_NUMBEROFPURCHASELabel.AutoSize = true;
            pur_NUMBEROFPURCHASELabel.Location = new System.Drawing.Point(28, 335);
            pur_NUMBEROFPURCHASELabel.Name = "pur_NUMBEROFPURCHASELabel";
            pur_NUMBEROFPURCHASELabel.Size = new System.Drawing.Size(149, 13);
            pur_NUMBEROFPURCHASELabel.TabIndex = 6;
            pur_NUMBEROFPURCHASELabel.Text = "Pur NUMBEROFPURCHASE:";
            // 
            // pur_DELIVERYMETHODLabel
            // 
            pur_DELIVERYMETHODLabel.AutoSize = true;
            pur_DELIVERYMETHODLabel.Location = new System.Drawing.Point(28, 361);
            pur_DELIVERYMETHODLabel.Name = "pur_DELIVERYMETHODLabel";
            pur_DELIVERYMETHODLabel.Size = new System.Drawing.Size(129, 13);
            pur_DELIVERYMETHODLabel.TabIndex = 8;
            pur_DELIVERYMETHODLabel.Text = "Pur DELIVERYMETHOD:";
            // 
            // pur_DELIVERYCOMPANYLabel
            // 
            pur_DELIVERYCOMPANYLabel.AutoSize = true;
            pur_DELIVERYCOMPANYLabel.Location = new System.Drawing.Point(28, 387);
            pur_DELIVERYCOMPANYLabel.Name = "pur_DELIVERYCOMPANYLabel";
            pur_DELIVERYCOMPANYLabel.Size = new System.Drawing.Size(135, 13);
            pur_DELIVERYCOMPANYLabel.TabIndex = 10;
            pur_DELIVERYCOMPANYLabel.Text = "Pur DELIVERYCOMPANY:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.dataSet1;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Provider_PurchaseTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = this.purchaseTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShope.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchaseBindingNavigator
            // 
            this.purchaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseBindingNavigator.BindingSource = this.purchaseBindingSource;
            this.purchaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseBindingNavigatorSaveItem});
            this.purchaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseBindingNavigator.Name = "purchaseBindingNavigator";
            this.purchaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseBindingNavigator.Size = new System.Drawing.Size(579, 25);
            this.purchaseBindingNavigator.TabIndex = 0;
            this.purchaseBindingNavigator.Text = "bindingNavigator1";
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
            // purchaseBindingNavigatorSaveItem
            // 
            this.purchaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseBindingNavigatorSaveItem.Image")));
            this.purchaseBindingNavigatorSaveItem.Name = "purchaseBindingNavigatorSaveItem";
            this.purchaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purchaseBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.purchaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseBindingNavigatorSaveItem_Click);
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AutoGenerateColumns = false;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.purchaseDataGridView.DataSource = this.purchaseBindingSource;
            this.purchaseDataGridView.Location = new System.Drawing.Point(12, 28);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(553, 220);
            this.purchaseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pur_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pur_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pur_PURCHASEPRICE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pur_PURCHASEPRICE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pur_NUMBEROFPURCHASE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pur_NUMBEROFPURCHASE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pur_DELIVERYMETHOD";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pur_DELIVERYMETHOD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pur_DELIVERYCOMPANY";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pur_DELIVERYCOMPANY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pur_IDTextBox
            // 
            this.pur_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Pur_ID", true));
            this.pur_IDTextBox.Location = new System.Drawing.Point(183, 280);
            this.pur_IDTextBox.Name = "pur_IDTextBox";
            this.pur_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pur_IDTextBox.TabIndex = 3;
            // 
            // pur_PURCHASEPRICETextBox
            // 
            this.pur_PURCHASEPRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Pur_PURCHASEPRICE", true));
            this.pur_PURCHASEPRICETextBox.Location = new System.Drawing.Point(183, 306);
            this.pur_PURCHASEPRICETextBox.Name = "pur_PURCHASEPRICETextBox";
            this.pur_PURCHASEPRICETextBox.Size = new System.Drawing.Size(100, 20);
            this.pur_PURCHASEPRICETextBox.TabIndex = 5;
            // 
            // pur_NUMBEROFPURCHASETextBox
            // 
            this.pur_NUMBEROFPURCHASETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Pur_NUMBEROFPURCHASE", true));
            this.pur_NUMBEROFPURCHASETextBox.Location = new System.Drawing.Point(183, 332);
            this.pur_NUMBEROFPURCHASETextBox.Name = "pur_NUMBEROFPURCHASETextBox";
            this.pur_NUMBEROFPURCHASETextBox.Size = new System.Drawing.Size(100, 20);
            this.pur_NUMBEROFPURCHASETextBox.TabIndex = 7;
            // 
            // pur_DELIVERYMETHODTextBox
            // 
            this.pur_DELIVERYMETHODTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Pur_DELIVERYMETHOD", true));
            this.pur_DELIVERYMETHODTextBox.Location = new System.Drawing.Point(183, 358);
            this.pur_DELIVERYMETHODTextBox.Name = "pur_DELIVERYMETHODTextBox";
            this.pur_DELIVERYMETHODTextBox.Size = new System.Drawing.Size(100, 20);
            this.pur_DELIVERYMETHODTextBox.TabIndex = 9;
            // 
            // pur_DELIVERYCOMPANYTextBox
            // 
            this.pur_DELIVERYCOMPANYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Pur_DELIVERYCOMPANY", true));
            this.pur_DELIVERYCOMPANYTextBox.Location = new System.Drawing.Point(183, 384);
            this.pur_DELIVERYCOMPANYTextBox.Name = "pur_DELIVERYCOMPANYTextBox";
            this.pur_DELIVERYCOMPANYTextBox.Size = new System.Drawing.Size(100, 20);
            this.pur_DELIVERYCOMPANYTextBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 46;
            this.button3.Text = "Главная страница";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "New record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 47;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 421);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(pur_IDLabel);
            this.Controls.Add(this.pur_IDTextBox);
            this.Controls.Add(pur_PURCHASEPRICELabel);
            this.Controls.Add(this.pur_PURCHASEPRICETextBox);
            this.Controls.Add(pur_NUMBEROFPURCHASELabel);
            this.Controls.Add(this.pur_NUMBEROFPURCHASETextBox);
            this.Controls.Add(pur_DELIVERYMETHODLabel);
            this.Controls.Add(this.pur_DELIVERYMETHODTextBox);
            this.Controls.Add(pur_DELIVERYCOMPANYLabel);
            this.Controls.Add(this.pur_DELIVERYCOMPANYTextBox);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.purchaseBindingNavigator);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).EndInit();
            this.purchaseBindingNavigator.ResumeLayout(false);
            this.purchaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private DataSet1TableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox pur_IDTextBox;
        private System.Windows.Forms.TextBox pur_PURCHASEPRICETextBox;
        private System.Windows.Forms.TextBox pur_NUMBEROFPURCHASETextBox;
        private System.Windows.Forms.TextBox pur_DELIVERYMETHODTextBox;
        private System.Windows.Forms.TextBox pur_DELIVERYCOMPANYTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}