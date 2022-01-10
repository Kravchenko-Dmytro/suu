namespace suu
{
    partial class Form_university
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_university));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.suuDataSet = new suu.suuDataSet();
            this.suuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settinguniversityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setting_universityTableAdapter = new suu.suuDataSetTableAdapters.setting_universityTableAdapter();
            this.iduniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortnameuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteuniversityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settinguniversityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduniversityDataGridViewTextBoxColumn,
            this.nameuniversityDataGridViewTextBoxColumn,
            this.shortnameuniversityDataGridViewTextBoxColumn,
            this.adressuniversityDataGridViewTextBoxColumn,
            this.phoneuniversityDataGridViewTextBoxColumn,
            this.siteuniversityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.settinguniversityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.settinguniversityBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1023, 31);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // suuDataSet
            // 
            this.suuDataSet.DataSetName = "suuDataSet";
            this.suuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suuDataSetBindingSource
            // 
            this.suuDataSetBindingSource.DataSource = this.suuDataSet;
            this.suuDataSetBindingSource.Position = 0;
            // 
            // settinguniversityBindingSource
            // 
            this.settinguniversityBindingSource.DataMember = "setting_university";
            this.settinguniversityBindingSource.DataSource = this.suuDataSetBindingSource;
            // 
            // setting_universityTableAdapter
            // 
            this.setting_universityTableAdapter.ClearBeforeFill = true;
            // 
            // iduniversityDataGridViewTextBoxColumn
            // 
            this.iduniversityDataGridViewTextBoxColumn.DataPropertyName = "id_university";
            this.iduniversityDataGridViewTextBoxColumn.HeaderText = "id_university";
            this.iduniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduniversityDataGridViewTextBoxColumn.Name = "iduniversityDataGridViewTextBoxColumn";
            this.iduniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameuniversityDataGridViewTextBoxColumn
            // 
            this.nameuniversityDataGridViewTextBoxColumn.DataPropertyName = "name_university";
            this.nameuniversityDataGridViewTextBoxColumn.HeaderText = "name_university";
            this.nameuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameuniversityDataGridViewTextBoxColumn.Name = "nameuniversityDataGridViewTextBoxColumn";
            this.nameuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // shortnameuniversityDataGridViewTextBoxColumn
            // 
            this.shortnameuniversityDataGridViewTextBoxColumn.DataPropertyName = "short_name_university";
            this.shortnameuniversityDataGridViewTextBoxColumn.HeaderText = "short_name_university";
            this.shortnameuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shortnameuniversityDataGridViewTextBoxColumn.Name = "shortnameuniversityDataGridViewTextBoxColumn";
            this.shortnameuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressuniversityDataGridViewTextBoxColumn
            // 
            this.adressuniversityDataGridViewTextBoxColumn.DataPropertyName = "adress_university";
            this.adressuniversityDataGridViewTextBoxColumn.HeaderText = "adress_university";
            this.adressuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressuniversityDataGridViewTextBoxColumn.Name = "adressuniversityDataGridViewTextBoxColumn";
            this.adressuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneuniversityDataGridViewTextBoxColumn
            // 
            this.phoneuniversityDataGridViewTextBoxColumn.DataPropertyName = "phone_university";
            this.phoneuniversityDataGridViewTextBoxColumn.HeaderText = "phone_university";
            this.phoneuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneuniversityDataGridViewTextBoxColumn.Name = "phoneuniversityDataGridViewTextBoxColumn";
            this.phoneuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // siteuniversityDataGridViewTextBoxColumn
            // 
            this.siteuniversityDataGridViewTextBoxColumn.DataPropertyName = "site_university";
            this.siteuniversityDataGridViewTextBoxColumn.HeaderText = "site_university";
            this.siteuniversityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siteuniversityDataGridViewTextBoxColumn.Name = "siteuniversityDataGridViewTextBoxColumn";
            this.siteuniversityDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Сохранить изменения";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form_university
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_university";
            this.Text = "Університети";
            this.Load += new System.EventHandler(this.Form_university_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settinguniversityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource suuDataSetBindingSource;
        private suuDataSet suuDataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.BindingSource settinguniversityBindingSource;
        private suuDataSetTableAdapters.setting_universityTableAdapter setting_universityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortnameuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteuniversityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}