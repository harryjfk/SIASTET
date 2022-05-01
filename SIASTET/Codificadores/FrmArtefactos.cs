using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SIASTET.Codificadores
{
    public partial class FrmArtefacto : CodificadorForm
    {
        public FrmArtefacto()
        {
            InitializeComponent();
        }
        public FrmArtefacto(int idartefacto)
        {
            artefacto = idartefacto;
            InitializeComponent();
        }

        public int artefacto { get; set; }
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            this.t_ArtefactoTableAdapter.Update(this.dSDatos.T_Artefacto);
        }

        private void FrmTipoEquipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.t_ArtefactoTableAdapter.Update(this.dSDatos.T_Artefacto);
        }

        private void FrmTipoEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Artefacto' Puede moverla o quitarla según sea necesario.
            this.t_ArtefactoTableAdapter.FillBy(this.dSDatos.T_Artefacto,artefacto);
            dSDatos.T_Artefacto.idtipoartefactoColumn.DefaultValue = artefacto;
            t_TipoArtefactoTableAdapter1.Fill(dSDatos.T_TipoArtefacto);
            colnameartefacto.Caption = "Tipo de " +dSDatos.T_TipoArtefacto.FindByidtipoartefacto(artefacto).nametipoartefacto;
            Text = "Definir Tipos de " + dSDatos.T_TipoArtefacto.FindByidtipoartefacto(artefacto).nametipoartefacto;
            //   t_TipoEquipoTableAdapter.Fill(dSDatos.T_TipoEquipo);
        }

       
    }
}