using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorOffice
{
    public partial class FRMMedics : Form
    {
        public FRMMedics()
        {
            InitializeComponent();
        }

        private void IBTRegister_Click(object sender, EventArgs e)
        {
            using(DoctorOfficeEntities db = new DoctorOfficeEntities())
            {
                Medics m = new Medics();
                m.Name = TXTName.Text;
                m.Surname = TXTSurname.Text;
                m.NumberTuition = Convert.ToInt32(TXTNumberTuition.Text);

                db.Medics.Add(m);
                db.SaveChanges();

                DGVMedics.DataSource = db.Medics.ToList();
            }
        }

        private void FRMMedics_Load(object sender, EventArgs e)
        {
            using (DoctorOfficeEntities db = new DoctorOfficeEntities())
            {
                DGVMedics.DataSource = db.Medics.ToList();
            }
        }

        private void IBTModify_Click(object sender, EventArgs e)
        {
            if (DGVMedics.Selected())
            {
                DataGridViewRow row = DGVMedics.SelectedRows[0];
                Medics m = (Medics)row.DataBoundItem;

                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    m = db.Medics.Find(m.MedicKey);
                    m.Name = TXTName.Text;
                    m.Surname = TXTSurname.Text;
                    m.NumberTuition = Convert.ToInt32(TXTNumberTuition.Text);

                    db.Entry(m).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    DGVMedics.DataSource = db.Medics.ToList();
                }
            }
        }

        private void IBTDown_Click(object sender, EventArgs e)
        {
            if (DGVMedics.Selected())
            {
                DataGridViewRow row = DGVMedics.SelectedRows[0];
                Medics m = (Medics)row.DataBoundItem;

                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    m = db.Medics.Find(m.MedicKey);
                    db.Medics.Remove(m);
                    db.SaveChanges();

                    DGVMedics.DataSource = db.Medics.ToList();
                }
            }
        }

        #region TextBoxesHandlersOnEnter

        private void TXTName_Enter(object sender, EventArgs e)
        {
            ToolsUI.TextBoxEnter(sender, ToolsUI.ControlsTXT.NameControl.Name);
        }
        private void TXTSurname_Enter(object sender, EventArgs e)
        {
            ToolsUI.TextBoxEnter(sender, ToolsUI.ControlsTXT.SurnameControl.Name);
        }
        private void TXTNumberTuition_Enter(object sender, EventArgs e)
        {
            ToolsUI.TextBoxEnter(sender, ToolsUI.ControlsTXT.NumberTuitionControl.Name);
        }

        #endregion

        #region TextBoxesHandlersOnLeave

        private void TXTName_Leave(object sender, EventArgs e)
        {
            ToolsUI.placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.NameControl.Name);
            if (!ToolsUI.placeholder) ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.NameControl.regExpression);
        }
        private void TXTSurname_Leave(object sender, EventArgs e)
        {
            ToolsUI.placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.SurnameControl.Name);
            if (!ToolsUI.placeholder) ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.SurnameControl.regExpression);
        }
        private void TXTNumberTuition_Leave(object sender, EventArgs e)
        {
            ToolsUI.placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.NumberTuitionControl.Name);
            if (!ToolsUI.placeholder) ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.NumberTuitionControl.regExpression);
        }

        #endregion

    }
}
