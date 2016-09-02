namespace Electric_Management_System
{
    partial class dsChotSoDienForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dsChotSoDienForm));
            this.dgvDsChotSo = new System.Windows.Forms.DataGridView();
            this.chotSoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHieuCongToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDSChotSoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDBDataSet = new Electric_Management_System.App_Data.EMSDBDataSet();
            this.txtSoHieuCongTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboMaSoKH = new System.Windows.Forms.ComboBox();
            this.cboTramDien = new System.Windows.Forms.ComboBox();
            this.tbl_DSChotSoTableAdapter = new Electric_Management_System.App_Data.EMSDBDataSetTableAdapters.tbl_DSChotSoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsChotSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDSChotSoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDBDataSet)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsChotSo
            // 
            this.dgvDsChotSo.AllowUserToAddRows = false;
            this.dgvDsChotSo.AllowUserToDeleteRows = false;
            this.dgvDsChotSo.AllowUserToResizeRows = false;
            this.dgvDsChotSo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsChotSo.AutoGenerateColumns = false;
            this.dgvDsChotSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsChotSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsChotSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsChotSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chotSoIDDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.customerNumberDataGridViewTextBoxColumn,
            this.soHieuCongToDataGridViewTextBoxColumn});
            this.dgvDsChotSo.DataSource = this.tblDSChotSoBindingSource;
            this.dgvDsChotSo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDsChotSo.Location = new System.Drawing.Point(12, 12);
            this.dgvDsChotSo.MultiSelect = false;
            this.dgvDsChotSo.Name = "dgvDsChotSo";
            this.dgvDsChotSo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsChotSo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDsChotSo.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsChotSo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDsChotSo.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsChotSo.RowTemplate.ReadOnly = true;
            this.dgvDsChotSo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDsChotSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsChotSo.Size = new System.Drawing.Size(511, 537);
            this.dgvDsChotSo.TabIndex = 8;
            this.dgvDsChotSo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDsChotSo_CellMouseClick);
            // 
            // chotSoIDDataGridViewTextBoxColumn
            // 
            this.chotSoIDDataGridViewTextBoxColumn.DataPropertyName = "ChotSoID";
            this.chotSoIDDataGridViewTextBoxColumn.HeaderText = "ChotSoID";
            this.chotSoIDDataGridViewTextBoxColumn.Name = "chotSoIDDataGridViewTextBoxColumn";
            this.chotSoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.chotSoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNumberDataGridViewTextBoxColumn
            // 
            this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
            this.customerNumberDataGridViewTextBoxColumn.HeaderText = "Mã Số KH";
            this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
            this.customerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soHieuCongToDataGridViewTextBoxColumn
            // 
            this.soHieuCongToDataGridViewTextBoxColumn.DataPropertyName = "SoHieuCongTo";
            this.soHieuCongToDataGridViewTextBoxColumn.HeaderText = "Số Hiệu Công Tơ";
            this.soHieuCongToDataGridViewTextBoxColumn.Name = "soHieuCongToDataGridViewTextBoxColumn";
            this.soHieuCongToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblDSChotSoBindingSource
            // 
            this.tblDSChotSoBindingSource.DataMember = "tbl_DSChotSo";
            this.tblDSChotSoBindingSource.DataSource = this.eMSDBDataSet;
            // 
            // eMSDBDataSet
            // 
            this.eMSDBDataSet.DataSetName = "EMSDBDataSet";
            this.eMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSoHieuCongTo
            // 
            this.txtSoHieuCongTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoHieuCongTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider.SetIconAlignment(this.txtSoHieuCongTo, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtSoHieuCongTo.Location = new System.Drawing.Point(598, 97);
            this.txtSoHieuCongTo.Name = "txtSoHieuCongTo";
            this.txtSoHieuCongTo.Size = new System.Drawing.Size(174, 21);
            this.txtSoHieuCongTo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trạm điện";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã số KH";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider.SetIconAlignment(this.txtHoTen, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtHoTen.Location = new System.Drawing.Point(598, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(174, 21);
            this.txtHoTen.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số hiệu\r\ncông tơ";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Electric_Management_System.Properties.Resources.print_16;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(529, 522);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 27);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "      In ra";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Electric_Management_System.Properties.Resources.Close_Box_Red;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(685, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "      Đóng lại";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::Electric_Management_System.Properties.Resources.Cancel_16x16;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(692, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 27);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "    Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Electric_Management_System.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(598, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "      Lưu lại";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewLine
            // 
            this.btnNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLine.Image = global::Electric_Management_System.Properties.Resources.Add_16x16;
            this.btnNewLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewLine.Location = new System.Drawing.Point(598, 124);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(174, 27);
            this.btnNewLine.TabIndex = 12;
            this.btnNewLine.Text = "     Thêm dòng trắng";
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator3,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(148, 132);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.view_refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.refreshToolStripMenuItem.Text = "Cập nhật";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(144, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Edit_16x16;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editToolStripMenuItem.Text = "Sửa dòng này";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Delete_16x16;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deleteToolStripMenuItem.Text = "Xóa dòng này";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.print_16;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.printToolStripMenuItem.Text = "In ra";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Close_Box_Red;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.closeToolStripMenuItem.Text = "Đóng lại";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cboMaSoKH
            // 
            this.cboMaSoKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaSoKH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaSoKH.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.cboMaSoKH, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.cboMaSoKH.Location = new System.Drawing.Point(598, 41);
            this.cboMaSoKH.Name = "cboMaSoKH";
            this.cboMaSoKH.Size = new System.Drawing.Size(174, 23);
            this.cboMaSoKH.TabIndex = 18;
            this.cboMaSoKH.TextChanged += new System.EventHandler(this.cboMaSoKH_TextChanged);
            // 
            // cboTramDien
            // 
            this.cboTramDien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTramDien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTramDien.FormattingEnabled = true;
            this.cboTramDien.Location = new System.Drawing.Point(598, 12);
            this.cboTramDien.MaxLength = 50;
            this.cboTramDien.Name = "cboTramDien";
            this.cboTramDien.Size = new System.Drawing.Size(174, 23);
            this.cboTramDien.TabIndex = 17;
            this.cboTramDien.SelectionChangeCommitted += new System.EventHandler(this.cboTramDien_SelectionChangeCommitted);
            // 
            // tbl_DSChotSoTableAdapter
            // 
            this.tbl_DSChotSoTableAdapter.ClearBeforeFill = true;
            // 
            // dsChotSoDienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cboMaSoKH);
            this.Controls.Add(this.cboTramDien);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewLine);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSoHieuCongTo);
            this.Controls.Add(this.dgvDsChotSo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "dsChotSoDienForm";
            this.Text = "EMS - Danh Sách Chốt Số Điện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ghiSoDienDSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsChotSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDSChotSoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDBDataSet)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsChotSo;
        private App_Data.EMSDBDataSet eMSDBDataSet;
        private System.Windows.Forms.BindingSource tblDSChotSoBindingSource;
        private App_Data.EMSDBDataSetTableAdapters.tbl_DSChotSoTableAdapter tbl_DSChotSoTableAdapter;
        private System.Windows.Forms.TextBox txtSoHieuCongTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewLine;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cboTramDien;
        private System.Windows.Forms.ComboBox cboMaSoKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn chotSoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHieuCongToDataGridViewTextBoxColumn;






    }
}