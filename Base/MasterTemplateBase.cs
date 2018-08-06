using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MLP.CASA.Interface;

namespace Ventas.Base
{
    public class MasterTemplateBase
    {
        public static readonly MasterTemplateBase Instance = new MasterTemplateBase();

        public void BuildForm(ref System.Windows.Forms.Panel pnlSpaceWork, string NameOfForm, bool Fill, string NameForm, InfUsuario_SIA InfUsr)
        {
            try
            {

                Form fa = null;
                if (!CheckInstance(ref pnlSpaceWork, NameOfForm))
                {
                    Assembly asm = Assembly.GetEntryAssembly();
                    //Invoca el Assembly donde estan los catálogos [Forms]
                    Type formtype = asm.GetType("Ventas.Formularios." + NameOfForm);
                    fa = (Form)Activator.CreateInstance(formtype, new object[] { NameForm, InfUsr });
                    //fa = (Form)Activator.CreateInstance(formtype, true);
                    fa.TopLevel = false;
                    fa.Dock = DockStyle.Fill;
                    fa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    fa.StartPosition = FormStartPosition.CenterParent;
                    fa.Parent = pnlSpaceWork;
                    if (Fill)
                    {
                        fa.Width = pnlSpaceWork.Width;
                        fa.Height = pnlSpaceWork.Height;
                    }
                    else
                    {
                        pnlSpaceWork.Width = fa.Width;
                        pnlSpaceWork.Height = fa.Height;
                    }

                    pnlSpaceWork.Controls.Add(fa);
                }
                // MinimizedAllForms(ref pnlSpaceWork);
                //ShowFormForms(ref pnlSpaceWork, NameOfForm);
                // SetVisiblepnlManifest(ref pnlSpaceWork, true);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool CheckInstance(ref System.Windows.Forms.Panel pnlSpaceWork, string NameOfForm)
        {
            foreach (Control ctr in pnlSpaceWork.Controls)
            {
                if (ctr.Name == NameOfForm)
                {
                    return true;
                }
            }
            return false;

        }
        public void ShowFormForms(ref System.Windows.Forms.Panel pnlSpaceWork, string NameOfForm)
        {
            foreach (Control ctr in pnlSpaceWork.Controls)
            {
                if (ctr.Name == NameOfForm)
                {
                    ((System.Windows.Forms.Form)(pnlSpaceWork.Controls[ctr.Name])).Show();
                    //((System.Windows.Forms.Form)(pnlSpaceWork.Controls[ctr.Name])).Visible = true;
                    //((System.Windows.Forms.Form)(pnlSpaceWork.Controls[ctr.Name])).WindowState = FormWindowState.Maximized;
                    //pnlSpaceWork.Width = ((System.Windows.Forms.Form)(pnlSpaceWork.Controls[ctr.Name])).Width;
                    //pnlSpaceWork.Height = ((System.Windows.Forms.Form)(pnlSpaceWork.Controls[ctr.Name])).Height;
                    //((System.Windows.Forms.Form)(pnlSpaceWork.Controls[ctr.Name])).WindowState = FormWindowState.Normal;
                }
            }
        }
        private void SetVisiblepnlManifest(ref System.Windows.Forms.Panel pnlSpaceWork, bool bVisible)
        {
            pnlSpaceWork.Visible = bVisible;

        }

        public void MinimizedAllForms(ref System.Windows.Forms.Panel pnlSpaceWork)
        {
            foreach (Control ctr in pnlSpaceWork.Controls)
            {
                pnlSpaceWork.Controls[ctr.Name].Hide();
            }
        }
        public void CloseAllForms(ref System.Windows.Forms.Panel pnlSpaceWork)
        {
            foreach (Control ctr in pnlSpaceWork.Controls)
            {
                ((System.Windows.Forms.Form)(pnlSpaceWork.Controls[ctr.Name])).Close();
            }
        }
      
    }
}
