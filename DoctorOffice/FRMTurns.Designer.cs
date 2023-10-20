
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
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.CMBMedics = new System.Windows.Forms.ComboBox();
            this.TXBNumber = new System.Windows.Forms.TextBox();
            this.DGVTurns = new System.Windows.Forms.DataGridView();
            this.IBTDown = new FontAwesome.Sharp.IconButton();
            this.IBTModify = new FontAwesome.Sharp.IconButton();
            this.DGVPatients = new System.Windows.Forms.DataGridView();
            this.IBTReserve = new FontAwesome.Sharp.IconButton();
            this.LBLTurns = new System.Windows.Forms.Label();
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
            this.GPBTurn.Controls.Add(this.DTPDate);
            this.GPBTurn.Controls.Add(this.CMBMedics);
            this.GPBTurn.Controls.Add(this.TXBNumber);
            this.GPBTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPBTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBTurn.Location = new System.Drawing.Point(12, 12);
            this.GPBTurn.Name = "GPBTurn";
            this.GPBTurn.Size = new System.Drawing.Size(364, 125);
            this.GPBTurn.TabIndex = 24;
            this.GPBTurn.TabStop = false;
            this.GPBTurn.Text = "Turno";
            // 
            // DTPDate
            // 
            this.DTPDate.CalendarFont = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDate.Location = new System.Drawing.Point(193, 34);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(153, 22);
            this.DTPDate.TabIndex = 32;
            this.DTPDate.Value = new System.DateTime(2023, 10, 18, 19, 43, 58, 0);
            // 
            // CMBMedics
            // 
            this.CMBMedics.DisplayMember = "FullName";
            this.CMBMedics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CMBMedics.ForeColor = System.Drawing.Color.Gray;
            this.CMBMedics.FormattingEnabled = true;
            this.CMBMedics.Items.AddRange(new object[] {
            "Seleccion un médico"});
            this.CMBMedics.Location = new System.Drawing.Point(14, 72);
            this.CMBMedics.Name = "CMBMedics";
            this.CMBMedics.Size = new System.Drawing.Size(167, 23);
            this.CMBMedics.TabIndex = 8;
            // 
            // TXBNumber
            // 
            this.TXBNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TXBNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXBNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXBNumber.ForeColor = System.Drawing.Color.Black;
            this.TXBNumber.Location = new System.Drawing.Point(14, 34);
            this.TXBNumber.Name = "TXBNumber";
            this.TXBNumber.ReadOnly = true;
            this.TXBNumber.Size = new System.Drawing.Size(167, 23);
            this.TXBNumber.TabIndex = 1;
            this.TXBNumber.Text = "Número";
            this.TXBNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGVTurns
            // 
            this.DGVTurns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.DGVTurns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTurns.Location = new System.Drawing.Point(12, 321);
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
            this.IBTDown.Click += new System.EventHandler(this.IBTDown_Click);
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
            this.IBTModify.Click += new System.EventHandler(this.IBTModify_Click);
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
            this.IBTReserve.Location = new System.Drawing.Point(391, 22);
            this.IBTReserve.Name = "IBTReserve";
            this.IBTReserve.Size = new System.Drawing.Size(151, 34);
            this.IBTReserve.TabIndex = 31;
            this.IBTReserve.Text = "Reservar";
            this.IBTReserve.UseVisualStyleBackColor = false;
            this.IBTReserve.Click += new System.EventHandler(this.IBTReserve_Click);
            // 
            // LBLTurns
            // 
            this.LBLTurns.AutoSize = true;
            this.LBLTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTurns.Location = new System.Drawing.Point(12, 298);
            this.LBLTurns.Name = "LBLTurns";
            this.LBLTurns.Size = new System.Drawing.Size(58, 20);
            this.LBLTurns.TabIndex = 33;
            this.LBLTurns.Text = "Turnos";
            // 
            // FRMTurns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(558, 484);
            this.ControlBox = false;
            this.Controls.Add(this.LBLTurns);
            this.Controls.Add(this.IBTReserve);
            this.Controls.Add(this.DGVPatients);
            this.Controls.Add(this.DGVTurns);
            this.Controls.Add(this.IBTDown);
            this.Controls.Add(this.IBTModify);
            this.Controls.Add(this.GPBTurn);
            this.Controls.Add(this.LBLPatients);
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
        private System.Windows.Forms.TextBox TXBNumber;
        private FontAwesome.Sharp.IconButton IBTModify;
        private FontAwesome.Sharp.IconButton IBTDown;
        private System.Windows.Forms.DataGridView DGVTurns;
        private System.Windows.Forms.DataGridView DGVPatients;
        private FontAwesome.Sharp.IconButton IBTReserve;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Label LBLTurns;
    }
}
