using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoctorOffice
{
    public partial class FRMTurns : Form
    {
        TextBox textBoxCurrent;
        private struct RegExpressions
        {
            public static Regex Name = new Regex(@"^[a-zA-ZñÑáéíúÁÉÍÓÚ]${2}");
            public static Regex Surname = new Regex(@"^[a-zA-ZñÑáéíúÁÉÍÓÚ]${2}");
            public static Regex Dni = new Regex(@"^[0-9.]{1,3}\.[0-9.]{1,3}\.[0-9.]${1,3}");
            public static Regex Phone = new Regex(@"^[0-9.]{2}\-[0-9.]{4}\-[0-9.]{4}${1,3}");
            public static Regex Email = new Regex(@"^[a-z0-9\.]+@[a-z0-9\.]+\.[a-z0-9\.]+${1,3}");
        }

        public FRMTurns()
        {
            InitializeComponent();
        }

        private void TXBName_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, "Nombre");
        }

        private void TXTSurname_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, "Apellido");
        }

        private void TXTDni_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, "DNI");
        }

        private void TXTPhone_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, "Teléfono");
        }

        private void TXTEmail_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, "Email");
        }

        private void TXBName_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(sender, "Nombre");
            TextBoxValidate(RegExpressions.Name);
        }
        private void TXTSurname_Leave(object sender, EventArgs e)
        {
            TextBoxValidate(RegExpressions.Surname); 
            TextBoxLeave(sender, "Apellido");
        }
        private void TXTDni_Leave(object sender, EventArgs e)
        {
            TextBoxValidate(RegExpressions.Dni); 
            TextBoxLeave(sender, "DNI");
        }
        private void TXTPhone_Leave(object sender, EventArgs e)
        {
            TextBoxValidate(RegExpressions.Phone); 
            TextBoxLeave(sender, "Teléfono");
        }
        private void TXTEmail_Leave(object sender, EventArgs e)
        {
            TextBoxValidate(RegExpressions.Email);
            TextBoxLeave(sender, "Email");
        }

        private void TextBoxEnter(object sender, string data)
        {
            textBoxCurrent = (TextBox)sender;

            if (textBoxCurrent.Text.Trim() == data || textBoxCurrent.Text.Trim() == "")
            {
                textBoxCurrent.Text = "";
                textBoxCurrent.ForeColor = Color.Black;
            }
        }
        private void TextBoxLeave(object sender, string data)
        {
            textBoxCurrent = (TextBox)sender;

            if (textBoxCurrent.Text.Trim() == data || textBoxCurrent.Text.Trim() == "")
            {
                textBoxCurrent.Text = data;
                textBoxCurrent.ForeColor = Color.Gray;
            }
        }
        private void TextBoxValidate(Regex regularExpression)
        {
            if (!Regex.IsMatch(textBoxCurrent.Text, Convert.ToString(regularExpression)))
            {
                textBoxCurrent.BackColor = Color.FromArgb(166, 218, 255);
                textBoxCurrent.ForeColor = Color.DarkCyan;
            }
            else
            {
                textBoxCurrent.BackColor = Color.FromArgb(255, 223, 223);
                textBoxCurrent.ForeColor = Color.Maroon;
            }
        }
    }
}
