using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class TextBoxValida : TextBox
    {
        private Estados estadotextbox = Estados.Defecto;

        public Estados TextboxEstado
        {
            get
            {
                return estadotextbox;
            }
            set
            {
                estadotextbox = value;
            }
        }

        //public Estados TextboxEstado { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (TextboxEstado == Estados.Defecto)
                base.OnKeyPress(e);
            else if (TextboxEstado == Estados.Solo_letras)
                e.Handled = !solo_letras(e.KeyChar);
            else if (TextboxEstado == Estados.Solo_numeros)
                e.Handled = !solo_numeros(e.KeyChar);
        }

        private Boolean solo_letras(char caracter)
        {
            if ((char.IsLetter(caracter) || char.IsControl(caracter) || char.IsSeparator(caracter)))

                 { return true; }
            else
            { return false; }
        }

        private Boolean solo_numeros(char caracter)
        {
            if ((char.IsDigit(caracter) || char.IsControl(caracter)))

                 { return true; }
            else
            { return false; }
        }

        public enum Estados
        {
            Defecto,
            Solo_numeros,
            Solo_letras,
        };

    }
}
