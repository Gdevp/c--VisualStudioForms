using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjConexionClase
{
    public partial class frmMantenimientoContratista : Form
    {
        LogicaNegocio objL = new LogicaNegocio();
        public frmMantenimientoContratista()
        {
            InitializeComponent();
        }
        //Carga inicial del formulario.
        private void Form11_Load(object sender, EventArgs e)
        {
            llenaContratista();

            lblCodigo1.Text = generaCodigo1();
        }
        // METODO QUE MANEJA EL EVENTO DE HACER CLICK EN EL BOTON "NUEVO"
        private void tsNuevo1_Click(object sender, EventArgs e)
        {
            lblCodigo1.Text = generaCodigo1();
            limpiarControles1();
        }
        // METODO QUE MANEJA EVENTO DE CLIC EN BOTÓN "SALIR"
        private void tsSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // METODO QUE MANEJA EVENTO DE CLIC EN BOTÓN "GRABAR" PARA REGISTRAR UN CONTRATISTA
        private void tsGrabar1_Click(object sender, EventArgs e)
        {
            string codigo = lblCodigo1.Text;
            string nombre = txtNombre.Text;
            string apellido_paterno = txtApePaterno.Text;
            string apellido_materno = txtApeMaterno.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            // Llama al método para registrar el contratista.
            string mensaje = objL.nuevoContratista(codigo, nombre, apellido_paterno, apellido_materno, telefono, email);
            // Muestra el mensaje.
            MessageBox.Show(mensaje);
            llenaContratista();
        }
        // METODO QUE MANEJA EVENTO DE CLIC EN BOTÓN "MODIFICAR" PARA ACTUALIZAR UN CONTRATISTA
        private void tsModificar1_Click(object sender, EventArgs e)
        {
            if (valida1() == "")
            {
                // Capturando los datos del Formulario
                string codigo = lblCodigo1.Text;
                string nombre = txtNombre.Text;
                string apellido_paterno = txtApePaterno.Text;
                string apellido_materno = txtApeMaterno.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                //Grabadno el nuevo equipo
                string mensaje = objL.actualizaContratista(codigo, nombre, apellido_paterno,
                apellido_materno, telefono, email);
                MessageBox.Show(mensaje);
                llenaContratista();
            }
            else
            {
                MessageBox.Show("El Error se encuentra" + valida1());
            }
        }
        // METODO QUE MANEJA EVENTO DE CLIC EN BOTÓN "ELIMINAR" PARA ELIMINAR UN CONTRATISTA
        private void tsEliminar1_Click(object sender, EventArgs e)
        {
            //Capturandod los datos del formulario
            string codigo = lblCodigo1.Text;
            //Eliminando
            string mensaje = objL.eliminaContratista(codigo);
            MessageBox.Show(mensaje);
            llenaContratista();
        }
        // METOD QUE LIMPIA CONTROLES DEL FORMULARIO
        void limpiarControles1()
        {
            txtNombre.Clear();
            txtApePaterno.Clear();
            txtApeMaterno.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            txtNombre.Focus();
        }
        // METODO0 QUE LLENA UN DATAGRIDVIEW CON LA LISTA DE CONTRATISTAS
        void llenaContratista()
        {
            dgMantContratistas.DataSource = objL.listaUnContratista();
        }
        // METODOQ QUE GENERA UN NUEVO CÓDIGO PARA UN CONTRATISTA
        string generaCodigo1()
        {
            return objL.generaCodigo1();
        }
        // METOD QUE VALIDA LOS CAMPOS DEL FORMULARIO Y DEVUELVE UN MENSAJE DE ERROR SI ES NECESARIO
        string valida1()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                txtNombre.Clear();
                txtNombre.Focus();
                return "Nombre del Contratista";
            }
            else if (txtApePaterno.Text.Trim().Length == 0)
            {
                txtApePaterno.Clear();
                txtApePaterno.Focus();
                return "Apellido Paterno del Contratista";

            }
            else if (txtApeMaterno.Text.Trim().Length == 0)
            {
                txtApeMaterno.Clear();
                txtApeMaterno.Focus();
                return "Apellido Materno del Contratista";

            }
            else if (txtTelefono.Text.Trim().Length == 0)
            {
                txtTelefono.Clear();
                txtTelefono.Focus();
                return "N° de telefono del Contratista";

            }
            else if (txtEmail.Text.Trim().Length == 0)
            {
                txtEmail.Clear();
                txtEmail.Focus();
                return "Email/Correo del Contratista";
            }
            else
                return "";
        }
        // METODO QUE MANEJA EVENTO DE CLIC EN UNA CELDA DEL DATA-GRIDVIEW PARA CARGAR LOS DATOS DE UN CONTRATISTA EN EL FORMULARIO
        private void dgMantContratistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo1.Text = dgMantContratistas.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgMantContratistas.CurrentRow.Cells[1].Value.ToString();
            txtApePaterno.Text = dgMantContratistas.CurrentRow.Cells[2].Value.ToString();
            txtApeMaterno.Text = dgMantContratistas.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgMantContratistas.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgMantContratistas.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
