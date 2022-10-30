
namespace DoctorOffice
{
    partial class FRMReception
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
            this.SuspendLayout();
            // 
            // PNLMenu
            // 
            this.PNLMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNLMenu.Location = new System.Drawing.Point(0, 0);
            this.PNLMenu.Name = "PNLMenu";
            this.PNLMenu.Size = new System.Drawing.Size(200, 450);
            this.PNLMenu.TabIndex = 0;
            // 
            // FRMReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PNLMenu);
            this.Name = "FRMReception";
            this.Text = "Recepción";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLMenu;
    }
}

