
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
            this.IBTReserve = new FontAwesome.Sharp.IconButton();
            this.LBLTurns = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GPBPatients = new System.Windows.Forms.GroupBox();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTPhone = new System.Windows.Forms.TextBox();
            this.TXTDni = new System.Windows.Forms.TextBox();
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.TXBName = new System.Windows.Forms.TextBox();
            this.IBTRegister = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GPBPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // IBTReserve
            // 
            this.IBTReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.IBTReserve.FlatAppearance.BorderSize = 0;
            this.IBTReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.IBTReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTReserve.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBTReserve.IconColor = System.Drawing.Color.Black;
            this.IBTReserve.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTReserve.Location = new System.Drawing.Point(268, 303);
            this.IBTReserve.Name = "IBTReserve";
            this.IBTReserve.Size = new System.Drawing.Size(151, 34);
            this.IBTReserve.TabIndex = 15;
            this.IBTReserve.Text = "Reservar";
            this.IBTReserve.UseVisualStyleBackColor = false;
            // 
            // LBLTurns
            // 
            this.LBLTurns.AutoSize = true;
            this.LBLTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTurns.Location = new System.Drawing.Point(18, 158);
            this.LBLTurns.Name = "LBLTurns";
            this.LBLTurns.Size = new System.Drawing.Size(58, 20);
            this.LBLTurns.TabIndex = 21;
            this.LBLTurns.Text = "Turnos";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 305);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 30);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Buscar";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pacientes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 181);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(397, 108);
            this.dataGridView2.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 106);
            this.dataGridView1.TabIndex = 17;
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
            this.GPBPatients.Location = new System.Drawing.Point(433, 32);
            this.GPBPatients.Name = "GPBPatients";
            this.GPBPatients.Size = new System.Drawing.Size(218, 257);
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
            this.TXTEmail.Location = new System.Drawing.Point(18, 104);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(179, 23);
            this.TXTEmail.TabIndex = 5;
            this.TXTEmail.Text = "email";
            this.TXTEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTPhone
            // 
            this.TXTPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTPhone.ForeColor = System.Drawing.Color.Gray;
            this.TXTPhone.Location = new System.Drawing.Point(18, 174);
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
            this.TXTDni.Location = new System.Drawing.Point(18, 69);
            this.TXTDni.Name = "TXTDni";
            this.TXTDni.Size = new System.Drawing.Size(179, 23);
            this.TXTDni.TabIndex = 3;
            this.TXTDni.Text = "DNI";
            this.TXTDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTSurname
            // 
            this.TXTSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTSurname.ForeColor = System.Drawing.Color.Gray;
            this.TXTSurname.Location = new System.Drawing.Point(18, 139);
            this.TXTSurname.Name = "TXTSurname";
            this.TXTSurname.Size = new System.Drawing.Size(179, 23);
            this.TXTSurname.TabIndex = 2;
            this.TXTSurname.Text = "Apellido";
            this.TXTSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.IBTRegister.Location = new System.Drawing.Point(18, 207);
            this.IBTRegister.Name = "IBTRegister";
            this.IBTRegister.Size = new System.Drawing.Size(179, 35);
            this.IBTRegister.TabIndex = 6;
            this.IBTRegister.Text = "Registrar";
            this.IBTRegister.UseVisualStyleBackColor = false;
            // 
            // FRMReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(669, 349);
            this.ControlBox = false;
            this.Controls.Add(this.IBTReserve);
            this.Controls.Add(this.LBLTurns);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GPBPatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMReception";
            this.Text = "Recepción";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GPBPatients.ResumeLayout(false);
            this.GPBPatients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton IBTReserve;
        private System.Windows.Forms.Label LBLTurns;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GPBPatients;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.TextBox TXTPhone;
        private System.Windows.Forms.TextBox TXTDni;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.TextBox TXBName;
        private FontAwesome.Sharp.IconButton IBTRegister;
    }
}