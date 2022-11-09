using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace DoctorOffice
{
    public partial class FRMTurns : Form
    {
        TextBox textBoxCurrent;
        private struct ControlsTXT
        {
            public struct NameControl
            {
                public static string Name = "Nombre";
                public static Regex regExpression = new Regex(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚüÜ]{2,}$");
            }
            public struct SurnameControl
            {
                public static string Name = "Apellido";
                public static Regex regExpression = new Regex(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚüÜ]{2,}$");
            }
            public struct DNIControl
            {
                public static string Name = "DNI";
                public static Regex regExpression = new Regex(@"^([0-9]{1,3}\.[0-9]{3}\.[0-9]{3}|[0-9]{8})$");
            }
            public struct PhoneControl
            {
                public static string Name = "Celular";
                public static Regex regExpression = new Regex(@"^([0-9]{2}\-[0-9]{4}\-[0-9]{4}|[0-9]{2} [0-9]{4} [0-9]{4}|[0-9]{10})$");

            }
            public struct EmailControl
            {
                public static string Name = "email";
                public static Regex regExpression = new Regex(@"^[a-z0-9](\.?[a-z0-9])*@[a-z0-9](\.?[a-z0-9])*\.[a-z0-9]+$");
            }
        }
        private struct Colors
        {
            public static Color TXTValidatedBackColor = Color.FromArgb(166, 218, 255);
            public static Color TXTValidatedForeColor = Color.DarkCyan;
            public static Color TXTNotValidatedBackColor = Color.FromArgb(255, 223, 223);
            public static Color TXTNotValidatedForeColor = Color.Maroon;
            public static Color TXTPlaceholderBackColor = Color.White;
            public static Color TXTPlaceholderForeColor = Color.Gray;
            public static Color TXTNormalBackColor = Color.White;
            public static Color TXTNormalForeColor = Color.Black;
        }
        bool placehoder;

        public FRMTurns()
        {
            InitializeComponent();
        }

        #region TextBoxesHandlersOnEnter

        private void TXBName_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, ControlsTXT.NameControl.Name);
        }

        private void TXTSurname_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, ControlsTXT.SurnameControl.Name);
        }

        private void TXTDni_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, ControlsTXT.DNIControl.Name);
        }

        private void TXTPhone_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, ControlsTXT.PhoneControl.Name);
        }

        private void TXTEmail_Enter(object sender, EventArgs e)
        {
            TextBoxEnter(sender, ControlsTXT.EmailControl.Name);
        }

        #endregion

        private void TXBName_Leave(object sender, EventArgs e)
        {
            placehoder = TextBoxLeave(sender, ControlsTXT.NameControl.Name);
            if (!placehoder) TextBoxValidate(ControlsTXT.NameControl.regExpression);
        }
        private void TXTSurname_Leave(object sender, EventArgs e)
        {
            placehoder = TextBoxLeave(sender, ControlsTXT.SurnameControl.Name);
            if (!placehoder) TextBoxValidate(ControlsTXT.SurnameControl.regExpression);
        }
        private void TXTDni_Leave(object sender, EventArgs e)
        {
            placehoder = TextBoxLeave(sender, ControlsTXT.DNIControl.Name);
            if (!placehoder) TextBoxValidate(ControlsTXT.DNIControl.regExpression);
        }
        private void TXTPhone_Leave(object sender, EventArgs e)
        {
            placehoder = TextBoxLeave(sender, ControlsTXT.PhoneControl.Name);
            if (!placehoder) TextBoxValidate(ControlsTXT.PhoneControl.regExpression);
        }
        private void TXTEmail_Leave(object sender, EventArgs e)
        {
            placehoder = TextBoxLeave(sender, ControlsTXT.EmailControl.Name);
            if (!placehoder) TextBoxValidate(ControlsTXT.EmailControl.regExpression);
        }

        private void TextBoxEnter(object sender, string placeholder)
        {
            // resumen: es la programacion para dar la impresion de un placeholder en HTML.
            // cuando el textBox esta en foco, si el placeholder es igual al texto del texBox
            // actual, se borra para que puedo escribir sin borrar el placeholder

            // obtiene el textBox en foco actual
            textBoxCurrent = (TextBox)sender;

            // borra el placeholder. 
            if (textBoxCurrent.Text.Trim() == placeholder)
            {
                textBoxCurrent.Text = "";
                textBoxCurrent.BackColor = Colors.TXTNormalBackColor;
                textBoxCurrent.ForeColor = Colors.TXTNormalForeColor;
            }
        }

        private void TextBoxValidate(Regex regularExpression)
        {
            if (Regex.IsMatch(textBoxCurrent.Text, Convert.ToString(regularExpression)))
            {
                // valido
                textBoxCurrent.BackColor = Colors.TXTValidatedBackColor;
                textBoxCurrent.ForeColor = Colors.TXTValidatedForeColor;
            }
            else
            {
                // invalido
                textBoxCurrent.BackColor = Colors.TXTNotValidatedBackColor;
                textBoxCurrent.ForeColor = Colors.TXTNotValidatedForeColor;
            }
        }

        private bool TextBoxLeave(object sender, string placeholder)
        {
            bool result = false;
            textBoxCurrent = (TextBox)sender;

            if (textBoxCurrent.Text.Trim() == placeholder || textBoxCurrent.Text.Trim() == "")
            {
                textBoxCurrent.Text = placeholder;
                textBoxCurrent.BackColor = Colors.TXTPlaceholderBackColor;
                textBoxCurrent.ForeColor = Colors.TXTPlaceholderForeColor;
                result = true;
            }

            return result;
        }
    }
}
