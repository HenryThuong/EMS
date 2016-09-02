namespace Electric_Management_System
{
    partial class xemBaoCaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xemBaoCaoForm));
            this.crvReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReport
            // 
            this.crvReport.ActiveViewIndex = -1;
            this.crvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReport.Location = new System.Drawing.Point(0, 0);
            this.crvReport.Name = "crvReport";
            this.crvReport.SelectionFormula = "";
            this.crvReport.ShowCloseButton = false;
            this.crvReport.ShowGroupTreeButton = false;
            this.crvReport.ShowParameterPanelButton = false;
            this.crvReport.ShowRefreshButton = false;
            this.crvReport.Size = new System.Drawing.Size(792, 566);
            this.crvReport.TabIndex = 1;
            this.crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvReport.ViewTimeSelectionFormula = "";
            // 
            // xemBaoCaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.crvReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xemBaoCaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS - Xem Báo Cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xemBaoCaoForm_FormClosing);
            this.Load += new System.EventHandler(this.xemBaoCaoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReport;
    }
}