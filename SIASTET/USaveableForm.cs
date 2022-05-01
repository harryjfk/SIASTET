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
    public partial class SaveableForm : CaptionWindow
    {
        

        public SaveableForm()
        {
            FormClosing+= SaveableForm_FormClosing;
            InitializeComponent();
        }
  
        protected void CheckEdit()
        {
            if (Changed && !Loading)
                Text = DefaultText + @"*";
            else
                Text = DefaultText;

        }
        public bool IsEdited()
        {
            return Changed;
        }

        public virtual bool Save()
        {
            return ValidateAll();
        }

        public string DefaultText { get; set; }
        protected  virtual  bool GetChanged()
        {
            return false;
        }
        public bool Changed
        {
            get { return GetChanged(); }
             set
             {
                /* if (Loading == false)
                     changed = value; CheckEdit();*/
             }
        }
        public bool Loading { get; set; }
        public bool CheckClose()
        {
            if (IsEdited())
            {
                var s = ShowDialog("Los datos del formulario han cambiado desea guardarlos?", "Guardar",
                                        MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                bool r = false;
                if (s== DialogResult.Yes)
                    r=Save();
                var res = (s == DialogResult.Cancel) || (s == DialogResult.Yes && !r);
                HintPanel.Visible = s == DialogResult.Yes && !r;
                return res;
            }
            return false;
        }

 
        private void SaveableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = CheckClose();
        }
        protected virtual bool  ValidateAll()
        {
            return true;
        }
        protected DialogResult ShowDialog(string msg,string title,MessageBoxButtons btns,MessageBoxIcon ic)
        {
            return XtraMessageBox.Show(msg, title, btns,ic);
        }
    }
}