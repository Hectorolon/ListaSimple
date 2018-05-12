﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    public partial class Form1 : Form
    {
        Inventario inventario = new Inventario(15);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);
            inventario.agregar(new Producto
                (codigo, txtNombre.Text, txtDescripcion.Text,
                cantidad, precio));
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMostrar.Clear();
            int posicion = Convert.ToInt32(txtEliminar.Text);
            txtMostrar.Text = inventario.eliminar(posicion);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = inventario.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtBuscar.Text);
            Producto buscar = inventario.buscar(codigo);
            if (buscar != null)
            {
                txtMostrar.Text = buscar.ToString();
            }
            else
            {
                txtMostrar.Text = "Producto no encontrado";
            }

        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);
            inventario.agregarInicio(new Producto
                (codigo, txtNombre.Text, txtDescripcion.Text,
                cantidad, precio));
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            inventario.eliminarPrimero();
        }

        private void btnEliminarSegundo_Click(object sender, EventArgs e)
        {
            inventario.eliminarUltimo();
        }

        private void btnInvertirLista_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = inventario.invertirListar();
        }
    }
}
