﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Negocio.Servicios;
//using Negocio.Objetos;
using System.Security.Cryptography;
using Presentacion.Helpers;
using Negocio.Servicios;
using Negocio.Objetos;
using Negocio.Modelo;





//de pueba
//package5
namespace Presentacion.Formularios
{
    public partial class FormInicio : Form
    {
        
        public FormInicio()
        {
            InitializeComponent();
            string usuarioNombre = Properties.Settings.Default.UserName;
            this.Text = usuarioNombre;
        }
        public void ActulizarProductos()
        {
            string consulta = txtConsulta.Text;
            if (consulta.Trim() != string.Empty)
            {
                consulta = txtConsulta.Text;
            }
            else
            {
                consulta = null;
            }
            ProductosServicio servicio = new ProductosServicio();
            List<DataProducto> list = servicio.ObtenerProductos(consulta);
            dgvProductos.DataSource = list;
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            //llamo a conexion.             
            string consulta = txtConsulta.Text;
            if (consulta.Trim()!= string.Empty)
            {
                consulta = txtConsulta.Text;
            } else
            {
                consulta = null;
            }
            ProductosServicio servicio = new ProductosServicio();
            List<DataProducto> list = servicio.ObtenerProductos(consulta);
            dgvProductos.DataSource = list;            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            





            //abrir formulario  
            int indice = -1;
            try
            {
                indice = dgvProductos.CurrentRow.Index;
            }catch 
            {
                MessageBox.Show("seleccione un Producto a editar");
            }

            
            //hay un indice seleccionado
            
            if (indice >-1)
            {
                DataProducto prod = new DataProducto();
                DataGridViewRow fila = dgvProductos.CurrentRow;
                //prod.Id_productos = (long) fila.Cells[0].Value;
                prod.Id_productos = (long)fila.Cells[0].Value;
                prod.Codigo = (string)fila.Cells[1].Value;
                prod.Descripcion = (string)fila.Cells[2].Value;
                prod.Precio = (float)fila.Cells[3].Value;
                prod.Fecha = (DateTime)fila.Cells[4].Value;                
                Form form = new EditarProducto(prod, Modo.Actualizar);
                form.Show();            
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form form = new AgregarProducto(Modo.Agregar);
            form.Show();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("seguro que desea\r\n salir", "salir",
                MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //llamar a agregar    
                Properties.Settings.Default.estalogueado = false;
                Properties.Settings.Default.Save();
                Application.Exit();

            }

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //abrir formulario
            DataProducto prod = new DataProducto();
            DataGridViewRow fila = dgvProductos.CurrentRow;            
            //prod.Id_productos = (long) fila.Cells[0].Value;
            prod.Id_productos = (long) fila.Cells[0].Value;
            prod.Codigo = (string) fila.Cells[1].Value;
            prod.Descripcion = (string) fila.Cells[2].Value;
            prod.Precio = (float) fila.Cells[3].Value;
            prod.Fecha = (DateTime) fila.Cells[4].Value;
            Form form = new AgregarProducto(prod);
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminar el articulo de Id pasado
            //eliminar el articulo de Id pasado
            int indice = -1;
            try
            {
                indice = dgvProductos.CurrentRow.Index;
            }
            catch
            {
                MessageBox.Show("seleccione un Producto a Eliminar");
            }


            //hay un indice seleccionado

            if (indice > -1)
            {
                DialogResult resultado = MessageBox.Show("seguro que desea\r\n eliminar", "salir",
                MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    //llamar a agregar        
                    DataGridViewRow fila = dgvProductos.CurrentRow;
                    //prod.Id_productos = (long) fila.Cells[0].Value;
                    long idproducto = (long)fila.Cells[0].Value;
                    //long idproducto = long.Parse(txtid.Text);
                    Producto producto = new Producto(idproducto);
                    producto.EliminarProducto();
                }

            }


                


        }
    }
}
