using System;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Reflection;

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
            if (DGVTurns.Selected())
            {
                Turns t = DGVTurns.SelectedRows[0].DataBoundItem as Turns;

                using (DoctorOfficeEntities db = new DoctorOfficeEntities())
                {
                    t = db.Turns.Find(t.TurnKey);
                    db.Turns.Remove(t);
                    db.SaveChanges();

                    DGVTurns.DataSource = db.Turns.ToList();
                }
            }
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

        private void Print(object sender, PrintPageEventArgs e)
        {
            Font fontBody = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            Font fontTitle = new Font("Calibri", 24, FontStyle.Regular, GraphicsUnit.Point);
            Pen linePen = new Pen(Brushes.Black, 2);
            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\Resources", "home.png");
            const int margenHor = 50;

            // encabezado
            const int x = 400;
            const int y = 140;
            Image img = Image.FromFile(imagePath);
            e.Graphics.DrawLine(linePen, margenHor, 60, e.MarginBounds.Right - 10, 60);
            e.Graphics.DrawImage(img, new Rectangle(margenHor, 65, 230, 230));
            e.Graphics.DrawString("DoctorOffice", fontTitle, Brushes.Black, new RectangleF(x, y, e.MarginBounds.Width - margenHor, 40));
            e.Graphics.DrawLine(linePen, 230+80, 185, e.MarginBounds.Right - margenHor, 185); // medio del titulo
            e.Graphics.DrawString("Turno Médico", fontTitle, Brushes.Black, new RectangleF(x-7, y+50, e.MarginBounds.Width - margenHor, 40));
            // lineas separadores
            int heigth = 310;
            e.Graphics.DrawLine(linePen, margenHor, heigth, e.MarginBounds.Right - 10, heigth); // inferior encabezado
            
            linePen = new Pen(Brushes.Black, 1);
            heigth += 90; // 3 reglones
            e.Graphics.DrawLine(linePen, margenHor, heigth, e.MarginBounds.Right - 10, heigth);
            heigth += 90;
            e.Graphics.DrawLine(linePen, margenHor, heigth, e.MarginBounds.Right - 10, heigth);
            heigth += 90;
            e.Graphics.DrawLine(linePen, margenHor, heigth, e.MarginBounds.Right - 10, heigth);

            string content = turnToPrint.GetPrintContent();
            e.Graphics.DrawString(content, fontBody, Brushes.Black, new RectangleF(margenHor, 320, e.MarginBounds.Width - margenHor, 520));
        }

        private void IBTPrint_Click(object sender, EventArgs e)
        {
            if (DGVTurns.Selected())
            {
                turnToPrint = DGVTurns.SelectedRows[0].DataBoundItem as Turns;
                PrinterSettings ps = new PrinterSettings {
                    PrintFileName = "turno-medico-DoctorOffice"
                };
                if (!ps.IsDefaultPrinter)
                {
                    MessageBox.Show("No esta establecido una impresora predeterminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!ps.IsValid)
                {
                    MessageBox.Show("La impresora " + ps.PrinterName + "establecida no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    PDTurn = new PrintDocument {
                        PrinterSettings = ps
                    };
                    PDTurn.PrintPage += Print;
                    PDTurn.Print();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al imprimir el documento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Turns turnToPrint = new Turns();
    }
}
