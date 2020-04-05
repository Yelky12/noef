﻿using System;
using System.Collections.Generic;
using System.Text;

namespace noef.models
{
  

    public class Conexion {

        private string servidor;
        private string baseDatos;
        private string usuario;
        private string password;
        private string compania;
        private string port;

        public string Servidor { get => servidor; set => servidor = value; }
        public string BaseDatos { get => baseDatos; set => baseDatos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Compania { get => compania; set => compania = value; }
        public string Port { get => port; set => port = value; }
    }

  

}