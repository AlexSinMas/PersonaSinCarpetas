using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PersonasUCCommand.service;
using PersonasUCCommand.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.viewmodel
{
    class AgregaPersonaVM : ObservableObject
    {
        private AgregaNacionalidadVentana ventanaNac;
        private AgregaNacionalidadVentana VentanaNac
        {
            get => ventanaNac;
            set => SetProperty(ref ventanaNac, value);
        }
        private List<String> nacs; 
        public List<String> Nacionalidades
        {
            get => nacs;
            set => SetProperty(ref nacs, value);
        }
        private readonly Navegacion nav;
        public RelayCommand UserControlNacionalidadCommand { get; }
        public AgregaPersonaVM()
        {
            //this.nav = new Navegacion();
            this.nacs = new List<String>{ "R. Dominicana","Venezuela","España"};
            this.VentanaNac = new AgregaNacionalidadVentana();
            this.UserControlNacionalidadCommand = new RelayCommand(AbreVentanaAgregaNacionalidad);
        }
        private void AbreVentanaAgregaNacionalidad() => VentanaNac.ShowDialog();//nav.AbreVentanaAgregaNacionalidad();

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            Nacionalidades.Add(VentanaNac.textNacionalidad.Text);
        }

        protected override void OnPropertyChanging(PropertyChangingEventArgs e)
        {
            base.OnPropertyChanging(e);
        }
    }
}
