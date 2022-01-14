using PersonasUCCommand.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PersonasUCCommand.service
{
    class Navegacion
    {
        private AgregaNacionalidadVentana userControl;
        private String nac;

        public Navegacion() 
        {
            this.userControl = new AgregaNacionalidadVentana();
        }
        public AgregaNacionalidadVentana AbreVentanaAgregaNacionalidad()
        {
            userControl.textNacionalidad.Text = "";
            userControl.ShowDialog();
            return this.userControl;
        }
        internal UserControl MuestraNuevaPersonaUC() => new AgregaPersona();
        internal UserControl MuestraListaPersonasUC() => new ListaPersonasUC();
        
    }
}
