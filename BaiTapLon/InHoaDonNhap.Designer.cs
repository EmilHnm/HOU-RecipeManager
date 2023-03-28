
namespace BaiTapLon
{
    partial class InHoaDonNhap
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
            this.cRV_hoaDonNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cRV_hoaDonNhap
            // 
            this.cRV_hoaDonNhap.ActiveViewIndex = -1;
            this.cRV_hoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRV_hoaDonNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRV_hoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRV_hoaDonNhap.Location = new System.Drawing.Point(0, 0);
            this.cRV_hoaDonNhap.Name = "cRV_hoaDonNhap";
            this.cRV_hoaDonNhap.Size = new System.Drawing.Size(800, 450);
            this.cRV_hoaDonNhap.TabIndex = 0;
            // 
            // InHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cRV_hoaDonNhap);
            this.Name = "InHoaDonNhap";
            this.Text = "InHoaDonNhap";
            this.Load += new System.EventHandler(this.InHoaDonNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRV_hoaDonNhap;
    }
}