using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.viewmodel
{
    class AgregaNacionalidadVM : ObservableObject
    {
        private String nac;
        public String Nacionalidad
        {
            get => nac;
            set => SetProperty(ref nac, value);
        }

        public AgregaNacionalidadVM()
        {
            this.Nacionalidad = "";
        }
    }
}
