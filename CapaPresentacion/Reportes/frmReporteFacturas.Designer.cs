
namespace CapaPresentacion
{
    partial class frmReporteFacturas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtPrincipal = new CapaPresentacion.dtPrincipal();
            this.spreporte_ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spreporte_ventaTableAdapter = new CapaPresentacion.dtPrincipalTableAdapters.spreporte_ventaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spreporte_ventaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptComprobanteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(973, 731);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtPrincipal
            // 
            this.dtPrincipal.DataSetName = "dtPrincipal";
            this.dtPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporte_ventaBindingSource
            // 
            this.spreporte_ventaBindingSource.DataMember = "spreporte_venta";
            this.spreporte_ventaBindingSource.DataSource = this.dtPrincipal;
            // 
            // spreporte_ventaTableAdapter
            // 
            this.spreporte_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 731);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReporteFacturas";
            this.Text = "......:Factura:.....";
            this.Load += new System.EventHandler(this.frmReporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_ventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporte_ventaBindingSource;
        private dtPrincipal dtPrincipal;
        private dtPrincipalTableAdapters.spreporte_ventaTableAdapter spreporte_ventaTableAdapter;
    }
}