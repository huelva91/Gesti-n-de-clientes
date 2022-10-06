using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_clientes.modelos
{
    internal class Cliente
    {
        private string id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string tarjetaDeCredito;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string TarjetaDeCredito { get => tarjetaDeCredito; set => tarjetaDeCredito = value; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
