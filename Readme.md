<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* **[MasterReport.cs](./CS/MasterReport.cs) (VB: [MasterReport.vb](./VB/MasterReport.vb))**
<!-- default file list end -->
# How to Create a Drill-Through Report


This example demonstrates a [drill-through report](https://docs.devexpress.com/XtraReports/4789).

You can click the data-bound label in the master report preview to invoke the detail report. The code that handles the [PreviewClick](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.PreviewClick) event passes the record ID from the master report to the detail report as a parameter.

This version uses the [DataTable](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) as the data source created at runtime. Refer to v20.1 for an example that uses the [SqlDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Sql.SqlDataSource) and Microsoft Access database.