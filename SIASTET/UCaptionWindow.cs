using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SIASTET
{
    public partial class CaptionWindow : DevExpress.XtraEditors.XtraForm
    {
        public CaptionWindow()
        {
            InitializeComponent();
        }
        public void SetTitleInfo(Bitmap graph, String Title)
        {
            toppicture.Image = graph;
            toplabel.Text = Title;
            Text = Title;
        }

    }
}