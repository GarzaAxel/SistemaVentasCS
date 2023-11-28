using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DetalleVenta : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            dgvDVenta = new DataGridView();
            GroupBox1 = new GroupBox();
            Label9 = new Label();
            txtIdVenta = new TextBox();
            Label10 = new Label();
            txtIdModificar = new TextBox();
            Label3 = new Label();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            Label1 = new Label();
            btnBuscar = new Button();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtIdDetalleVenta = new TextBox();
            Label2 = new Label();
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnEditar = new Button();
            btnEditar.Click += new EventHandler(btnEditar_Click);
            txtCantidad = new TextBox();
            btnAñadir = new Button();
            btnAñadir.Click += new EventHandler(btnAñadir_Click);
            txtTotal = new TextBox();
            Label5 = new Label();
            txtIdProducto = new TextBox();
            txtIdCrear = new TextBox();
            Label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDVenta).BeginInit();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDVenta
            // 
            dgvDVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDVenta.Location = new Point(12, 312);
            dgvDVenta.Name = "dgvDVenta";
            dgvDVenta.Size = new Size(670, 190);
            dgvDVenta.TabIndex = 95;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            GroupBox1.Controls.Add(Label9);
            GroupBox1.Controls.Add(txtIdVenta);
            GroupBox1.Controls.Add(Label10);
            GroupBox1.Controls.Add(txtIdModificar);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(btnLimpiar);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(btnBuscar);
            GroupBox1.Controls.Add(txtIdDetalleVenta);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(btnEliminar);
            GroupBox1.Controls.Add(btnEditar);
            GroupBox1.Controls.Add(txtCantidad);
            GroupBox1.Controls.Add(btnAñadir);
            GroupBox1.Controls.Add(txtTotal);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(txtIdProducto);
            GroupBox1.Controls.Add(txtIdCrear);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(12, 14);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(670, 289);
            GroupBox1.TabIndex = 94;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "DetalleVenta";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(47, 255);
            Label9.Name = "Label9";
            Label9.Size = new Size(123, 16);
            Label9.TabIndex = 89;
            Label9.Text = "ID UMODIFICAR:";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdVenta.Location = new Point(176, 184);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(358, 22);
            txtIdVenta.TabIndex = 6;
            txtIdVenta.UseSystemPasswordChar = true;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Transparent;
            Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(77, 222);
            Label10.Name = "Label10";
            Label10.Size = new Size(93, 16);
            Label10.TabIndex = 87;
            Label10.Text = "ID UCREAR:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(176, 252);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 8;
            txtIdModificar.UseSystemPasswordChar = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(107, 114);
            Label3.Name = "Label3";
            Label3.Size = new Size(60, 16);
            Label3.TabIndex = 83;
            Label3.Text = "TOTAL:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(568, 86);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 34);
            btnLimpiar.TabIndex = 82;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(56, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(111, 16);
            Label1.TabIndex = 51;
            Label1.Text = "ID DETALLE V:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(568, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 34);
            btnBuscar.TabIndex = 81;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIdDetalleVenta
            // 
            txtIdDetalleVenta.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdDetalleVenta.Location = new Point(176, 38);
            txtIdDetalleVenta.Name = "txtIdDetalleVenta";
            txtIdDetalleVenta.Size = new Size(358, 22);
            txtIdDetalleVenta.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(77, 76);
            Label2.Name = "Label2";
            Label2.Size = new Size(88, 16);
            Label2.TabIndex = 53;
            Label2.Text = "CANTIDAD:";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(568, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(66, 34);
            btnEliminar.TabIndex = 79;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(568, 172);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(66, 34);
            btnEditar.TabIndex = 78;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(176, 73);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(358, 22);
            txtCantidad.TabIndex = 2;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(568, 129);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(66, 34);
            btnAñadir.TabIndex = 76;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(176, 108);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(358, 22);
            txtTotal.TabIndex = 4;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(52, 151);
            Label5.Name = "Label5";
            Label5.Size = new Size(115, 16);
            Label5.TabIndex = 59;
            Label5.Text = "ID PRODUCTO:";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.Location = new Point(176, 145);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(358, 22);
            txtIdProducto.TabIndex = 5;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(176, 219);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 7;
            txtIdCrear.UseSystemPasswordChar = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(84, 184);
            Label7.Name = "Label7";
            Label7.Size = new Size(81, 16);
            Label7.TabIndex = 63;
            Label7.Text = "ID VENTA:";
            // 
            // DetalleVenta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 514);
            Controls.Add(dgvDVenta);
            Controls.Add(GroupBox1);
            Name = "DetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleVenta";
            ((System.ComponentModel.ISupportInitialize)dgvDVenta).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(DetalleVenta_Load);
            ResumeLayout(false);

        }

        internal DataGridView dgvDVenta;
        internal GroupBox GroupBox1;
        internal Label Label9;
        internal TextBox txtIdVenta;
        internal Label Label10;
        internal TextBox txtIdModificar;
        internal Label Label3;
        internal Button btnLimpiar;
        internal Label Label1;
        internal Button btnBuscar;
        internal TextBox txtIdDetalleVenta;
        internal Label Label2;
        internal Button btnEliminar;
        internal Button btnEditar;
        internal TextBox txtCantidad;
        internal Button btnAñadir;
        internal TextBox txtTotal;
        internal Label Label5;
        internal TextBox txtIdProducto;
        internal TextBox txtIdCrear;
        internal Label Label7;
    }
}