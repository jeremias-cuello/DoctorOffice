using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DoctorOffice
{
    public partial class FRMHome : Form
    {
        public static bool placeholder;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private struct ControlsColors
        {
            public static Color BTNActive = Color.FromArgb(0, 47, 118);
        }

        public FRMHome()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PNLMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            DisbaleButton();

            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(27, 130, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                IPBCurrentChild.IconChar = currentBtn.IconChar;
                LBLCurrentChild.Text = currentBtn.Text;
            }
        }

        private void DisbaleButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = PNLMenu.BackColor;
                currentBtn.ForeColor = Color.FromArgb(0, 64, 232);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = currentBtn.ForeColor;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void IBTReception_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, ControlsColors.BTNActive);
            OpenChildForm(new FRMReception());
        }

        private void IBTTurns_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, ControlsColors.BTNActive);
            OpenChildForm(new FRMTurns());
        }

        private void IBTMedics_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, ControlsColors.BTNActive);
            OpenChildForm(new FRMMedics());
        }

        private void IPBIcon_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisbaleButton();
            leftBorderBtn.Visible = false;
            IPBCurrentChild.IconChar = IconChar.Home;
            LBLCurrentChild.Text = "Home";

            if (currentChildForm != null) currentChildForm.Close();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            PNLCurrentForm.Controls.Add(childForm);
            PNLCurrentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LBLCurrentChild.Text = childForm.Text;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PNLNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IPBClose_MouseLeave(object sender, EventArgs e)
        {
            IPBClose.BackColor = Color.FromArgb(40, 90, 183);
        }

        private void IPBClose_MouseEnter(object sender, EventArgs e)
        {
            IPBClose.BackColor = Color.FromArgb(255, 108, 108);
        }

        private void IPBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IBTContact_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/?tf=cm&fs=1&source=mailto&to=cuellojeremiasnatanael@gmail.com&body=Hola%2c+te+contacto+desde+la+App+DoctorOffice.");
        }
    }
}
