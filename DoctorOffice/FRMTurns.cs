using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace DoctorOffice
{
    public partial class FRMTurns : Form
    {
        public FRMTurns()
        {
            InitializeComponent();
        }

        private void FRMTurns_Load(object sender, EventArgs e)
        {
            using (DoctorOfficeEntities db = new DoctorOfficeEntities())
            {
                DGVPatients.DataSource = db.Patients.ToList();
                DGVTurns.DataSource = db.Turns.ToList();
                CMBMedics.DataSource = db.Medics.ToList();
            }
        }

        private void IBTReserve_Click(object sender, EventArgs e)
        {
            if (DGVPatients.Selected())
            {
                DataGridViewRow row;
                row = DGVPatients.SelectedRows[0];
                Patients p = (Patients)row.DataBoundItem;
                Turns t = new Turns();
                Medics m = new Medics();
                m.MedicKey = ((Medics)CMBMedics.SelectedItem).MedicKey;

                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    MessageBox.Show(TimeSpan.FromHours(DateTime.Now.Hour).ToString());
                    MessageBox.Show(DateTime.Now.Hour.ToString());

                    Random rnd = new Random();
                    t.Number = rnd.Next(10000, 99999);
                    t.PatientKey = p.PatientKey;
                    t.MedicKey = m.MedicKey;
                    TimeSpan horary = TimeSpan.FromHours(Convert.ToDouble(TXTTime.Text));
                    t.Horary = horary;
                    t.Date = DateTime.Now;
                    try
                    {
                        db.Turns.Add(t);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Hora ya ocupada con " + db.Medics.Find(m.MedicKey).Name);
                    }

                    DGVTurns.DataSource = db.Turns.ToList();
                }
            }
        }

        #region TextBoxesHandlersOnEnter

        private void TXBNNumber_Enter(object sender, EventArgs e)
        {

        }

        private void TXTTime_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        #region TextBoxesHandlersOnLeave

        private void TXBNNumber_Leave(object sender, EventArgs e)
        {

        }
        private void TXTTime_Leave(object sender, EventArgs e)
        {

        }

        #endregion

        private void DGVTurns_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVTurns.SelectedRows.Count > 0)
            {
                TXBNNumber.Text = DGVTurns.SelectedRows[0].Cells[1].Value.ToString();
                TXTDate.Text = DGVTurns.SelectedRows[0].Cells[2].Value.ToString();
                TXTTime.Text = DGVTurns.SelectedRows[0].Cells[3].Value.ToString();
                int medicKey = (int)DGVTurns.SelectedRows[0].Cells[4].Value;
                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    CMBMedics.SelectedItem = db.Medics.Find(medicKey);
                }
            }
        }

        private void DGVTurns_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            TXBNNumber.Text = "Número";
            TXTDate.Text = "Fecha";
            TXTTime.Text = "Horario";
            CMBMedics.SelectedIndex = 0;
        }
    }
}
