namespace Electric_Management_System
{
    partial class ghiSoDienDSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ghiSoDienDSForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsChotSoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMSDBDataSet = new Electric_Management_System.App_Data.EMSDBDataSet();
            this.fillDSChotSoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillDSChotSoTableAdapter = new Electric_Management_System.App_Data.EMSDBDataSetTableAdapters.FillDSChotSoTableAdapter();
            this.chotSoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.soHopDienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.soHieuCongToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsChotSoBindingNavigator)).BeginInit();
            this.dsChotSoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillDSChotSoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsChotSoBindingNavigator
            // 
            this.dsChotSoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dsChotSoBindingNavigator.BindingSource = this.fillDSChotSoBindingSource;
            this.dsChotSoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dsChotSoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dsChotSoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.dsChotSoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dsChotSoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dsChotSoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dsChotSoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dsChotSoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dsChotSoBindingNavigator.Name = "dsChotSoBindingNavigator";
            this.dsChotSoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dsChotSoBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.dsChotSoBindingNavigator.TabIndex = 0;
            this.dsChotSoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chotSoIDDataGridViewTextBoxColumn,
            this.Add,
            this.Edit,
            this.soHopDienDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.customerNumberDataGridViewTextBoxColumn,
            this.soHieuCongToDataGridViewTextBoxColumn,
            this.Month1,
            this.Month2,
            this.Month3,
            this.Month4,
            this.Month5,
            this.Month6});
            this.dataGridView1.DataSource = this.fillDSChotSoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(784, 536);
            this.dataGridView1.TabIndex = 1;
            // 
            // eMSDBDataSet
            // 
            this.eMSDBDataSet.DataSetName = "EMSDBDataSet";
            this.eMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillDSChotSoBindingSource
            // 
            this.fillDSChotSoBindingSource.DataMember = "FillDSChotSo";
            this.fillDSChotSoBindingSource.DataSource = this.eMSDBDataSet;
            // 
            // fillDSChotSoTableAdapter
            // 
            this.fillDSChotSoTableAdapter.ClearBeforeFill = true;
            // 
            // chotSoIDDataGridViewTextBoxColumn
            // 
            this.chotSoIDDataGridViewTextBoxColumn.DataPropertyName = "ChotSoID";
            this.chotSoIDDataGridViewTextBoxColumn.HeaderText = "ChotSoID";
            this.chotSoIDDataGridViewTextBoxColumn.Name = "chotSoIDDataGridViewTextBoxColumn";
            this.chotSoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Add
            // 
            this.Add.HeaderText = "";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Add.Text = "+";
            this.Add.ToolTipText = "Thêm";
            this.Add.Width = 20;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "-";
            this.Edit.ToolTipText = "Xóa";
            this.Edit.Width = 20;
            // 
            // soHopDienDataGridViewTextBoxColumn
            // 
            this.soHopDienDataGridViewTextBoxColumn.DataPropertyName = "SoHopDien";
            this.soHopDienDataGridViewTextBoxColumn.HeaderText = "SoHopDien";
            this.soHopDienDataGridViewTextBoxColumn.Name = "soHopDienDataGridViewTextBoxColumn";
            this.soHopDienDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNumberDataGridViewTextBoxColumn
            // 
            this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
            this.customerNumberDataGridViewTextBoxColumn.HeaderText = "Mã Số Thứ Tự";
            this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
            this.customerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // soHieuCongToDataGridViewTextBoxColumn
            // 
            this.soHieuCongToDataGridViewTextBoxColumn.DataPropertyName = "SoHieuCongTo";
            this.soHieuCongToDataGridViewTextBoxColumn.HeaderText = "Số Hiệu Công Tơ";
            this.soHieuCongToDataGridViewTextBoxColumn.Name = "soHieuCongToDataGridViewTextBoxColumn";
            this.soHieuCongToDataGridViewTextBoxColumn.Width = 80;
            // 
            // Month1
            // 
            this.Month1.HeaderText = "Tháng 7/2013";
            this.Month1.Name = "Month1";
            this.Month1.ReadOnly = true;
            // 
            // Month2
            // 
            this.Month2.HeaderText = "Tháng 8/2013";
            this.Month2.Name = "Month2";
            this.Month2.ReadOnly = true;
            // 
            // Month3
            // 
            this.Month3.HeaderText = "Tháng 9/2013";
            this.Month3.Name = "Month3";
            this.Month3.ReadOnly = true;
            // 
            // Month4
            // 
            this.Month4.DataPropertyName = "ChotSoID";
            this.Month4.HeaderText = "Tháng 10/2013";
            this.Month4.Name = "Month4";
            this.Month4.ReadOnly = true;
            // 
            // Month5
            // 
            this.Month5.DataPropertyName = "ChotSoID";
            this.Month5.HeaderText = "Tháng 11/2013";
            this.Month5.Name = "Month5";
            this.Month5.ReadOnly = true;
            // 
            // Month6
            // 
            this.Month6.DataPropertyName = "ChotSoID";
            this.Month6.HeaderText = "Tháng 12/2013";
            this.Month6.Name = "Month6";
            this.Month6.ReadOnly = true;
            // 
            // ghiSoDienDSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dsChotSoBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ghiSoDienDSForm";
            this.Text = "EMS - Danh Sách Chốt Số Điện";
            this.Load += new System.EventHandler(this.ghiSoDienDSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsChotSoBindingNavigator)).EndInit();
            this.dsChotSoBindingNavigator.ResumeLayout(false);
            this.dsChotSoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillDSChotSoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator dsChotSoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource fillDSChotSoBindingSource;
        private App_Data.EMSDBDataSet eMSDBDataSet;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private App_Data.EMSDBDataSetTableAdapters.FillDSChotSoTableAdapter fillDSChotSoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chotSoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHopDienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuCongToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month6;




    }
}