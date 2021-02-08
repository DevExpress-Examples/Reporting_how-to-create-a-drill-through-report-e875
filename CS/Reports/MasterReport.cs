using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraReports.UI;
// ...

namespace DrillThroughReport {
    public partial class MasterReport : DevExpress.XtraReports.UI.XtraReport {
        public MasterReport() {
            InitializeComponent();
        }

        private void xrLabel1_BeforePrint(object sender, PrintEventArgs e) {
            ((XRLabel)sender).Tag = GetCurrentRow();
        }

        private void xrLabel1_PreviewClick(object sender, PreviewMouseEventArgs e) {
            DetailReport detailReport = new DetailReport();
            IRow row = (IRow)e.Brick.Value;
            detailReport.Parameters["catId"].Value = row["CategoryID"];
            detailReport.Parameters["catName"].Value = row["CategoryName"];
            ReportPrintTool pt = new ReportPrintTool(detailReport);
            pt.ShowPreviewDialog();
        }

        private void xrLabel1_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }

    }
}
