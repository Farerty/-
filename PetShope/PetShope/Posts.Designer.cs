﻿
namespace PetShope
{
    partial class Posts
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
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label p_SALARYLabel;
            System.Windows.Forms.Label p_POSTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posts));
            this.dataSet1 = new PetShope.DataSet1();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new PetShope.DataSet1TableAdapters.PostsTableAdapter();
            this.tableAdapterManager = new PetShope.DataSet1TableAdapters.TableAdapterManager();
            this.postsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.postsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.postsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.p_SALARYTextBox = new System.Windows.Forms.TextBox();
            this.p_POSTTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            p_IDLabel = new System.Windows.Forms.Label();
            p_SALARYLabel = new System.Windows.Forms.Label();
            p_POSTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingNavigator)).BeginInit();
            this.postsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(23, 266);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(31, 13);
            p_IDLabel.TabIndex = 2;
            p_IDLabel.Text = "P ID:";
            // 
            // p_SALARYLabel
            // 
            p_SALARYLabel.AutoSize = true;
            p_SALARYLabel.Location = new System.Drawing.Point(23, 292);
            p_SALARYLabel.Name = "p_SALARYLabel";
            p_SALARYLabel.Size = new System.Drawing.Size(62, 13);
            p_SALARYLabel.TabIndex = 4;
            p_SALARYLabel.Text = "P SALARY:";
            // 
            // p_POSTLabel
            // 
            p_POSTLabel.AutoSize = true;
            p_POSTLabel.Location = new System.Drawing.Point(23, 318);
            p_POSTLabel.Name = "p_POSTLabel";
            p_POSTLabel.Size = new System.Drawing.Size(49, 13);
            p_POSTLabel.TabIndex = 6;
            p_POSTLabel.Text = "P POST:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.dataSet1;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrdeTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = this.postsTableAdapter;
            this.tableAdapterManager.Product_ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurchaseTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShope.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postsBindingNavigator
            // 
            this.postsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postsBindingNavigator.BindingSource = this.postsBindingSource;
            this.postsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postsBindingNavigatorSaveItem});
            this.postsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postsBindingNavigator.Name = "postsBindingNavigator";
            this.postsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postsBindingNavigator.Size = new System.Drawing.Size(379, 25);
            this.postsBindingNavigator.TabIndex = 0;
            this.postsBindingNavigator.Text = "bindingNavigator1";
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
            // postsBindingNavigatorSaveItem
            // 
            this.postsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postsBindingNavigatorSaveItem.Image")));
            this.postsBindingNavigatorSaveItem.Name = "postsBindingNavigatorSaveItem";
            this.postsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.postsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postsBindingNavigatorSaveItem.Click += new System.EventHandler(this.postsBindingNavigatorSaveItem_Click);
            // 
            // postsDataGridView
            // 
            this.postsDataGridView.AutoGenerateColumns = false;
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.postsDataGridView.DataSource = this.postsBindingSource;
            this.postsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.Size = new System.Drawing.Size(346, 220);
            this.postsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "P_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "P_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "P_SALARY";
            this.dataGridViewTextBoxColumn2.HeaderText = "P_SALARY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "P_POST";
            this.dataGridViewTextBoxColumn3.HeaderText = "P_POST";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "P_ID", true));
            this.p_IDTextBox.Location = new System.Drawing.Point(91, 263);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_IDTextBox.TabIndex = 3;
            // 
            // p_SALARYTextBox
            // 
            this.p_SALARYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "P_SALARY", true));
            this.p_SALARYTextBox.Location = new System.Drawing.Point(91, 289);
            this.p_SALARYTextBox.Name = "p_SALARYTextBox";
            this.p_SALARYTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_SALARYTextBox.TabIndex = 5;
            // 
            // p_POSTTextBox
            // 
            this.p_POSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "P_POST", true));
            this.p_POSTTextBox.Location = new System.Drawing.Point(91, 315);
            this.p_POSTTextBox.Name = "p_POSTTextBox";
            this.p_POSTTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_POSTTextBox.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 31;
            this.button3.Text = "Главная страница";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "New record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Posts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 349);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(p_SALARYLabel);
            this.Controls.Add(this.p_SALARYTextBox);
            this.Controls.Add(p_POSTLabel);
            this.Controls.Add(this.p_POSTTextBox);
            this.Controls.Add(this.postsDataGridView);
            this.Controls.Add(this.postsBindingNavigator);
            this.Name = "Posts";
            this.Text = "Posts";
            this.Load += new System.EventHandler(this.Posts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingNavigator)).EndInit();
            this.postsBindingNavigator.ResumeLayout(false);
            this.postsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private DataSet1TableAdapters.PostsTableAdapter postsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView postsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox p_SALARYTextBox;
        private System.Windows.Forms.TextBox p_POSTTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}