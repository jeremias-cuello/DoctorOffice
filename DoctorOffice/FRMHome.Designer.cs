﻿
namespace DoctorOffice
{
    partial class FRMHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PNLMenu = new System.Windows.Forms.Panel();
            this.IBTContact = new FontAwesome.Sharp.IconButton();
            this.IBTMedics = new FontAwesome.Sharp.IconButton();
            this.IBTReception = new FontAwesome.Sharp.IconButton();
            this.IBTTurns = new FontAwesome.Sharp.IconButton();
            this.PNLIcon = new System.Windows.Forms.Panel();
            this.IPBIcon = new FontAwesome.Sharp.IconPictureBox();
            this.PNLNav = new System.Windows.Forms.Panel();
            this.IPBClose = new FontAwesome.Sharp.IconPictureBox();
            this.LBLCurrentChild = new System.Windows.Forms.Label();
            this.IPBCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.PNLCurrentForm = new System.Windows.Forms.Panel();
            this.PNLShadow = new System.Windows.Forms.Panel();
            this.PNLMenu.SuspendLayout();
            this.PNLIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPBIcon)).BeginInit();
            this.PNLNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBCurrentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLMenu
            // 
            this.PNLMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.PNLMenu.Controls.Add(this.IBTMedics);
            this.PNLMenu.Controls.Add(this.IBTTurns);
            this.PNLMenu.Controls.Add(this.IBTContact);
            this.PNLMenu.Controls.Add(this.IBTReception);
            this.PNLMenu.Controls.Add(this.PNLIcon);
            this.PNLMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNLMenu.Location = new System.Drawing.Point(0, 0);
            this.PNLMenu.Name = "PNLMenu";
            this.PNLMenu.Size = new System.Drawing.Size(220, 474);
            this.PNLMenu.TabIndex = 0;
            // 
            // IBTContact
            // 
            this.IBTContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(143)))), ((int)(((byte)(227)))));
            this.IBTContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IBTContact.FlatAppearance.BorderSize = 0;
            this.IBTContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTContact.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(151)))));
            this.IBTContact.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.IBTContact.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(151)))));
            this.IBTContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTContact.IconSize = 25;
            this.IBTContact.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.IBTContact.Location = new System.Drawing.Point(0, 444);
            this.IBTContact.Name = "IBTContact";
            this.IBTContact.Size = new System.Drawing.Size(220, 30);
            this.IBTContact.TabIndex = 4;
            this.IBTContact.Text = "Contacto";
            this.IBTContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBTContact.UseVisualStyleBackColor = false;
            // 
            // IBTMedics
            // 
            this.IBTMedics.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBTMedics.FlatAppearance.BorderSize = 0;
            this.IBTMedics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTMedics.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTMedics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(232)))));
            this.IBTMedics.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.IBTMedics.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(232)))));
            this.IBTMedics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTMedics.IconSize = 32;
            this.IBTMedics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTMedics.Location = new System.Drawing.Point(0, 260);
            this.IBTMedics.Name = "IBTMedics";
            this.IBTMedics.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBTMedics.Size = new System.Drawing.Size(220, 60);
            this.IBTMedics.TabIndex = 2;
            this.IBTMedics.Text = "Médicos";
            this.IBTMedics.UseVisualStyleBackColor = false;
            this.IBTMedics.Click += new System.EventHandler(this.IBTMedics_Click);
            // 
            // IBTReception
            // 
            this.IBTReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBTReception.FlatAppearance.BorderSize = 0;
            this.IBTReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTReception.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTReception.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(232)))));
            this.IBTReception.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.IBTReception.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(232)))));
            this.IBTReception.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTReception.IconSize = 32;
            this.IBTReception.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTReception.Location = new System.Drawing.Point(0, 140);
            this.IBTReception.Name = "IBTReception";
            this.IBTReception.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBTReception.Size = new System.Drawing.Size(220, 60);
            this.IBTReception.TabIndex = 0;
            this.IBTReception.Text = "Recepción";
            this.IBTReception.UseVisualStyleBackColor = false;
            this.IBTReception.Click += new System.EventHandler(this.IBTReception_Click);
            // 
            // IBTTurns
            // 
            this.IBTTurns.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBTTurns.FlatAppearance.BorderSize = 0;
            this.IBTTurns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTTurns.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTTurns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(232)))));
            this.IBTTurns.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.IBTTurns.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(232)))));
            this.IBTTurns.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTTurns.IconSize = 32;
            this.IBTTurns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTTurns.Location = new System.Drawing.Point(0, 200);
            this.IBTTurns.Name = "IBTTurns";
            this.IBTTurns.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBTTurns.Size = new System.Drawing.Size(220, 60);
            this.IBTTurns.TabIndex = 1;
            this.IBTTurns.Text = "Turnos";
            this.IBTTurns.UseVisualStyleBackColor = false;
            this.IBTTurns.Click += new System.EventHandler(this.IBTTurns_Click);
            // 
            // PNLIcon
            // 
            this.PNLIcon.Controls.Add(this.IPBIcon);
            this.PNLIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLIcon.Location = new System.Drawing.Point(0, 0);
            this.PNLIcon.Name = "PNLIcon";
            this.PNLIcon.Size = new System.Drawing.Size(220, 140);
            this.PNLIcon.TabIndex = 3;
            // 
            // IPBIcon
            // 
            this.IPBIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.IPBIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IPBIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IPBIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.IPBIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPBIcon.IconSize = 83;
            this.IPBIcon.Location = new System.Drawing.Point(21, 28);
            this.IPBIcon.Name = "IPBIcon";
            this.IPBIcon.Size = new System.Drawing.Size(168, 83);
            this.IPBIcon.TabIndex = 0;
            this.IPBIcon.TabStop = false;
            this.IPBIcon.Click += new System.EventHandler(this.IPBIcon_Click);
            // 
            // PNLNav
            // 
            this.PNLNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.PNLNav.Controls.Add(this.IPBClose);
            this.PNLNav.Controls.Add(this.LBLCurrentChild);
            this.PNLNav.Controls.Add(this.IPBCurrentChild);
            this.PNLNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLNav.Location = new System.Drawing.Point(220, 0);
            this.PNLNav.Name = "PNLNav";
            this.PNLNav.Size = new System.Drawing.Size(624, 80);
            this.PNLNav.TabIndex = 1;
            this.PNLNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PNLNav_MouseDown);
            // 
            // IPBClose
            // 
            this.IPBClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IPBClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.IPBClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IPBClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.IPBClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IPBClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPBClose.IconSize = 21;
            this.IPBClose.Location = new System.Drawing.Point(589, 0);
            this.IPBClose.Name = "IPBClose";
            this.IPBClose.Padding = new System.Windows.Forms.Padding(9, 2, 0, 0);
            this.IPBClose.Size = new System.Drawing.Size(35, 21);
            this.IPBClose.TabIndex = 3;
            this.IPBClose.TabStop = false;
            this.IPBClose.Click += new System.EventHandler(this.IPBClose_Click);
            this.IPBClose.MouseEnter += new System.EventHandler(this.IPBClose_MouseEnter);
            this.IPBClose.MouseLeave += new System.EventHandler(this.IPBClose_MouseLeave);
            // 
            // LBLCurrentChild
            // 
            this.LBLCurrentChild.AutoSize = true;
            this.LBLCurrentChild.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.LBLCurrentChild.Location = new System.Drawing.Point(58, 31);
            this.LBLCurrentChild.Name = "LBLCurrentChild";
            this.LBLCurrentChild.Size = new System.Drawing.Size(50, 19);
            this.LBLCurrentChild.TabIndex = 2;
            this.LBLCurrentChild.Text = "Home";
            // 
            // IPBCurrentChild
            // 
            this.IPBCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.IPBCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.IPBCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IPBCurrentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.IPBCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPBCurrentChild.IconSize = 30;
            this.IPBCurrentChild.Location = new System.Drawing.Point(22, 25);
            this.IPBCurrentChild.Name = "IPBCurrentChild";
            this.IPBCurrentChild.Size = new System.Drawing.Size(30, 30);
            this.IPBCurrentChild.TabIndex = 0;
            this.IPBCurrentChild.TabStop = false;
            // 
            // PNLCurrentForm
            // 
            this.PNLCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.PNLCurrentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNLCurrentForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PNLCurrentForm.Location = new System.Drawing.Point(220, 88);
            this.PNLCurrentForm.Name = "PNLCurrentForm";
            this.PNLCurrentForm.Size = new System.Drawing.Size(624, 386);
            this.PNLCurrentForm.TabIndex = 2;
            // 
            // PNLShadow
            // 
            this.PNLShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.PNLShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLShadow.Location = new System.Drawing.Point(220, 80);
            this.PNLShadow.Name = "PNLShadow";
            this.PNLShadow.Size = new System.Drawing.Size(624, 8);
            this.PNLShadow.TabIndex = 3;
            // 
            // FRMHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 474);
            this.ControlBox = false;
            this.Controls.Add(this.PNLCurrentForm);
            this.Controls.Add(this.PNLShadow);
            this.Controls.Add(this.PNLNav);
            this.Controls.Add(this.PNLMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PNLMenu.ResumeLayout(false);
            this.PNLIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IPBIcon)).EndInit();
            this.PNLNav.ResumeLayout(false);
            this.PNLNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IPBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBCurrentChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLMenu;
        private FontAwesome.Sharp.IconButton IBTReception;
        private FontAwesome.Sharp.IconButton IBTMedics;
        private FontAwesome.Sharp.IconButton IBTTurns;
        private System.Windows.Forms.Panel PNLIcon;
        private FontAwesome.Sharp.IconPictureBox IPBIcon;
        private System.Windows.Forms.Panel PNLNav;
        private FontAwesome.Sharp.IconPictureBox IPBCurrentChild;
        private System.Windows.Forms.Label LBLCurrentChild;
        private FontAwesome.Sharp.IconPictureBox IPBClose;
        private System.Windows.Forms.Panel PNLCurrentForm;
        private System.Windows.Forms.Panel PNLShadow;
        private FontAwesome.Sharp.IconButton IBTContact;
    }
}

