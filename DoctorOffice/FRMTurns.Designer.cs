
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
            this.TXTDate = new System.Windows.Forms.TextBox();
            this.TXBNNumber = new System.Windows.Forms.TextBox();
            this.DGVTurns = new System.Windows.Forms.DataGridView();
            this.IBTDown = new FontAwesome.Sharp.IconButton();
            this.IBTModify = new FontAwesome.Sharp.IconButton();
            this.IBTRegister = new FontAwesome.Sharp.IconButton();
            this.DGVPatients = new System.Windows.Forms.DataGridView();
            this.IBTReserve = new FontAwesome.Sharp.IconButton();
            this.IBTPrint = new FontAwesome.Sharp.IconButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.GPBTurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLPatients
            // 
            this.LBLPatients.AutoSize = true;
            this.LBLPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPatients.Location = new System.Drawing.Point(8, 153);
            this.LBLPatients.Name = "LBLPatients";
            this.LBLPatients.Size = new System.Drawing.Size(79, 20);
            this.LBLPatients.TabIndex = 23;
            this.LBLPatients.Text = "Pacientes";
            // 
            // GPBTurn
            // 
            this.GPBTurn.Controls.Add(this.CMBMedics);
            this.GPBTurn.Controls.Add(this.TXTTime);
            this.GPBTurn.Controls.Add(this.TXTDate);
            this.GPBTurn.Controls.Add(this.TXBNNumber);
            this.GPBTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPBTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBTurn.Location = new System.Drawing.Point(12, 12);
            this.GPBTurn.Name = "GPBTurn";
            this.GPBTurn.Size = new System.Drawing.Size(364, 125);
            this.GPBTurn.TabIndex = 24;
            this.GPBTurn.TabStop = false;
            this.GPBTurn.Text = "Turno";
            // 
            // CMBMedics
            // 
            this.CMBMedics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CMBMedics.ForeColor = System.Drawing.Color.Gray;
            this.CMBMedics.FormattingEnabled = true;
            this.CMBMedics.Items.AddRange(new object[] {
            "Seleccione un médico"});
            this.CMBMedics.Location = new System.Drawing.Point(196, 78);
            this.CMBMedics.Name = "CMBMedics";
            this.CMBMedics.Size = new System.Drawing.Size(153, 23);
            this.CMBMedics.TabIndex = 8;
            this.CMBMedics.Text = "Seleccione un médico";
            this.CMBMedics.Enter += new System.EventHandler(this.TXTTime_Enter);
            // 
            // TXTTime
            // 
            this.TXTTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTTime.ForeColor = System.Drawing.Color.Gray;
            this.TXTTime.Location = new System.Drawing.Point(14, 78);
            this.TXTTime.Name = "TXTTime";
            this.TXTTime.Size = new System.Drawing.Size(167, 23);
            this.TXTTime.TabIndex = 7;
            this.TXTTime.Text = "Horario";
            this.TXTTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTTime.Enter += new System.EventHandler(this.TXTTime_Enter);
            this.TXTTime.Leave += new System.EventHandler(this.TXTTime_Leave);
            // 
            // TXTDate
            // 
            this.TXTDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTDate.ForeColor = System.Drawing.Color.Gray;
            this.TXTDate.Location = new System.Drawing.Point(196, 37);
            this.TXTDate.Name = "TXTDate";
            this.TXTDate.Size = new System.Drawing.Size(153, 23);
            this.TXTDate.TabIndex = 3;
            this.TXTDate.Text = "Fecha";
            this.TXTDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXBNNumber
            // 
            this.TXBNNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TXBNNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXBNNumber.ForeColor = System.Drawing.Color.Black;
            this.TXBNNumber.Location = new System.Drawing.Point(14, 37);
            this.TXBNNumber.Name = "TXBNNumber";
            this.TXBNNumber.ReadOnly = true;
            this.TXBNNumber.Size = new System.Drawing.Size(167, 23);
            this.TXBNNumber.TabIndex = 1;
            this.TXBNNumber.Text = "Número";
            this.TXBNNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXBNNumber.Enter += new System.EventHandler(this.TXBNNumber_Enter);
            this.TXBNNumber.Leave += new System.EventHandler(this.TXBNNumber_Leave);
            // 
            // DGVTurns
            // 
            this.DGVTurns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.DGVTurns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTurns.Location = new System.Drawing.Point(12, 300);
            this.DGVTurns.Name = "DGVTurns";
            this.DGVTurns.ReadOnly = true;
            this.DGVTurns.Size = new System.Drawing.Size(530, 151);
            this.DGVTurns.TabIndex = 29;
            this.DGVTurns.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTurns_RowLeave);
            this.DGVTurns.SelectionChanged += new System.EventHandler(this.DGVTurns_SelectionChanged);
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
            this.IBTDown.Location = new System.Drawing.Point(391, 103);
            this.IBTDown.Name = "IBTDown";
            this.IBTDown.Size = new System.Drawing.Size(151, 34);
            this.IBTDown.TabIndex = 28;
            this.IBTDown.Text = "Dar de Baja";
            this.IBTDown.UseVisualStyleBackColor = false;
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
            this.IBTModify.Location = new System.Drawing.Point(391, 62);
            this.IBTModify.Name = "IBTModify";
            this.IBTModify.Size = new System.Drawing.Size(151, 35);
            this.IBTModify.TabIndex = 25;
            this.IBTModify.Text = "Modificar";
            this.IBTModify.UseVisualStyleBackColor = false;
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
            this.IBTRegister.Location = new System.Drawing.Point(391, 21);
            this.IBTRegister.Name = "IBTRegister";
            this.IBTRegister.Size = new System.Drawing.Size(151, 35);
            this.IBTRegister.TabIndex = 6;
            this.IBTRegister.Text = "Registrar";
            this.IBTRegister.UseVisualStyleBackColor = false;
            // 
            // DGVPatients
            // 
            this.DGVPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.DGVPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatients.Location = new System.Drawing.Point(12, 176);
            this.DGVPatients.Name = "DGVPatients";
            this.DGVPatients.ReadOnly = true;
            this.DGVPatients.Size = new System.Drawing.Size(530, 108);
            this.DGVPatients.TabIndex = 30;
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
            this.IBTReserve.Location = new System.Drawing.Point(391, 457);
            this.IBTReserve.Name = "IBTReserve";
            this.IBTReserve.Size = new System.Drawing.Size(151, 34);
            this.IBTReserve.TabIndex = 31;
            this.IBTReserve.Text = "Reservar";
            this.IBTReserve.UseVisualStyleBackColor = false;
            this.IBTReserve.Click += new System.EventHandler(this.IBTReserve_Click);
            // 
            // IBTPrint
            // 
            this.IBTPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.IBTPrint.FlatAppearance.BorderSize = 0;
            this.IBTPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.IBTPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTPrint.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBTPrint.IconColor = System.Drawing.Color.Black;
            this.IBTPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTPrint.Location = new System.Drawing.Point(225, 457);
            this.IBTPrint.Name = "IBTPrint";
            this.IBTPrint.Size = new System.Drawing.Size(151, 34);
            this.IBTPrint.TabIndex = 32;
            this.IBTPrint.Text = "Imprimir";
            this.IBTPrint.UseVisualStyleBackColor = false;
            this.IBTPrint.Click += new System.EventHandler(this.IBTPrint_Click);
            // 
            // FRMTurns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(568, 503);
            this.ControlBox = false;
            this.Controls.Add(this.IBTPrint);
            this.Controls.Add(this.IBTReserve);
            this.Controls.Add(this.DGVPatients);
            this.Controls.Add(this.DGVTurns);
            this.Controls.Add(this.IBTDown);
            this.Controls.Add(this.IBTModify);
            this.Controls.Add(this.GPBTurn);
            this.Controls.Add(this.LBLPatients);
            this.Controls.Add(this.IBTRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMTurns";
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.FRMTurns_Load);
            this.GPBTurn.ResumeLayout(false);
            this.GPBTurn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLPatients;
        private System.Windows.Forms.GroupBox GPBTurn;
        private System.Windows.Forms.ComboBox CMBMedics;
        private System.Windows.Forms.TextBox TXTTime;
        private System.Windows.Forms.TextBox TXTDate;
        private System.Windows.Forms.TextBox TXBNNumber;
        private FontAwesome.Sharp.IconButton IBTRegister;
        private FontAwesome.Sharp.IconButton IBTModify;
        private FontAwesome.Sharp.IconButton IBTDown;
        private System.Windows.Forms.DataGridView DGVTurns;
        private System.Windows.Forms.DataGridView DGVPatients;
        private FontAwesome.Sharp.IconButton IBTReserve;
        private FontAwesome.Sharp.IconButton IBTPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
