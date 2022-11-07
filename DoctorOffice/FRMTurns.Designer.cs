
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
            this.GPBPatients = new System.Windows.Forms.GroupBox();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTPhone = new System.Windows.Forms.TextBox();
            this.TXTDni = new System.Windows.Forms.TextBox();
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.TXBName = new System.Windows.Forms.TextBox();
            this.IBTRegister = new FontAwesome.Sharp.IconButton();
            this.GPBPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPBPatients
            // 
            this.GPBPatients.Controls.Add(this.TXTEmail);
            this.GPBPatients.Controls.Add(this.TXTPhone);
            this.GPBPatients.Controls.Add(this.TXTDni);
            this.GPBPatients.Controls.Add(this.TXTSurname);
            this.GPBPatients.Controls.Add(this.TXBName);
            this.GPBPatients.Controls.Add(this.IBTRegister);
            this.GPBPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPBPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBPatients.Location = new System.Drawing.Point(12, 12);
            this.GPBPatients.Name = "GPBPatients";
            this.GPBPatients.Size = new System.Drawing.Size(215, 243);
            this.GPBPatients.TabIndex = 1;
            this.GPBPatients.TabStop = false;
            this.GPBPatients.Text = "Paciente";
            // 
            // TXTEmail
            // 
            this.TXTEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TXTEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTEmail.ForeColor = System.Drawing.Color.Gray;
            this.TXTEmail.Location = new System.Drawing.Point(18, 150);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(179, 23);
            this.TXTEmail.TabIndex = 5;
            this.TXTEmail.Text = "email";
            this.TXTEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTEmail.Enter += new System.EventHandler(this.TXTEmail_Enter);
            this.TXTEmail.Leave += new System.EventHandler(this.TXTEmail_Leave);
            // 
            // TXTPhone
            // 
            this.TXTPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTPhone.ForeColor = System.Drawing.Color.Gray;
            this.TXTPhone.Location = new System.Drawing.Point(18, 121);
            this.TXTPhone.Name = "TXTPhone";
            this.TXTPhone.Size = new System.Drawing.Size(179, 23);
            this.TXTPhone.TabIndex = 4;
            this.TXTPhone.Text = "Celular";
            this.TXTPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTPhone.Enter += new System.EventHandler(this.TXTPhone_Enter);
            this.TXTPhone.Leave += new System.EventHandler(this.TXTPhone_Leave);
            // 
            // TXTDni
            // 
            this.TXTDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTDni.ForeColor = System.Drawing.Color.Gray;
            this.TXTDni.Location = new System.Drawing.Point(18, 92);
            this.TXTDni.Name = "TXTDni";
            this.TXTDni.Size = new System.Drawing.Size(179, 23);
            this.TXTDni.TabIndex = 3;
            this.TXTDni.Text = "DNI";
            this.TXTDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTDni.Enter += new System.EventHandler(this.TXTDni_Enter);
            this.TXTDni.Leave += new System.EventHandler(this.TXTDni_Leave);
            // 
            // TXTSurname
            // 
            this.TXTSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTSurname.ForeColor = System.Drawing.Color.Gray;
            this.TXTSurname.Location = new System.Drawing.Point(18, 63);
            this.TXTSurname.Name = "TXTSurname";
            this.TXTSurname.Size = new System.Drawing.Size(179, 23);
            this.TXTSurname.TabIndex = 2;
            this.TXTSurname.Text = "Apellido";
            this.TXTSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTSurname.Enter += new System.EventHandler(this.TXTSurname_Enter);
            this.TXTSurname.Leave += new System.EventHandler(this.TXTSurname_Leave);
            // 
            // TXBName
            // 
            this.TXBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXBName.ForeColor = System.Drawing.Color.Gray;
            this.TXBName.Location = new System.Drawing.Point(18, 34);
            this.TXBName.Name = "TXBName";
            this.TXBName.Size = new System.Drawing.Size(179, 23);
            this.TXBName.TabIndex = 1;
            this.TXBName.Text = "Nombre";
            this.TXBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXBName.Enter += new System.EventHandler(this.TXBName_Enter);
            this.TXBName.Leave += new System.EventHandler(this.TXBName_Leave);
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
            this.IBTRegister.Location = new System.Drawing.Point(34, 192);
            this.IBTRegister.Name = "IBTRegister";
            this.IBTRegister.Size = new System.Drawing.Size(151, 34);
            this.IBTRegister.TabIndex = 6;
            this.IBTRegister.Text = "Registrar";
            this.IBTRegister.UseVisualStyleBackColor = false;
            // 
            // FRMTurns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.GPBPatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMTurns";
            this.Text = "Turnos";
            this.GPBPatients.ResumeLayout(false);
            this.GPBPatients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBPatients;
        private FontAwesome.Sharp.IconButton IBTRegister;
        private System.Windows.Forms.TextBox TXBName;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.TextBox TXTPhone;
        private System.Windows.Forms.TextBox TXTDni;
    }
}