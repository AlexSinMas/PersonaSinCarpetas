﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PersonasUCCommand.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.viewmodel
{
    class AgregaPersonaVM : ObservableObject
    {
        private readonly Navegacion nav;
        public RelayCommand UserControlNacionalidadCommand { get; }
        public AgregaPersonaVM()
        {
            this.nav = new Navegacion();
            this.UserControlNacionalidadCommand = new RelayCommand(AbreVentanaAgregaNacionalidad);
        }
        private void AbreVentanaAgregaNacionalidad() => nav.AbreVentanaAgregaNacionalidad();
    }
}
