
namespace DoctorOffice
{
    partial class FRMReception
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
            this.DGVPatients = new System.Windows.Forms.DataGridView();
            this.GPBPatients = new System.Windows.Forms.GroupBox();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTPhone = new System.Windows.Forms.TextBox();
            this.TXTDni = new System.Windows.Forms.TextBox();
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.IBTRegister = new FontAwesome.Sharp.IconButton();
            this.IBTModify = new FontAwesome.Sharp.IconButton();
            this.IBTDown = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).BeginInit();
            this.GPBPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVPatients
            // 
            this.DGVPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.DGVPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatients.Location = new System.Drawing.Point(13, 178);
            this.DGVPatients.MultiSelect = false;
            this.DGVPatients.Name = "DGVPatients";
            this.DGVPatients.ReadOnly = true;
            this.DGVPatients.Size = new System.Drawing.Size(528, 325);
            this.DGVPatients.TabIndex = 17;
            // 
            // GPBPatients
            // 
            this.GPBPatients.Controls.Add(this.TXTEmail);
            this.GPBPatients.Controls.Add(this.TXTPhone);
            this.GPBPatients.Controls.Add(this.TXTDni);
            this.GPBPatients.Controls.Add(this.TXTSurname);
            this.GPBPatients.Controls.Add(this.TXTName);
            this.GPBPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPBPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBPatients.Location = new System.Drawing.Point(12, 12);
            this.GPBPatients.Name = "GPBPatients";
            this.GPBPatients.Size = new System.Drawing.Size(361, 157);
            this.GPBPatients.TabIndex = 16;
            this.GPBPatients.TabStop = false;
            this.GPBPatients.Text = "Paciente";
            // 
            // TXTEmail
            // 
            this.TXTEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TXTEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTEmail.ForeColor = System.Drawing.Color.Gray;
            this.TXTEmail.Location = new System.Drawing.Point(189, 76);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(149, 23);
            this.TXTEmail.TabIndex = 4;
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
            this.TXTPhone.Location = new System.Drawing.Point(23, 115);
            this.TXTPhone.Name = "TXTPhone";
            this.TXTPhone.Size = new System.Drawing.Size(149, 23);
            this.TXTPhone.TabIndex = 5;
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
            this.TXTDni.Location = new System.Drawing.Point(23, 76);
            this.TXTDni.Name = "TXTDni";
            this.TXTDni.Size = new System.Drawing.Size(149, 23);
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
            this.TXTSurname.Location = new System.Drawing.Point(189, 34);
            this.TXTSurname.Name = "TXTSurname";
            this.TXTSurname.Size = new System.Drawing.Size(149, 23);
            this.TXTSurname.TabIndex = 2;
            this.TXTSurname.Text = "Apellido";
            this.TXTSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTSurname.Enter += new System.EventHandler(this.TXTSurname_Enter);
            this.TXTSurname.Leave += new System.EventHandler(this.TXTSurname_Leave);
            // 
            // TXTName
            // 
            this.TXTName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTName.ForeColor = System.Drawing.Color.Gray;
            this.TXTName.Location = new System.Drawing.Point(23, 34);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(149, 23);
            this.TXTName.TabIndex = 1;
            this.TXTName.Text = "Nombre";
            this.TXTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTName.Enter += new System.EventHandler(this.TXTName_Enter);
            this.TXTName.Leave += new System.EventHandler(this.TXTName_Leave);
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
            this.IBTRegister.Location = new System.Drawing.Point(390, 34);
            this.IBTRegister.Name = "IBTRegister";
            this.IBTRegister.Size = new System.Drawing.Size(151, 35);
            this.IBTRegister.TabIndex = 6;
            this.IBTRegister.Text = "Registrar";
            this.IBTRegister.UseVisualStyleBackColor = false;
            this.IBTRegister.Click += new System.EventHandler(this.IBTRegister_Click);
            // 
            // IBTModify
            // 
            this.IBTModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.IBTModify.FlatAppearance.BorderSize = 0;
            this.IBTModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.IBTModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTModify.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBTModify.IconColor = System.Drawing.Color.Black;
            this.IBTModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTModify.Location = new System.Drawing.Point(390, 75);
            this.IBTModify.Name = "IBTModify";
            this.IBTModify.Size = new System.Drawing.Size(151, 35);
            this.IBTModify.TabIndex = 22;
            this.IBTModify.Text = "Modificar";
            this.IBTModify.UseVisualStyleBackColor = false;
            this.IBTModify.Click += new System.EventHandler(this.IBTModify_Click);
            // 
            // IBTDown
            // 
            this.IBTDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.IBTDown.FlatAppearance.BorderSize = 0;
            this.IBTDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.IBTDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTDown.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBTDown.IconColor = System.Drawing.Color.Black;
            this.IBTDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTDown.Location = new System.Drawing.Point(390, 116);
            this.IBTDown.Name = "IBTDown";
            this.IBTDown.Size = new System.Drawing.Size(151, 35);
            this.IBTDown.TabIndex = 23;
            this.IBTDown.Text = "Dar de baja";
            this.IBTDown.UseVisualStyleBackColor = false;
            this.IBTDown.Click += new System.EventHandler(this.IBTDown_Click);
            // 
            // FRMReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(562, 515);
            this.ControlBox = false;
            this.Controls.Add(this.IBTDown);
            this.Controls.Add(this.IBTModify);
            this.Controls.Add(this.DGVPatients);
            this.Controls.Add(this.GPBPatients);
            this.Controls.Add(this.IBTRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMReception";
            this.Text = "Recepción";
            this.Load += new System.EventHandler(this.FRMReception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).EndInit();
            this.GPBPatients.ResumeLayout(false);
            this.GPBPatients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVPatients;
        private System.Windows.Forms.GroupBox GPBPatients;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.TextBox TXTPhone;
        private System.Windows.Forms.TextBox TXTDni;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.TextBox TXTName;
        private FontAwesome.Sharp.IconButton IBTRegister;
        private FontAwesome.Sharp.IconButton IBTModify;
        private FontAwesome.Sharp.IconButton IBTDown;
    }
}
