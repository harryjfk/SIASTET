namespace SIASTET.Codificadores
{
    partial class FrmArtefacto
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
            this.dSDatos = new SIASTET.DSDatos();
            this.t_ArtefactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ArtefactoTableAdapter = new SIASTET.DSDatosTableAdapters.T_ArtefactoTableAdapter();
            this.tableAdapterManager = new SIASTET.DSDatosTableAdapters.TableAdapterManager();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameartefacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_ArtefactoGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_TipoArtefactoTableAdapter1 = new SIASTET.DSDatosTableAdapters.T_TipoArtefactoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ArtefactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ArtefactoGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 392);
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(484, 30);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(428, 36);
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_ArtefactoBindingSource
            // 
            this.t_ArtefactoBindingSource.DataMember = "T_Artefacto";
            this.t_ArtefactoBindingSource.DataSource = this.dSDatos;
            // 
            // t_ArtefactoTableAdapter
            // 
            this.t_ArtefactoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_ArtefactoTableAdapter = this.t_ArtefactoTableAdapter;
            this.tableAdapterManager.T_EmpresaTableAdapter = null;
            this.tableAdapterManager.T_EquipoTableAdapter = null;
            this.tableAdapterManager.T_EstadoFisicoTableAdapter = null;
            this.tableAdapterManager.T_MarcaTableAdapter = null;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_ProvinciaTableAdapter = null;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SIASTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameartefacto});
            this.gridView1.GridControl = this.t_ArtefactoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colnameartefacto
            // 
            this.colnameartefacto.FieldName = "nameartefacto";
            this.colnameartefacto.Name = "colnameartefacto";
            this.colnameartefacto.Visible = true;
            this.colnameartefacto.VisibleIndex = 0;
            // 
            // t_ArtefactoGridControl
            // 
            this.t_ArtefactoGridControl.DataSource = this.t_ArtefactoBindingSource;
            this.t_ArtefactoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_ArtefactoGridControl.Location = new System.Drawing.Point(0, 40);
            this.t_ArtefactoGridControl.MainView = this.gridView1;
            this.t_ArtefactoGridControl.Name = "t_ArtefactoGridControl";
            this.t_ArtefactoGridControl.Size = new System.Drawing.Size(484, 352);
            this.t_ArtefactoGridControl.TabIndex = 2;
            this.t_ArtefactoGridControl.UseEmbeddedNavigator = true;
            this.t_ArtefactoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // t_TipoArtefactoTableAdapter1
            // 
            this.t_TipoArtefactoTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmArtefacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 422);
            this.Controls.Add(this.t_ArtefactoGridControl);
            this.Name = "FrmArtefacto";
            this.Text = "FrmTipoEquipo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTipoEquipo_FormClosed);
            this.Load += new System.EventHandler(this.FrmTipoEquipo_Load);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.t_ArtefactoGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ArtefactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ArtefactoGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_ArtefactoBindingSource;
        private DSDatosTableAdapters.T_ArtefactoTableAdapter t_ArtefactoTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnameartefacto;
        private DevExpress.XtraGrid.GridControl t_ArtefactoGridControl;
        private DSDatosTableAdapters.T_TipoArtefactoTableAdapter t_TipoArtefactoTableAdapter1;

    }
}