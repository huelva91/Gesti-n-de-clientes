using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestión_de_clientes.dao;
using Gestión_de_clientes.modelos;

namespace Gestión_de_clientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista(); 


        }
        private void actualizarLista()
        {
            ClienteDao basdeDeDatos = new ClienteDao();
            List<Cliente> listaDb = basdeDeDatos.ObtenerlistadoDeClientes();

            listClientes.Items.Clear();

            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjeta.Text;

            if (lblId.Text != "") 
            {
                cliente.Id = lblId.Text;
            }


            ClienteDao basdeDeDatos = new ClienteDao();
            basdeDeDatos.Guardar(cliente);
            actualizarLista();
            limpiarLista();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            ClienteDao basdeDeDatos = new ClienteDao();
            basdeDeDatos.Eliminar(cliente);
            actualizarLista();
            limpiarLista();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjeta.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.Id;
       


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarLista();
        }

        private void limpiarLista()
        {
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
        }
    }
}
