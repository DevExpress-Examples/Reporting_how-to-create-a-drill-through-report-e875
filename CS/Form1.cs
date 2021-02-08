using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace DrillThroughReport {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MasterReport report = new MasterReport();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
