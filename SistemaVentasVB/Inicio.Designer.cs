using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Inicio : Form
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
            MSinicio = new MenuStrip();
            VentasToolStripMenuItem = new ToolStripMenuItem();
            VentasToolStripMenuItem.Click += new EventHandler(VentasToolStripMenuItem_Click);
            ComprasToolStripMenuItem = new ToolStripMenuItem();
            ComprasToolStripMenuItem.Click += new EventHandler(ComprasToolStripMenuItem_Click);
            ProductosToolStripMenuItem = new ToolStripMenuItem();
            ProductosToolStripMenuItem.Click += new EventHandler(ProductosToolStripMenuItem_Click);
            ClientesToolStripMenuItem = new ToolStripMenuItem();
            ClientesToolStripMenuItem.Click += new EventHandler(ClientesToolStripMenuItem_Click);
            ProveedoresToolStripMenuItem = new ToolStripMenuItem();
            ProveedoresToolStripMenuItem.Click += new EventHandler(ProveedoresToolStripMenuItem_Click);
            UsuariosToolStripMenuItem = new ToolStripMenuItem();
            UsuariosToolStripMenuItem.Click += new EventHandler(UsuariosToolStripMenuItem_Click);
            PictureBox1 = new PictureBox();
            MSinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MSinicio
            // 
            MSinicio.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSinicio.Items.AddRange(new ToolStripItem[] { VentasToolStripMenuItem, ComprasToolStripMenuItem, ProductosToolStripMenuItem, ClientesToolStripMenuItem, ProveedoresToolStripMenuItem, UsuariosToolStripMenuItem });
            MSinicio.LayoutStyle = ToolStripLayoutStyle.Flow;
            MSinicio.Location = new Point(0, 0);
            MSinicio.Name = "MSinicio";
            MSinicio.Size = new Size(800, 29);
            MSinicio.TabIndex = 0;
            MSinicio.Text = "MenuStrip1";
            // 
            // VentasToolStripMenuItem
            // 
            VentasToolStripMenuItem.Name = "VentasToolStripMenuItem";
            VentasToolStripMenuItem.Size = new Size(70, 25);
            VentasToolStripMenuItem.Text = "Ventas";
            // 
            // ComprasToolStripMenuItem
            // 
            ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem";
            ComprasToolStripMenuItem.Size = new Size(87, 25);
            ComprasToolStripMenuItem.Text = "Compras";
            // 
            // ProductosToolStripMenuItem
            // 
            ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            ProductosToolStripMenuItem.Size = new Size(97, 25);
            ProductosToolStripMenuItem.Text = "Productos";
            // 
            // ClientesToolStripMenuItem
            // 
            ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            ClientesToolStripMenuItem.Size = new Size(80, 25);
            ClientesToolStripMenuItem.Text = "Clientes";
            // 
            // ProveedoresToolStripMenuItem
            // 
            ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem";
            ProveedoresToolStripMenuItem.Size = new Size(115, 25);
            ProveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // UsuariosToolStripMenuItem
            // 
            UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            UsuariosToolStripMenuItem.Size = new Size(84, 25);
            UsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.CR_logo;
            PictureBox1.Location = new Point(61, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(664, 443);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(MSinicio);
            Controls.Add(PictureBox1);
            MainMenuStrip = MSinicio;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            MSinicio.ResumeLayout(false);
            MSinicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Inicio_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal MenuStrip MSinicio;
        internal ToolStripMenuItem VentasToolStripMenuItem;
        internal ToolStripMenuItem ComprasToolStripMenuItem;
        internal ToolStripMenuItem ProductosToolStripMenuItem;
        internal ToolStripMenuItem ClientesToolStripMenuItem;
        internal ToolStripMenuItem ProveedoresToolStripMenuItem;
        internal ToolStripMenuItem UsuariosToolStripMenuItem;
        internal PictureBox PictureBox1;
    }
}