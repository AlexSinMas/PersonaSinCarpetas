using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PersonasUCCommand.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PersonasUCCommand.viewmodel
{
    class MainWindowVM : ObservableObject
    {
        //private UserControl agregapersona;
        private UserControl uc;
        public UserControl UsControl
        {
            get => uc;
            set => SetProperty(ref uc, value);
        }

        private Navegacion nav;
        public RelayCommand UCListaPersonasCommand { get; }
        public RelayCommand UCNuevaPersonaCommand { get; }

        public MainWindowVM()
        {
            this.nav = new Navegacion();
            this.UCListaPersonasCommand = new RelayCommand(MuestraUCListaPersonas);
            this.UCNuevaPersonaCommand = new RelayCommand(MuestraUCNuevaPersona);
        }

        private void MuestraUCListaPersonas() => this.uc = nav.MuestraListaPersonasUC();

        private void MuestraUCNuevaPersona() => this.uc = nav.MuestraNuevaPersonaUC();




        /*
         
             class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion servicio;
        public RelayCommand AbreUC1Command { get; }
        public RelayCommand AbreUC2Command { get; }
        public RelayCommand AbreVentanaCommand { get; }

        private UserControl opcion;
        public UserControl Opcion
        {
            get => opcion;
            set => SetProperty(ref opcion, value);
        }

        public MainWindowVM()
        {
            opcion = new UserControl1();
            AbreVentanaCommand = new RelayCommand(AbrirVentana);
            AbreVentanaCommand = new RelayCommand(AbrirUC1);
            AbreVentanaCommand = new RelayCommand(AbrirUC2);
            servicio = new ServicioNavegacion();
        }

        private void AbrirVentana() => servicio.AbreVentanaHija();
        private void AbrirUC1() => opcion = servicio.AbrirUC1();
        private void AbrirUC2() => opcion = servicio.AbrirUC2();


    }
         
         */
    }
}
