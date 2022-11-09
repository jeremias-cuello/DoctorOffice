
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
            this.TXTSurname = new System.Windows.Forms.TextBox();
            this.TXBName = new System.Windows.Forms.TextBox();
            this.IBTRegister = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GPBPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBPatients
            // 
            this.GPBPatients.Controls.Add(this.textBox1);
            this.GPBPatients.Controls.Add(this.TXTSurname);
            this.GPBPatients.Controls.Add(this.TXBName);
            this.GPBPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPBPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBPatients.Location = new System.Drawing.Point(18, 13);
            this.GPBPatients.Name = "GPBPatients";
            this.GPBPatients.Size = new System.Drawing.Size(582, 75);
            this.GPBPatients.TabIndex = 9;
            this.GPBPatients.TabStop = false;
            this.GPBPatients.Text = "Médico";
            // 
            // TXTSurname
            // 
            this.TXTSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TXTSurname.ForeColor = System.Drawing.Color.Gray;
            this.TXTSurname.Location = new System.Drawing.Point(203, 34);
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
            this.IBTRegister.Location = new System.Drawing.Point(619, 33);
            this.IBTRegister.Name = "IBTRegister";
            this.IBTRegister.Size = new System.Drawing.Size(151, 34);
            this.IBTRegister.TabIndex = 6;
            this.IBTRegister.Text = "Registrar";
            this.IBTRegister.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(388, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Número de Matricula";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 143);
            this.dataGridView1.TabIndex = 10;
            // 
            // FRMMedics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(790, 279);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GPBPatients);
            this.Controls.Add(this.IBTRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMMedics";
            this.Text = "Médicos";
            this.GPBPatients.ResumeLayout(false);
            this.GPBPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBPatients;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TXTSurname;
        private System.Windows.Forms.TextBox TXBName;
        private FontAwesome.Sharp.IconButton IBTRegister;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}