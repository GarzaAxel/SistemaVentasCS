using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Compras : Form
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
            dgvCompras = new DataGridView();
            GroupBox1 = new GroupBox();
            Label9 = new Label();
            txtIdProveedor = new TextBox();
            Label10 = new Label();
            txtIdModificar = new TextBox();
            Label3 = new Label();
            txtIVA = new TextBox();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            Label1 = new Label();
            btnBuscar = new Button();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtIdCompra = new TextBox();
            Label2 = new Label();
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnEditar = new Button();
            btnEditar.Click += new EventHandler(btnEditar_Click);
            txtFecha = new TextBox();
            btnAñadir = new Button();
            btnAñadir.Click += new EventHandler(btnAñadir_Click);
            txtSubtotal = new TextBox();
            Label5 = new Label();
            txtEstatus = new TextBox();
            txtIdCrear = new TextBox();
            Label6 = new Label();
            Label7 = new Label();
            MenuStrip1 = new MenuStrip();
            DetalleComprasToolStripMenuItem = new ToolStripMenuItem();
            DetalleComprasToolStripMenuItem.Click += new EventHandler(DetalleComprasToolStripMenuItem_Click);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            GroupBox1.SuspendLayout();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(12, 373);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.Size = new Size(670, 190);
            dgvCompras.TabIndex = 91;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            GroupBox1.Controls.Add(Label9);
            GroupBox1.Controls.Add(txtIdProveedor);
            GroupBox1.Controls.Add(Label10);
            GroupBox1.Controls.Add(txtIdModificar);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(txtIVA);
            GroupBox1.Controls.Add(btnLimpiar);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(btnBuscar);
            GroupBox1.Controls.Add(txtIdCompra);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(btnEliminar);
            GroupBox1.Controls.Add(btnEditar);
            GroupBox1.Controls.Add(txtFecha);
            GroupBox1.Controls.Add(btnAñadir);
            GroupBox1.Controls.Add(txtSubtotal);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(txtEstatus);
            GroupBox1.Controls.Add(txtIdCrear);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(12, 40);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(670, 324);
            GroupBox1.TabIndex = 90;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Compras";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(47, 294);
            Label9.Name = "Label9";
            Label9.Size = new Size(123, 16);
            Label9.TabIndex = 89;
            Label9.Text = "ID UMODIFICAR:";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProveedor.Location = new Point(176, 223);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(358, 22);
            txtIdProveedor.TabIndex = 6;
            txtIdProveedor.UseSystemPasswordChar = true;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Transparent;
            Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(77, 261);
            Label10.Name = "Label10";
            Label10.Size = new Size(93, 16);
            Label10.TabIndex = 87;
            Label10.Text = "ID UCREAR:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(176, 291);
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
            Label3.Location = new Point(77, 150);
            Label3.Name = "Label3";
            Label3.Size = new Size(91, 16);
            Label3.TabIndex = 83;
            Label3.Text = "SUBTOTAL:";
            // 
            // txtIVA
            // 
            txtIVA.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIVA.Location = new Point(176, 110);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(358, 22);
            txtIVA.TabIndex = 3;
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
            Label1.Location = new Point(74, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(94, 16);
            Label1.TabIndex = 51;
            Label1.Text = "ID COMPRA:";
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
            // txtIdCompra
            // 
            txtIdCompra.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCompra.Location = new Point(176, 38);
            txtIdCompra.Name = "txtIdCompra";
            txtIdCompra.Size = new Size(358, 22);
            txtIdCompra.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(107, 73);
            Label2.Name = "Label2";
            Label2.Size = new Size(61, 16);
            Label2.TabIndex = 53;
            Label2.Text = "FECHA:";
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
            // txtFecha
            // 
            txtFecha.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.Location = new Point(176, 73);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(358, 22);
            txtFecha.TabIndex = 2;
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
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubtotal.Location = new Point(176, 147);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(358, 22);
            txtSubtotal.TabIndex = 4;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(86, 187);
            Label5.Name = "Label5";
            Label5.Size = new Size(82, 16);
            Label5.TabIndex = 59;
            Label5.Text = "ESTATUS:";
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(176, 184);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 5;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(176, 258);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 7;
            txtIdCrear.UseSystemPasswordChar = true;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(133, 110);
            Label6.Name = "Label6";
            Label6.Size = new Size(35, 16);
            Label6.TabIndex = 61;
            Label6.Text = "IVA:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(43, 226);
            Label7.Name = "Label7";
            Label7.Size = new Size(125, 16);
            Label7.TabIndex = 63;
            Label7.Text = "ID PROVEEDOR:";
            // 
            // MenuStrip1
            // 
            MenuStrip1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { DetalleComprasToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(694, 29);
            MenuStrip1.TabIndex = 92;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // DetalleComprasToolStripMenuItem
            // 
            DetalleComprasToolStripMenuItem.Name = "DetalleComprasToolStripMenuItem";
            DetalleComprasToolStripMenuItem.Size = new Size(142, 25);
            DetalleComprasToolStripMenuItem.Text = "Detalle Compras";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 581);
            Controls.Add(dgvCompras);
            Controls.Add(GroupBox1);
            Controls.Add(MenuStrip1);
            MainMenuStrip = MenuStrip1;
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            Load += new EventHandler(Compras_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView dgvCompras;
        internal GroupBox GroupBox1;
        internal Label Label9;
        internal TextBox txtIdProveedor;
        internal Label Label10;
        internal TextBox txtIdModificar;
        internal Label Label3;
        internal TextBox txtIVA;
        internal Button btnLimpiar;
        internal Label Label1;
        internal Button btnBuscar;
        internal TextBox txtIdCompra;
        internal Label Label2;
        internal Button btnEliminar;
        internal Button btnEditar;
        internal TextBox txtFecha;
        internal Button btnAñadir;
        internal TextBox txtSubtotal;
        internal Label Label5;
        internal TextBox txtEstatus;
        internal TextBox txtIdCrear;
        internal Label Label6;
        internal Label Label7;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem DetalleComprasToolStripMenuItem;
    }
}