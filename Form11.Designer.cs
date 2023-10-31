namespace pjConexionClase
{
    partial class frmMantenimientoContratista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoContratista));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNuevo1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsGrabar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsModificar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsEliminar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsSalir1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgMantContratistas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMantContratistas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo1,
            this.toolStripLabel1,
            this.tsGrabar1,
            this.toolStripLabel2,
            this.tsModificar1,
            this.toolStripLabel3,
            this.tsEliminar1,
            this.toolStripLabel4,
            this.tsSalir1,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNuevo1
            // 
            this.tsNuevo1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNuevo1.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo1.Image")));
            this.tsNuevo1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo1.Name = "tsNuevo1";
            this.tsNuevo1.Size = new System.Drawing.Size(29, 24);
            this.tsNuevo1.Text = "toolStripButton1";
            this.tsNuevo1.ToolTipText = "Nuevo registro";
            this.tsNuevo1.Click += new System.EventHandler(this.tsNuevo1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 24);
            this.toolStripLabel1.Text = "Nuevo";
            // 
            // tsGrabar1
            // 
            this.tsGrabar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGrabar1.Image = ((System.Drawing.Image)(resources.GetObject("tsGrabar1.Image")));
            this.tsGrabar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGrabar1.Name = "tsGrabar1";
            this.tsGrabar1.Size = new System.Drawing.Size(29, 24);
            this.tsGrabar1.Text = "toolStripButton2";
            this.tsGrabar1.ToolTipText = "Grabar registro";
            this.tsGrabar1.Click += new System.EventHandler(this.tsGrabar1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel2.Text = "Grabar";
            // 
            // tsModificar1
            // 
            this.tsModificar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsModificar1.Image = ((System.Drawing.Image)(resources.GetObject("tsModificar1.Image")));
            this.tsModificar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsModificar1.Name = "tsModificar1";
            this.tsModificar1.Size = new System.Drawing.Size(29, 24);
            this.tsModificar1.Text = "toolStripButton3";
            this.tsModificar1.ToolTipText = "Modificar registro";
            this.tsModificar1.Click += new System.EventHandler(this.tsModificar1_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 24);
            this.toolStripLabel3.Text = "Modificar";
            // 
            // tsEliminar1
            // 
            this.tsEliminar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar1.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar1.Image")));
            this.tsEliminar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar1.Name = "tsEliminar1";
            this.tsEliminar1.Size = new System.Drawing.Size(29, 24);
            this.tsEliminar1.Text = "toolStripButton4";
            this.tsEliminar1.ToolTipText = "Eliminar registro";
            this.tsEliminar1.Click += new System.EventHandler(this.tsEliminar1_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(63, 24);
            this.toolStripLabel4.Text = "Eliminar";
            // 
            // tsSalir1
            // 
            this.tsSalir1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSalir1.Image = ((System.Drawing.Image)(resources.GetObject("tsSalir1.Image")));
            this.tsSalir1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalir1.Name = "tsSalir1";
            this.tsSalir1.Size = new System.Drawing.Size(29, 24);
            this.tsSalir1.Text = "toolStripButton5";
            this.tsSalir1.ToolTipText = "salir";
            this.tsSalir1.Click += new System.EventHandler(this.tsSalir1_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(38, 24);
            this.toolStripLabel5.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "N° Telefono / Cel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email/Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 162);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 25);
            this.txtNombre.TabIndex = 8;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo1.Location = new System.Drawing.Point(169, 100);
            this.lblCodigo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(95, 20);
            this.lblCodigo1.TabIndex = 9;
            this.lblCodigo1.Text = "LABEL1";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(169, 241);
            this.txtApePaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(221, 25);
            this.txtApePaterno.TabIndex = 10;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(169, 314);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(221, 25);
            this.txtApeMaterno.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(604, 162);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(137, 25);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(604, 241);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 25);
            this.txtEmail.TabIndex = 13;
            // 
            // dgMantContratistas
            // 
            this.dgMantContratistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMantContratistas.Location = new System.Drawing.Point(29, 378);
            this.dgMantContratistas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMantContratistas.Name = "dgMantContratistas";
            this.dgMantContratistas.RowHeadersWidth = 51;
            this.dgMantContratistas.RowTemplate.Height = 24;
            this.dgMantContratistas.Size = new System.Drawing.Size(822, 345);
            this.dgMantContratistas.TabIndex = 14;
            this.dgMantContratistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMantContratistas_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(524, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "MANTENIMIENTO DE CONTRATISTAS";
            // 
            // frmMantenimientoContratista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 738);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgMantContratistas);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.lblCodigo1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMantenimientoContratista";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMantContratistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevo1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsGrabar1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsModificar1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsEliminar1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton tsSalir1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgMantContratistas;
        private System.Windows.Forms.Label label7;
    }
}