using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoctorOffice
{
    public partial class FRMReception : Form
    {
        private bool placeholder;
        public FRMReception()
        {
            InitializeComponent();
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
        private void TXTDni_Enter(object sender, EventArgs e)
        {
            ToolsUI.TextBoxEnter(sender, ToolsUI.ControlsTXT.DNIControl.Name);
        }
        private void TXTPhone_Enter(object sender, EventArgs e)
        {
            ToolsUI.TextBoxEnter(sender, ToolsUI.ControlsTXT.PhoneControl.Name);
        }
        private void TXTEmail_Enter(object sender, EventArgs e)
        {
            ToolsUI.TextBoxEnter(sender, ToolsUI.ControlsTXT.EmailControl.Name);
        }

        #endregion

        #region TextBoxesHandlersOnLeave

        private void TXTName_Leave(object sender, EventArgs e)
        {
            placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.NameControl.Name);
            if (!placeholder)
            {
                ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.NameControl.regExpression);
            }
        }
        private void TXTSurname_Leave(object sender, EventArgs e)
        {
            placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.SurnameControl.Name);
            if (!placeholder)
            {
                ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.SurnameControl.regExpression);
            }
        }
        private void TXTDni_Leave(object sender, EventArgs e)
        {
            placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.DNIControl.Name);
            if (!placeholder)
            {
                ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.DNIControl.regExpression);
            }
        }
        private void TXTPhone_Leave(object sender, EventArgs e)
        {
            placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.PhoneControl.Name);
            if (!placeholder)
            {
                ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.PhoneControl.regExpression);
            }
        }
        private void TXTEmail_Leave(object sender, EventArgs e)
        {
            placeholder = ToolsUI.TextBoxLeave(sender, ToolsUI.ControlsTXT.EmailControl.Name);
            if (!placeholder)
            {
                ToolsUI.TextBoxValidate(ToolsUI.ControlsTXT.EmailControl.regExpression);
            }
        }

        #endregion

        private void IBTRegister_Click(object sender, EventArgs e)
        {
            using (DoctorOfficeEntities db = new DoctorOfficeEntities())
            {
                Patients p = new Patients {
                    Name = TXTName.Text,
                    Surname = TXTSurname.Text,
                    Dni = Convert.ToInt32(TXTDni.Text.Replace(".", "")),
                    Email = TXTEmail.Text,
                    Phone = Convert.ToInt32(TXTPhone.Text.Replace("-", ""))
                };

                MessageBox.Show(p.ToString());

                db.Patients.Add(p);
                db.SaveChanges();

                DGVPatients.DataSource = db.Patients.ToList();
                
            }
        }

        private void FRMReception_Load(object sender, EventArgs e)
        {
            using (DoctorOfficeEntities db = new DoctorOfficeEntities())
            {
                DGVPatients.DataSource = db.Patients.ToList();
            }
        }

        private void IBTModify_Click(object sender, EventArgs e)
        {
            if (DGVPatients.Selected())
            {
                Patients p = DGVPatients.SelectedRows[0].DataBoundItem as Patients;

                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    p = db.Patients.Find(p.PatientKey);
                    p.Name = TXTName.Text;
                    p.Surname = TXTSurname.Text;
                    p.Dni = Convert.ToInt32(TXTDni.Text.Replace(".", ""));
                    p.Phone = Convert.ToInt32(TXTPhone.Text.Replace("-", ""));
                    p.Email = TXTEmail.Text;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    DGVPatients.DataSource = db.Patients.ToList();
                }
            }
        }

        private void IBTDown_Click(object sender, EventArgs e)
        {
            if (DGVPatients.Selected())
            {
                DataGridViewRow row = DGVPatients.SelectedRows[0];
                Patients p = (Patients)row.DataBoundItem;

                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    p = db.Patients.Find(p.PatientKey);
                    db.Patients.Remove(p);
                    db.SaveChanges();

                    DGVPatients.DataSource = db.Patients.ToList();
                }
            }
        }
    }
}
