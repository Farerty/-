
namespace PetShope
{
    partial class Customer
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
            System.Windows.Forms.Label iD_CustomerLabel;
            System.Windows.Forms.Label c_telephoneLabel;
            System.Windows.Forms.Label c_SEXLabel;
            System.Windows.Forms.Label c_STRITLabel;
            System.Windows.Forms.Label c_HOMELabel;
            System.Windows.Forms.Label c_FLATLabel;
            System.Windows.Forms.Label c_SURNAMELabel;
            System.Windows.Forms.Label c_NAMELabel;
            System.Windows.Forms.Label c_MIDDLENAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.dataSet1 = new PetShope.DataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new PetShope.DataSet1TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new PetShope.DataSet1TableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_CustomerTextBox = new System.Windows.Forms.TextBox();
            this.c_telephoneTextBox = new System.Windows.Forms.TextBox();
            this.c_SEXCheckBox = new System.Windows.Forms.CheckBox();
            this.c_STRITTextBox = new System.Windows.Forms.TextBox();
            this.c_HOMETextBox = new System.Windows.Forms.TextBox();
            this.c_FLATTextBox = new System.Windows.Forms.TextBox();
            this.c_SURNAMETextBox = new System.Windows.Forms.TextBox();
            this.c_NAMETextBox = new System.Windows.Forms.TextBox();
            this.c_MIDDLENAMETextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iD_CustomerLabel = new System.Windows.Forms.Label();
            c_telephoneLabel = new System.Windows.Forms.Label();
            c_SEXLabel = new System.Windows.Forms.Label();
            c_STRITLabel = new System.Windows.Forms.Label();
            c_HOMELabel = new System.Windows.Forms.Label();
            c_FLATLabel = new System.Windows.Forms.Label();
            c_SURNAMELabel = new System.Windows.Forms.Label();
            c_NAMELabel = new System.Windows.Forms.Label();
            c_MIDDLENAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CustomerLabel
            // 
            iD_CustomerLabel.AutoSize = true;
            iD_CustomerLabel.Location = new System.Drawing.Point(16, 301);
            iD_CustomerLabel.Name = "iD_CustomerLabel";
            iD_CustomerLabel.Size = new System.Drawing.Size(68, 13);
            iD_CustomerLabel.TabIndex = 2;
            iD_CustomerLabel.Text = "ID Customer:";
            // 
            // c_telephoneLabel
            // 
            c_telephoneLabel.AutoSize = true;
            c_telephoneLabel.Location = new System.Drawing.Point(16, 327);
            c_telephoneLabel.Name = "c_telephoneLabel";
            c_telephoneLabel.Size = new System.Drawing.Size(67, 13);
            c_telephoneLabel.TabIndex = 4;
            c_telephoneLabel.Text = "C telephone:";
            // 
            // c_SEXLabel
            // 
            c_SEXLabel.AutoSize = true;
            c_SEXLabel.Location = new System.Drawing.Point(16, 355);
            c_SEXLabel.Name = "c_SEXLabel";
            c_SEXLabel.Size = new System.Drawing.Size(41, 13);
            c_SEXLabel.TabIndex = 6;
            c_SEXLabel.Text = "C SEX:";
            // 
            // c_STRITLabel
            // 
            c_STRITLabel.AutoSize = true;
            c_STRITLabel.Location = new System.Drawing.Point(16, 383);
            c_STRITLabel.Name = "c_STRITLabel";
            c_STRITLabel.Size = new System.Drawing.Size(52, 13);
            c_STRITLabel.TabIndex = 8;
            c_STRITLabel.Text = "C STRIT:";
            // 
            // c_HOMELabel
            // 
            c_HOMELabel.AutoSize = true;
            c_HOMELabel.Location = new System.Drawing.Point(16, 409);
            c_HOMELabel.Name = "c_HOMELabel";
            c_HOMELabel.Size = new System.Drawing.Size(52, 13);
            c_HOMELabel.TabIndex = 10;
            c_HOMELabel.Text = "C HOME:";
            // 
            // c_FLATLabel
            // 
            c_FLATLabel.AutoSize = true;
            c_FLATLabel.Location = new System.Drawing.Point(16, 435);
            c_FLATLabel.Name = "c_FLATLabel";
            c_FLATLabel.Size = new System.Drawing.Size(46, 13);
            c_FLATLabel.TabIndex = 12;
            c_FLATLabel.Text = "C FLAT:";
            // 
            // c_SURNAMELabel
            // 
            c_SURNAMELabel.AutoSize = true;
            c_SURNAMELabel.Location = new System.Drawing.Point(16, 461);
            c_SURNAMELabel.Name = "c_SURNAMELabel";
            c_SURNAMELabel.Size = new System.Drawing.Size(74, 13);
            c_SURNAMELabel.TabIndex = 14;
            c_SURNAMELabel.Text = "C SURNAME:";
            // 
            // c_NAMELabel
            // 
            c_NAMELabel.AutoSize = true;
            c_NAMELabel.Location = new System.Drawing.Point(16, 487);
            c_NAMELabel.Name = "c_NAMELabel";
            c_NAMELabel.Size = new System.Drawing.Size(51, 13);
            c_NAMELabel.TabIndex = 16;
            c_NAMELabel.Text = "C NAME:";
            // 
            // c_MIDDLENAMELabel
            // 
            c_MIDDLENAMELabel.AutoSize = true;
            c_MIDDLENAMELabel.Location = new System.Drawing.Point(16, 513);
            c_MIDDLENAMELabel.Name = "c_MIDDLENAMELabel";
            c_MIDDLENAMELabel.Size = new System.Drawing.Size(92, 13);
            c_MIDDLENAMELabel.TabIndex = 18;
            c_MIDDLENAMELabel.Text = "C MIDDLENAME:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrdeTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.Product_ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurchaseTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShope.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(969, 25);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
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
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 40);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(944, 240);
            this.customerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Customer";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Customer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "C_telephone";
            this.dataGridViewTextBoxColumn2.HeaderText = "C_telephone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "C_SEX";
            this.dataGridViewCheckBoxColumn1.HeaderText = "C_SEX";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "C_STRIT";
            this.dataGridViewTextBoxColumn3.HeaderText = "C_STRIT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "C_HOME";
            this.dataGridViewTextBoxColumn4.HeaderText = "C_HOME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "C_FLAT";
            this.dataGridViewTextBoxColumn5.HeaderText = "C_FLAT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "C_SURNAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "C_SURNAME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "C_NAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "C_NAME";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "C_MIDDLENAME";
            this.dataGridViewTextBoxColumn8.HeaderText = "C_MIDDLENAME";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // iD_CustomerTextBox
            // 
            this.iD_CustomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ID_Customer", true));
            this.iD_CustomerTextBox.Location = new System.Drawing.Point(114, 298);
            this.iD_CustomerTextBox.Name = "iD_CustomerTextBox";
            this.iD_CustomerTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_CustomerTextBox.TabIndex = 3;
            // 
            // c_telephoneTextBox
            // 
            this.c_telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_telephone", true));
            this.c_telephoneTextBox.Location = new System.Drawing.Point(114, 324);
            this.c_telephoneTextBox.Name = "c_telephoneTextBox";
            this.c_telephoneTextBox.Size = new System.Drawing.Size(104, 20);
            this.c_telephoneTextBox.TabIndex = 5;
            // 
            // c_SEXCheckBox
            // 
            this.c_SEXCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customerBindingSource, "C_SEX", true));
            this.c_SEXCheckBox.Location = new System.Drawing.Point(114, 350);
            this.c_SEXCheckBox.Name = "c_SEXCheckBox";
            this.c_SEXCheckBox.Size = new System.Drawing.Size(104, 24);
            this.c_SEXCheckBox.TabIndex = 7;
            this.c_SEXCheckBox.Text = "checkBox1";
            this.c_SEXCheckBox.UseVisualStyleBackColor = true;
            // 
            // c_STRITTextBox
            // 
            this.c_STRITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_STRIT", true));
            this.c_STRITTextBox.Location = new System.Drawing.Point(114, 380);
            this.c_STRITTextBox.Name = "c_STRITTextBox";
            this.c_STRITTextBox.Size = new System.Drawing.Size(104, 20);
            this.c_STRITTextBox.TabIndex = 9;
            // 
            // c_HOMETextBox
            // 
            this.c_HOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_HOME", true));
            this.c_HOMETextBox.Location = new System.Drawing.Point(114, 406);
            this.c_HOMETextBox.Name = "c_HOMETextBox";
            this.c_HOMETextBox.Size = new System.Drawing.Size(104, 20);
            this.c_HOMETextBox.TabIndex = 11;
            // 
            // c_FLATTextBox
            // 
            this.c_FLATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_FLAT", true));
            this.c_FLATTextBox.Location = new System.Drawing.Point(114, 432);
            this.c_FLATTextBox.Name = "c_FLATTextBox";
            this.c_FLATTextBox.Size = new System.Drawing.Size(104, 20);
            this.c_FLATTextBox.TabIndex = 13;
            // 
            // c_SURNAMETextBox
            // 
            this.c_SURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_SURNAME", true));
            this.c_SURNAMETextBox.Location = new System.Drawing.Point(114, 458);
            this.c_SURNAMETextBox.Name = "c_SURNAMETextBox";
            this.c_SURNAMETextBox.Size = new System.Drawing.Size(104, 20);
            this.c_SURNAMETextBox.TabIndex = 15;
            // 
            // c_NAMETextBox
            // 
            this.c_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_NAME", true));
            this.c_NAMETextBox.Location = new System.Drawing.Point(114, 484);
            this.c_NAMETextBox.Name = "c_NAMETextBox";
            this.c_NAMETextBox.Size = new System.Drawing.Size(104, 20);
            this.c_NAMETextBox.TabIndex = 17;
            // 
            // c_MIDDLENAMETextBox
            // 
            this.c_MIDDLENAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "C_MIDDLENAME", true));
            this.c_MIDDLENAMETextBox.Location = new System.Drawing.Point(114, 510);
            this.c_MIDDLENAMETextBox.Name = "c_MIDDLENAMETextBox";
            this.c_MIDDLENAMETextBox.Size = new System.Drawing.Size(104, 20);
            this.c_MIDDLENAMETextBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "New record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 22;
            this.button3.Text = "Главная страница";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 546);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_CustomerLabel);
            this.Controls.Add(this.iD_CustomerTextBox);
            this.Controls.Add(c_telephoneLabel);
            this.Controls.Add(this.c_telephoneTextBox);
            this.Controls.Add(c_SEXLabel);
            this.Controls.Add(this.c_SEXCheckBox);
            this.Controls.Add(c_STRITLabel);
            this.Controls.Add(this.c_STRITTextBox);
            this.Controls.Add(c_HOMELabel);
            this.Controls.Add(this.c_HOMETextBox);
            this.Controls.Add(c_FLATLabel);
            this.Controls.Add(this.c_FLATTextBox);
            this.Controls.Add(c_SURNAMELabel);
            this.Controls.Add(this.c_SURNAMETextBox);
            this.Controls.Add(c_NAMELabel);
            this.Controls.Add(this.c_NAMETextBox);
            this.Controls.Add(c_MIDDLENAMELabel);
            this.Controls.Add(this.c_MIDDLENAMETextBox);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerBindingNavigator);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox iD_CustomerTextBox;
        private System.Windows.Forms.TextBox c_telephoneTextBox;
        private System.Windows.Forms.CheckBox c_SEXCheckBox;
        private System.Windows.Forms.TextBox c_STRITTextBox;
        private System.Windows.Forms.TextBox c_HOMETextBox;
        private System.Windows.Forms.TextBox c_FLATTextBox;
        private System.Windows.Forms.TextBox c_SURNAMETextBox;
        private System.Windows.Forms.TextBox c_NAMETextBox;
        private System.Windows.Forms.TextBox c_MIDDLENAMETextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}