
namespace BaiTapLon
{
    partial class InHoaDonXuat
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
            this.cRV_hoaDonXuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cRV_hoaDonXuat
            // 
            this.cRV_hoaDonXuat.ActiveViewIndex = -1;
            this.cRV_hoaDonXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRV_hoaDonXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRV_hoaDonXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRV_hoaDonXuat.Location = new System.Drawing.Point(0, 0);
            this.cRV_hoaDonXuat.Name = "cRV_hoaDonXuat";
            this.cRV_hoaDonXuat.Size = new System.Drawing.Size(800, 450);
            this.cRV_hoaDonXuat.TabIndex = 0;
            // 
            // InHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cRV_hoaDonXuat);
            this.Name = "InHoaDonXuat";
            this.Text = "Hóa Đơn Xuất";
            this.Load += new System.EventHandler(this.InHoaDonXuat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRV_hoaDonXuat;
    }
}