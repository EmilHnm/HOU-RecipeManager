using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace BaiTapLon
{
    public partial class InHoaDonXuat : Form
    {
        public InHoaDonXuat()
        {
            InitializeComponent();
        }
        public int maHoaDon { get; set; }
        public int tinhTrang { get; set; }

        private void InHoaDonXuat_Load(object sender, EventArgs e)
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
                "{0}\\..\\..\\Report\\InHoaDonXuat.rpt",
                Application.StartupPath
                );
            //load file report
            rpt.Load(rpFile);
            //set tham số cho proceduce trong report
            rpt.SetParameterValue("@param1", this.maHoaDon);
            // check Tình trạng hóa đơn
            CrystalDecisions.CrystalReports.Engine.TextObject
                textObject = rpt.ReportDefinition.ReportObjects["to_status"] as TextObject;
            if (tinhTrang == 0)
            {
                textObject.Text = "Chưa thanh toán";
                textObject.Color = Color.Red;
                
            } else
            {
                textObject.Text = "Đã thanh toán";
                textObject.Color = Color.Green;
            }
            //set sourcce cho report
            cRV_hoaDonXuat.ReportSource = rpt;
            //tạo dữ liệu đăng nhập vào database cho report
            CrystalDecisions.Shared.TableLogOnInfo tableLogOnInfo = new CrystalDecisions.Shared.TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.ServerName = "DESKTOP-40S0GVK";
            tableLogOnInfo.ConnectionInfo.DatabaseName = "BaiTapLon";
            tableLogOnInfo.ConnectionInfo.UserID = "amin";
            tableLogOnInfo.ConnectionInfo.Password = "hoangominh";
            foreach (CrystalDecisions.CrystalReports.Engine.Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(tableLogOnInfo);
            }

            cRV_hoaDonXuat.Refresh();
        }
    }
}
