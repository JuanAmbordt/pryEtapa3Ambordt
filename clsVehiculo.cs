﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEtapa3Ambordt
{
    internal class clsVehiculo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }

        public clsVehiculo(string nombre, string tipo, Image imagen)
        {
            Nombre = nombre;
            Tipo = tipo;
            Imagen = imagen;
        }
    }
}
