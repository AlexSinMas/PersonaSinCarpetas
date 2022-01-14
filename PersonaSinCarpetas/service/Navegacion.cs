using PersonasUCCommand.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PersonasUCCommand.service
{
    class Navegacion
    {
        public Navegacion()
        {

        }

        public void AbreVentanaAgregaNacionalidad()
        {
            AgregaNacionalidadVentana userControl = new AgregaNacionalidadVentana();
            userControl.ShowDialog();
        }

        internal UserControl MuestraNuevaPersonaUC() => new AgregaPersona();
    }
}
