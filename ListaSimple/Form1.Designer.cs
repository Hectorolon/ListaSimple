﻿namespace ListaSimple
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarSegundo = new System.Windows.Forms.Button();
            this.btnReporteInverso = new System.Windows.Forms.Button();
            this.btnInvertirLista = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(79, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(168, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(79, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(168, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(79, 113);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(79, 145);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(168, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(262, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(262, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(262, 76);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(315, 143);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Location = new System.Drawing.Point(262, 110);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarInicio.TabIndex = 14;
            this.btnAgregarInicio.Text = "AgregarInicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.Location = new System.Drawing.Point(384, 12);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPrimero.TabIndex = 15;
            this.btnEliminarPrimero.Text = "EliminarPrimero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // btnEliminarSegundo
            // 
            this.btnEliminarSegundo.Location = new System.Drawing.Point(384, 45);
            this.btnEliminarSegundo.Name = "btnEliminarSegundo";
            this.btnEliminarSegundo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSegundo.TabIndex = 16;
            this.btnEliminarSegundo.Text = "EliminarUltimo";
            this.btnEliminarSegundo.UseVisualStyleBackColor = true;
            this.btnEliminarSegundo.Click += new System.EventHandler(this.btnEliminarSegundo_Click);
            // 
            // btnReporteInverso
            // 
            this.btnReporteInverso.Location = new System.Drawing.Point(384, 76);
            this.btnReporteInverso.Name = "btnReporteInverso";
            this.btnReporteInverso.Size = new System.Drawing.Size(75, 23);
            this.btnReporteInverso.TabIndex = 17;
            this.btnReporteInverso.Text = "ReporteInverso";
            this.btnReporteInverso.UseVisualStyleBackColor = true;
            // 
            // btnInvertirLista
            // 
            this.btnInvertirLista.Location = new System.Drawing.Point(384, 110);
            this.btnInvertirLista.Name = "btnInvertirLista";
            this.btnInvertirLista.Size = new System.Drawing.Size(75, 23);
            this.btnInvertirLista.TabIndex = 18;
            this.btnInvertirLista.Text = "InvertirLista";
            this.btnInvertirLista.UseVisualStyleBackColor = true;
            this.btnInvertirLista.Click += new System.EventHandler(this.btnInvertirLista_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(15, 188);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrar.Size = new System.Drawing.Size(444, 158);
            this.txtMostrar.TabIndex = 19;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(343, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(35, 20);
            this.txtBuscar.TabIndex = 20;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(343, 79);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(35, 20);
            this.txtEliminar.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 358);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnInvertirLista);
            this.Controls.Add(this.btnReporteInverso);
            this.Controls.Add(this.btnEliminarSegundo);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarSegundo;
        private System.Windows.Forms.Button btnReporteInverso;
        private System.Windows.Forms.Button btnInvertirLista;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtEliminar;
    }
}

