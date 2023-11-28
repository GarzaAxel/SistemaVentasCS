using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Productos : Form
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
            dgvProductos = new DataGridView();
            GroupBox1 = new GroupBox();
            txtIdCategoria = new TextBox();
            Label9 = new Label();
            txtIdMarca = new TextBox();
            Label10 = new Label();
            txtIdModificar = new TextBox();
            Label8 = new Label();
            Label3 = new Label();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            Label1 = new Label();
            btnBuscar = new Button();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtIdProducto = new TextBox();
            Label2 = new Label();
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnEditar = new Button();
            btnEditar.Click += new EventHandler(btnEditar_Click);
            txtNombre = new TextBox();
            btnAñadir = new Button();
            btnAñadir.Click += new EventHandler(btnAñadir_Click);
            Label4 = new Label();
            txtStock = new TextBox();
            Label5 = new Label();
            txtEstatus = new TextBox();
            txtIdCrear = new TextBox();
            Label6 = new Label();
            Label7 = new Label();
            MenuStrip1 = new MenuStrip();
            MarcaToolStripMenuItem = new ToolStripMenuItem();
            MarcaToolStripMenuItem.Click += new EventHandler(MarcaToolStripMenuItem_Click);
            CategoriaToolStripMenuItem = new ToolStripMenuItem();
            CategoriaToolStripMenuItem.Click += new EventHandler(CategoriaToolStripMenuItem_Click);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            GroupBox1.SuspendLayout();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(17, 417);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(670, 190);
            dgvProductos.TabIndex = 89;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            GroupBox1.Controls.Add(txtIdCategoria);
            GroupBox1.Controls.Add(Label9);
            GroupBox1.Controls.Add(txtIdMarca);
            GroupBox1.Controls.Add(Label10);
            GroupBox1.Controls.Add(txtIdModificar);
            GroupBox1.Controls.Add(Label8);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(txtDescripcion);
            GroupBox1.Controls.Add(txtPrecio);
            GroupBox1.Controls.Add(btnLimpiar);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(btnBuscar);
            GroupBox1.Controls.Add(txtIdProducto);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(btnEliminar);
            GroupBox1.Controls.Add(btnEditar);
            GroupBox1.Controls.Add(txtNombre);
            GroupBox1.Controls.Add(btnAñadir);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(txtStock);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(txtEstatus);
            GroupBox1.Controls.Add(txtIdCrear);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(17, 35);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(670, 376);
            GroupBox1.TabIndex = 88;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Productos";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCategoria.Location = new Point(176, 279);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(358, 22);
            txtIdCategoria.TabIndex = 8;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(47, 347);
            Label9.Name = "Label9";
            Label9.Size = new Size(123, 16);
            Label9.TabIndex = 89;
            Label9.Text = "ID UMODIFICAR:";
            // 
            // txtIdMarca
            // 
            txtIdMarca.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdMarca.Location = new Point(176, 247);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(358, 22);
            txtIdMarca.TabIndex = 7;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Transparent;
            Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(77, 314);
            Label10.Name = "Label10";
            Label10.Size = new Size(93, 16);
            Label10.TabIndex = 87;
            Label10.Text = "ID UCREAR:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(176, 344);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 10;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.Transparent;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(51, 282);
            Label8.Name = "Label8";
            Label8.Size = new Size(117, 16);
            Label8.TabIndex = 85;
            Label8.Text = "ID CATEGORIA:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(107, 150);
            Label3.Name = "Label3";
            Label3.Size = new Size(61, 16);
            Label3.TabIndex = 83;
            Label3.Text = "STOCK:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(176, 179);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(358, 22);
            txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(176, 110);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(358, 22);
            txtPrecio.TabIndex = 3;
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
            Label1.Location = new Point(55, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(115, 16);
            Label1.TabIndex = 51;
            Label1.Text = "ID PRODUCTO:";
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
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.Location = new Point(176, 38);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(358, 22);
            txtIdProducto.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(94, 73);
            Label2.Name = "Label2";
            Label2.Size = new Size(76, 16);
            Label2.TabIndex = 53;
            Label2.Text = "NOMBRE:";
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
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(176, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 22);
            txtNombre.TabIndex = 2;
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
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(55, 181);
            Label4.Name = "Label4";
            Label4.Size = new Size(113, 16);
            Label4.TabIndex = 57;
            Label4.Text = "DESCRIPCION:";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(176, 147);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(358, 22);
            txtStock.TabIndex = 4;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(86, 211);
            Label5.Name = "Label5";
            Label5.Size = new Size(82, 16);
            Label5.TabIndex = 59;
            Label5.Text = "ESTATUS:";
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(176, 211);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 6;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(176, 311);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 9;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(25, 113);
            Label6.Name = "Label6";
            Label6.Size = new Size(143, 16);
            Label6.TabIndex = 61;
            Label6.Text = "PRECIO UNITARIO:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(85, 249);
            Label7.Name = "Label7";
            Label7.Size = new Size(83, 16);
            Label7.TabIndex = 63;
            Label7.Text = "ID MARCA:";
            // 
            // MenuStrip1
            // 
            MenuStrip1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { MarcaToolStripMenuItem, CategoriaToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(704, 29);
            MenuStrip1.TabIndex = 90;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // MarcaToolStripMenuItem
            // 
            MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem";
            MarcaToolStripMenuItem.Size = new Size(67, 25);
            MarcaToolStripMenuItem.Text = "Marca";
            // 
            // CategoriaToolStripMenuItem
            // 
            CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem";
            CategoriaToolStripMenuItem.Size = new Size(93, 25);
            CategoriaToolStripMenuItem.Text = "Categoria";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(704, 616);
            Controls.Add(dgvProductos);
            Controls.Add(GroupBox1);
            Controls.Add(MenuStrip1);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            Load += new EventHandler(Productos_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView dgvProductos;
        internal GroupBox GroupBox1;
        internal TextBox txtIdModificar;
        internal Label Label8;
        internal Label Label3;
        internal TextBox txtDescripcion;
        internal TextBox txtPrecio;
        internal Button btnLimpiar;
        internal Label Label1;
        internal Button btnBuscar;
        internal TextBox txtIdProducto;
        internal Label Label2;
        internal Button btnEliminar;
        internal Button btnEditar;
        internal TextBox txtNombre;
        internal Button btnAñadir;
        internal Label Label4;
        internal TextBox txtStock;
        internal Label Label5;
        internal TextBox txtEstatus;
        internal TextBox txtIdCrear;
        internal Label Label6;
        internal Label Label7;
        internal TextBox txtIdCategoria;
        internal Label Label9;
        internal TextBox txtIdMarca;
        internal Label Label10;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem MarcaToolStripMenuItem;
        internal ToolStripMenuItem CategoriaToolStripMenuItem;
    }
}