using Negocio.Modelo;
using Negocio.Objetos;
using Presentacion.Helpers;
using System;
using System.Windows.Forms;


namespace Presentacion.Formularios
{
    public partial class EliminarProducto : Form
    {
        private readonly Modo modo;
        private FormInicio formInicio;

        public DataProducto Prod { get; }

        public EliminarProducto()
        {
            InitializeComponent();
        }
        /// <summary>
        /// se usa para agregar
        /// </summary>
        /// <param name="modo"></param>
        public EliminarProducto(Modo modo, FormInicio formInicio)
        {
            InitializeComponent();
            this.modo = modo;
            this.formInicio = formInicio;
            this.Text = "Eliminar Nuevo Producto";
            groupProd.Text = "Eliminar Nuevo Producto";
            // ocultar el boton de editar
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;
        }
        /// <summary>
        /// se usa para editar
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="modo"></param>
        /*public EliminarProducto(DataProducto prod, Modo modo)
        {

            InitializeComponent();
            this.modo = modo;
            this.Text = "Editar Producto";
            groupProd.Text = "Editar Producto";
            Iniciar(prod);
            // ocultar el boton de agregar
            btnAgregar.Enabled = false;
            txtid.Enabled = false;
        }*/

        public EliminarProducto(DataProducto prod, Modo modo, FormInicio formInicio) : this(prod, modo)
        {
            this.formInicio = formInicio;
        }

        public EliminarProducto(DataProducto prod, Modo modo)
        {
            Prod = prod;
            this.modo = modo;
        }

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

        private void btntest_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        /*private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("seguro que desea\r\n editar", "salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes &&
                txtcodigo.Text.Trim() != string.Empty &&
                txtdescription.Text.Trim() != string.Empty &&
                txtprecio.Text.Trim() != string.Empty)
            {
                //llamar a agregar 
                DateTime fecha = dtpfecha.Value.Date;
                DataProducto prod = new DataProducto();
                prod.Id_productos = long.Parse(txtid.Text);
                prod.Codigo = txtcodigo.Text.ToString();
                prod.Precio = float.Parse(txtprecio.Text.ToString());
                prod.Descripcion = txtdescription.Text;
                prod.Fecha = fecha;
                Producto producto = new Producto();
                producto.EditarProducto(prod);
            }
        }*/

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
            formInicio.ActulizarProductos();
        }
        

        private void btnElimnar_Click(object sender, EventArgs e)
        {

        }
    }
}
