
namespace DoctorOffice
{
    partial class FRMMedics
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
            this.TXTNumberTuition = new System.Windows.Forms.TextBox();
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.IBTRegister = new FontAwesome.Sharp.IconButton();
            this.DGVMedics = new System.Windows.Forms.DataGridView();
            this.IBTModify = new FontAwesome.Sharp.IconButton();
            this.IBTDown = new FontAwesome.Sharp.IconButton();
            this.GPBPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedics)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBPatients
            // 
            this.GPBPatients.Controls.Add(this.TXTNumberTuition);
            this.GPBPatients.Controls.Add(this.TXTSurname);
            this.GPBPatients.Controls.Add(this.TXTName);
            this.GPBPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPBPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBPatients.Location = new System.Drawing.Point(12, 12);
            this.GPBPatients.Name = "GPBPatients";
            this.GPBPatients.Size = new System.Drawing.Size(364, 125);
            this.GPBPatients.TabIndex = 9;
            this.GPBPatients.TabStop = false;
            this.GPBPatients.Text = "Médico";
            // 
            // TXTNumberTuition
            // 
            this.TXTNumberTuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTNumberTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTNumberTuition.ForeColor = System.Drawing.Color.Gray;
            this.TXTNumberTuition.Location = new System.Drawing.Point(18, 78);
            this.TXTNumberTuition.Name = "TXTNumberTuition";
            this.TXTNumberTuition.Size = new System.Drawing.Size(158, 23);
            this.TXTNumberTuition.TabIndex = 7;
            this.TXTNumberTuition.Text = "Número de Matricula";
            this.TXTNumberTuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNumberTuition.Enter += new System.EventHandler(this.TXTNumberTuition_Enter);
            this.TXTNumberTuition.Leave += new System.EventHandler(this.TXTNumberTuition_Leave);
            // 
            // TXTSurname
            // 
            this.TXTSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTSurname.ForeColor = System.Drawing.Color.Gray;
            this.TXTSurname.Location = new System.Drawing.Point(182, 37);
            this.TXTSurname.Name = "TXTSurname";
            this.TXTSurname.Size = new System.Drawing.Size(158, 23);
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
            this.TXTName.Location = new System.Drawing.Point(18, 37);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(158, 23);
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
            this.IBTRegister.Location = new System.Drawing.Point(389, 23);
            this.IBTRegister.Name = "IBTRegister";
            this.IBTRegister.Size = new System.Drawing.Size(151, 34);
            this.IBTRegister.TabIndex = 6;
            this.IBTRegister.Text = "Registrar";
            this.IBTRegister.UseVisualStyleBackColor = false;
            this.IBTRegister.Click += new System.EventHandler(this.IBTRegister_Click);
            // 
            // DGVMedics
            // 
            this.DGVMedics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.DGVMedics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedics.Location = new System.Drawing.Point(12, 145);
            this.DGVMedics.MultiSelect = false;
            this.DGVMedics.Name = "DGVMedics";
            this.DGVMedics.ReadOnly = true;
            this.DGVMedics.Size = new System.Drawing.Size(528, 181);
            this.DGVMedics.TabIndex = 10;
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
            this.IBTModify.Location = new System.Drawing.Point(389, 63);
            this.IBTModify.Name = "IBTModify";
            this.IBTModify.Size = new System.Drawing.Size(151, 34);
            this.IBTModify.TabIndex = 11;
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
            this.IBTDown.Location = new System.Drawing.Point(389, 103);
            this.IBTDown.Name = "IBTDown";
            this.IBTDown.Size = new System.Drawing.Size(151, 34);
            this.IBTDown.TabIndex = 12;
            this.IBTDown.Text = "Dar de Baja";
            this.IBTDown.UseVisualStyleBackColor = false;
            this.IBTDown.Click += new System.EventHandler(this.IBTDown_Click);
            // 
            // FRMMedics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(568, 355);
            this.ControlBox = false;
            this.Controls.Add(this.IBTDown);
            this.Controls.Add(this.IBTModify);
            this.Controls.Add(this.DGVMedics);
            this.Controls.Add(this.GPBPatients);
            this.Controls.Add(this.IBTRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMMedics";
            this.Text = "Médicos";
            this.Load += new System.EventHandler(this.FRMMedics_Load);
            this.GPBPatients.ResumeLayout(false);
            this.GPBPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBPatients;
        private System.Windows.Forms.TextBox TXTNumberTuition;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.TextBox TXTName;
        private FontAwesome.Sharp.IconButton IBTRegister;
        private System.Windows.Forms.DataGridView DGVMedics;
        private FontAwesome.Sharp.IconButton IBTModify;
        private FontAwesome.Sharp.IconButton IBTDown;
    }
}