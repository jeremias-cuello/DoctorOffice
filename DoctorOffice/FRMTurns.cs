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
                Patients p = DGVPatients.SelectedRows[0].DataBoundItem as Patients;
                Medics m = CMBMedics.SelectedItem as Medics;
                Turns t = new Turns {
                    Number = new Random().Next(10000, 99999),
                    DateTime = DTPDate.Value,
                    MedicKey = m.MedicKey,
                    PatientKey = p.PatientKey
                };

                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    try
                    {
                        db.Turns.Add(t);
                        db.SaveChanges();
                        DGVTurns.DataSource = db.Turns.ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrio un Error al agregar un turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DGVTurns_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVTurns.SelectedRows.Count > 0)
            {
                TXBNumber.Text = DGVTurns.SelectedRows[0].Cells[1].Value.ToString();
                DTPDate.Text = DGVTurns.SelectedRows[0].Cells[2].Value.ToString();
                int medicKey = (int)DGVTurns.SelectedRows[0].Cells[4].Value;
                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    CMBMedics.SelectedItem = db.Medics.Find(medicKey);
                }
            }
        }

        private void DGVTurns_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            TXBNumber.Text = "Número";
            CMBMedics.SelectedIndex = 0;
        }

        private void IBTDown_Click(object sender, EventArgs e)
        {
            
        }

        private void IBTModify_Click(object sender, EventArgs e)
        {
            if (DGVTurns.Selected())
            {
                Turns t = DGVTurns.SelectedRows[0].DataBoundItem as Turns;
                
                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    try
                    {
                        t = db.Turns.Find(t.TurnKey);
                        t.DateTime = DTPDate.Value;
                        t.MedicKey = (CMBMedics.SelectedItem as Medics).MedicKey;

                        db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        DGVTurns.DataSource = db.Turns.ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrio un error al modificar un turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
