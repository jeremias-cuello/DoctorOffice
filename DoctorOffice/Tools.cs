using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorOffice
{
    static class ToolsUI
    {
        public struct ControlsTXT
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
            public struct NumberTuitionControl
            {
                public static string Name = "Número de Matricula";
                public static Regex regExpression = new Regex(@"^[0-9]{5,}$");
            }
        }
        public struct Colors
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
        public static TextBox textBoxCurrent;
        public static bool placeholder;

        public static List<TextBox> GetTextBoxes(this GroupBox gpb)
        {
            List<TextBox> lst = new List<TextBox>();

            foreach (var c in gpb.Controls)
            {
                if (c.GetType().Name == "TextBox")
                {
                    lst.Add((TextBox)c);
                }
            }

            return lst;
        }
        public static void TextBoxEnter(object sender, string placeholder)
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
                textBoxCurrent.BackColor = ToolsUI.Colors.TXTNormalBackColor;
                textBoxCurrent.ForeColor = ToolsUI.Colors.TXTNormalForeColor;
            }
        }

        public static void TextBoxValidate(Regex regularExpression)
        {
            if (Regex.IsMatch(textBoxCurrent.Text, Convert.ToString(regularExpression)))
            {
                // valido
                textBoxCurrent.BackColor = ToolsUI.Colors.TXTValidatedBackColor;
                textBoxCurrent.ForeColor = ToolsUI.Colors.TXTValidatedForeColor;
            }
            else
            {
                // invalido
                textBoxCurrent.BackColor = ToolsUI.Colors.TXTNotValidatedBackColor;
                textBoxCurrent.ForeColor = ToolsUI.Colors.TXTNotValidatedForeColor;
            }
        }

        public static bool TextBoxLeave(object sender, string placeholder)
        {
            bool result = false;
            textBoxCurrent = (TextBox)sender;

            if (textBoxCurrent.Text.Trim() == placeholder || textBoxCurrent.Text.Trim() == "")
            {
                textBoxCurrent.Text = placeholder;
                textBoxCurrent.BackColor = ToolsUI.Colors.TXTPlaceholderBackColor;
                textBoxCurrent.ForeColor = ToolsUI.Colors.TXTPlaceholderForeColor;
                result = true;
            }

            return result;
        }

        public static bool Selected(this DataGridView dgv)
        {
            bool selected = (dgv.SelectedRows.Count > 0);

            if(!selected)
                MessageBox.Show("Debe Seleccionar una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return selected;
        }
    }
}
