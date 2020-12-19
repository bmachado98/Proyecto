using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelo;
using Negocio.Objetos;
using Presentacion.Helpers;
 

namespace Presentacion.Formularios
{
    public partial class EditarProducto : Form
    {
        private readonly Modo modo;
        //private FormInicio formInicio;
        private DataProducto dataProducto;

        
        /// <summary>
        /// se usa para agregar
        /// </summary>
        /// <param name="modo"></param>
        /*public EditarProducto(Modo modo, FormInicio formInicio)
        {
            InitializeComponent();
            this.modo = modo;
            this.formInicio = formInicio;
            this.Text = "Agregar Nuevo Producto";
            groupProd.Text = "Agregar Nuevo Producto";
            // ocultar el boton de editar
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
        }*/
        /// <summary>
        /// se usa para editar
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="modo"></param>
        public EditarProducto(DataProducto prod, Modo modo)
        {

            InitializeComponent();
            txtid.Enabled = false;
            this.modo = modo;
            this.Text = "Editar Producto";
            groupProd.Text = "Editar Producto";
            this.dataProducto = prod;
            Iniciar(prod);
            // ocultar el boton de agregar
            /*btnEditar.Enabled = true;
            txtid.Enabled = true;*/
        }

        /*public EditarProducto(DataProducto prod, Modo modo) : this(prod, modo)
        {
            
        }*/

        public void Iniciar()
        {
            txtid.Text = "";
            txtcodigo.Text = "";
            txtprecio.Text = "";
            txtdescription.Text = "";
            dtpfecha.Value = new DateTime(2020, 7, 29);
        }
        public void Iniciar(DataProducto prod)
        {
            txtid.Text = prod.Id_productos.ToString();
            txtcodigo.Text = prod.Codigo.ToString();
            txtprecio.Text = prod.Precio.ToString();
            txtdescription.Text = prod.Descripcion;
            dtpfecha.Value = prod.Fecha;
            
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        

        /*private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("seguro que desea\r\n agregar", "salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes &&
                txtcodigo.Text.Trim()!= string.Empty &&
                txtdescription.Text.Trim() != string.Empty &&
                txtprecio.Text.Trim() != string.Empty)
            {
                //llamar a agregar 
                DateTime fecha = dtpfecha.Value.Date;
                DataProducto prod = new DataProducto();
                //prod.Id_productos= long.Parse(txtid.Text);
                prod.Codigo = txtcodigo.Text.ToString();
                prod.Precio = float.Parse(txtprecio.Text.ToString());                 
                prod.Descripcion = txtdescription.Text;
                prod.Fecha = fecha;
                Producto producto = new Producto();
                producto.AgregarProducto(prod);                
            }
        }*/

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //deshabilita la edicion del id
            
            
            string errores = "";
            bool errorBool = false;
            string codigoStr =txtcodigo.Text.Trim();
            string precioStr = txtprecio.Text.Trim();
            string descripcionStr = txtdescription.Text.Trim();

            float precioFloat = 0.0f; 
            if (string.IsNullOrEmpty(precioStr))
            {
                errores += "el precio no puede ser vacio\n";
                errorBool = true;
            }
            if (string.IsNullOrEmpty(descripcionStr))
            {
                errores += "la descripcion no puede ser vacía\n";
                errorBool = true;
            }
            try
            {
                
                precioFloat = float.Parse(precioStr, CultureInfo.InvariantCulture.NumberFormat);
                
            }
            catch (Exception ex)
            {
                //casting, es conversión.
                errores += "el precio no es válido\n";
                errorBool = true;
            }



            if (!errorBool)
            {
                DialogResult resultado = MessageBox.Show("seguro que desea\r\n editar", "salir",
                MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {

                    //llamar a agregar 
                    DateTime fecha = dtpfecha.Value.Date;
                    DataProducto prod = new DataProducto();
                    prod.Id_productos = long.Parse(txtid.Text);
                    prod.Codigo = codigoStr;
                    prod.Precio = precioFloat;
                    prod.Descripcion = descripcionStr;
                    prod.Fecha = fecha;
                    Producto producto = new Producto();
                    producto.EditarProducto(prod);

                }
            }
            else
            {
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(errores, title, buttons, MessageBoxIcon.Warning);
            }

                






            


        }

        /*private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminar el articulo de Id pasado
            DialogResult resultado = MessageBox.Show("seguro que desea\r\n eliminar", "salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                //llamar a agregar                 
                long idproducto = long.Parse(txtid.Text);
                Producto producto = new Producto();
                producto.EliminarProducto(idproducto);                
            }
        }*/

        private void AgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formInicio.ActulizarProductos();
        }

        private void groupProd_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar(this.dataProducto);
        }
    }
}
