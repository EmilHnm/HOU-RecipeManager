using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class InHoaDonNhap : Form
    {
        public InHoaDonNhap()
        {
            InitializeComponent();
        }
        public int maHoaDon { get; set; }
        public int tinhTrang { get; set; }

        private void InHoaDonNhap_Load(object sender, EventArgs e)
        {
            showHoaDon();
        }
        
        private void showHoaDon()
        {
            //tạo table cho report
            CrystalDecisions.CrystalReports.Engine.ReportDocument
                rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            //path file report
            string rpFile = String.Format(
                "{0}\\..\\..\\Report\\InHoaDonNhap.rpt",
                Application.StartupPath
                );
            //load file report
            rpt.Load(rpFile);
            //set tham số cho proceduce trong report
            rpt.SetParameterValue("@param1", this.maHoaDon);
            
            //set sourcce cho report
            cRV_hoaDonNhap.ReportSource = rpt;
            //tạo dữ liệu đăng nhập vào database cho report
            CrystalDecisions.Shared.TableLogOnInfo tableLogOnInfo = new CrystalDecisions.Shared.TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.ServerName = "DESKTOP-40S0GVK";
            tableLogOnInfo.ConnectionInfo.DatabaseName = "BaiTapLon";
            tableLogOnInfo.ConnectionInfo.UserID = "amin";
            tableLogOnInfo.ConnectionInfo.Password = "hoangominh";
            foreach(CrystalDecisions.CrystalReports.Engine.Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(tableLogOnInfo);
            }
            
            cRV_hoaDonNhap.Refresh();
        }
    }
}
