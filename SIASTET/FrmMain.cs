using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SIASTET.Codificadores;

namespace SIASTET
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form HasForm(String type)
        {
            foreach (Form mdiChild in MdiChildren)
            {

                if (mdiChild.GetType().ToString() == type)

                    return mdiChild;

            } return null;
        }


        private Form CreateForm(Form form, BarItem item = null)
        {
            Form s = null;
            if (form is SaveableForm /*|| form is FrmUserManager || form is FrmReportManager || form is FrmIncidenciasEquipo*/)
            {
                s = HasForm(form.GetType().ToString());

                if (s == null)
                {
                    form.MdiParent = this;
                    s = form;
                }
            }
            else

                s = form;

            //if (s is CaptionWindow)
          ///      ((CaptionWindow)s).SetTitleInfo((Bitmap)largeimages.Images[item.ImageIndex], item.Hint);
            if (s is SaveableForm /*|| form is FrmUserManager || form is FrmReportManager || form is FrmReport || form is FrmIncidenciasEquipo*/)
            {
                s.Show();
                s.BringToFront();
              //  layoutControl1.Hide();
            }
            else


                s.ShowDialog(this);
            return s;

        }
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
   //         new DataSet1.T_AccRolOperacionesRow[0];
            //CreateForm(new FrmArtefacto(Int32.Parse( e.Link.Item.Tag.ToString())));
        }

      
    }
}