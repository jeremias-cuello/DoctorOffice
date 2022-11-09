
namespace DoctorOffice
{
    partial class FRMTurns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLPatients = new System.Windows.Forms.Label();
            this.GPBTurn = new System.Windows.Forms.GroupBox();
            this.CMBMedics = new System.Windows.Forms.ComboBox();
            this.TXTTime = new System.Windows.Forms.TextBox();
            this.TXTPhone = new System.Windows.Forms.TextBox();
            this.TXTDni = new System.Windows.Forms.TextBox();
            this.TXBNNumber = new System.Windows.Forms.TextBox();
            this.IBTRegister = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LSTPatients = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GPBTurn.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLPatients
            // 
            this.LBLPatients.AutoSize = true;
            this.LBLPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPatients.Location = new System.Drawing.Point(8, 10);
            this.LBLPatients.Name = "LBLPatients";
            this.LBLPatients.Size = new System.Drawing.Size(79, 20);
            this.LBLPatients.TabIndex = 23;
            this.LBLPatients.Text = "Pacientes";
            // 
            // GPBTurn
            // 
            this.GPBTurn.Controls.Add(this.CMBMedics);
            this.GPBTurn.Controls.Add(this.TXTTime);
            this.GPBTurn.Controls.Add(this.TXTPhone);
            this.GPBTurn.Controls.Add(this.TXTDni);
            this.GPBTurn.Controls.Add(this.TXBNNumber);
            this.GPBTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPBTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBTurn.Location = new System.Drawing.Point(479, 26);
            this.GPBTurn.Name = "GPBTurn";
            this.GPBTurn.Size = new System.Drawing.Size(221, 197);
            this.GPBTurn.TabIndex = 24;
            this.GPBTurn.TabStop = false;
            this.GPBTurn.Text = "Turno";
            // 
            // CMBMedics
            // 
            this.CMBMedics.FormattingEnabled = true;
            this.CMBMedics.Items.AddRange(new object[] {
            "Seleccionar Médico"});
            this.CMBMedics.Location = new System.Drawing.Point(18, 150);
            this.CMBMedics.Name = "CMBMedics";
            this.CMBMedics.Size = new System.Drawing.Size(179, 33);
            this.CMBMedics.TabIndex = 8;
            // 
            // TXTTime
            // 
            this.TXTTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTTime.ForeColor = System.Drawing.Color.Gray;
            this.TXTTime.Location = new System.Drawing.Point(18, 121);
            this.TXTTime.Name = "TXTTime";
            this.TXTTime.Size = new System.Drawing.Size(179, 23);
            this.TXTTime.TabIndex = 7;
            this.TXTTime.Text = "Horario";
            this.TXTTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTPhone
            // 
            this.TXTPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTPhone.ForeColor = System.Drawing.Color.Gray;
            this.TXTPhone.Location = new System.Drawing.Point(18, 92);
            this.TXTPhone.Name = "TXTPhone";
            this.TXTPhone.Size = new System.Drawing.Size(179, 23);
            this.TXTPhone.TabIndex = 4;
            this.TXTPhone.Text = "Celular";
            this.TXTPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTDni
            // 
            this.TXTDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTDni.ForeColor = System.Drawing.Color.Gray;
            this.TXTDni.Location = new System.Drawing.Point(18, 63);
            this.TXTDni.Name = "TXTDni";
            this.TXTDni.Size = new System.Drawing.Size(179, 23);
            this.TXTDni.TabIndex = 3;
            this.TXTDni.Text = "Fecha";
            this.TXTDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXBNNumber
            // 
            this.TXBNNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXBNNumber.ForeColor = System.Drawing.Color.Gray;
            this.TXBNNumber.Location = new System.Drawing.Point(18, 34);
            this.TXBNNumber.Name = "TXBNNumber";
            this.TXBNNumber.Size = new System.Drawing.Size(179, 23);
            this.TXBNNumber.TabIndex = 1;
            this.TXBNNumber.Text = "Número";
            this.TXBNNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IBTRegister
            // 
            this.IBTRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.IBTRegister.FlatAppearance.BorderSize = 0;
            this.IBTRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.IBTRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBTRegister.IconColor = System.Drawing.Color.Black;
            this.IBTRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTRegister.Location = new System.Drawing.Point(497, 233);
            this.IBTRegister.Name = "IBTRegister";
            this.IBTRegister.Size = new System.Drawing.Size(179, 35);
            this.IBTRegister.TabIndex = 6;
            this.IBTRegister.Text = "Registrar";
            this.IBTRegister.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(497, 274);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(179, 35);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "Modificar";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // LSTPatients
            // 
            this.LSTPatients.FormattingEnabled = true;
            this.LSTPatients.Location = new System.Drawing.Point(12, 33);
            this.LSTPatients.Name = "LSTPatients";
            this.LSTPatients.Size = new System.Drawing.Size(447, 121);
            this.LSTPatients.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 30);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = "Buscar";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRMTurns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(717, 525);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LSTPatients);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.GPBTurn);
            this.Controls.Add(this.LBLPatients);
            this.Controls.Add(this.IBTRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMTurns";
            this.Text = "Turnos";
            this.GPBTurn.ResumeLayout(false);
            this.GPBTurn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPatients;
        private System.Windows.Forms.GroupBox GPBTurn;
        private System.Windows.Forms.ComboBox CMBMedics;
        private System.Windows.Forms.TextBox TXTTime;
        private System.Windows.Forms.TextBox TXTPhone;
        private System.Windows.Forms.TextBox TXTDni;
        private System.Windows.Forms.TextBox TXBNNumber;
        private FontAwesome.Sharp.IconButton IBTRegister;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ListBox LSTPatients;
        private System.Windows.Forms.TextBox textBox2;
    }
}