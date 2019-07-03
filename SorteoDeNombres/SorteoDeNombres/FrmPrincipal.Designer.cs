namespace SorteoDeNombres
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreGanador = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAgregarNombre = new System.Windows.Forms.Label();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.lblNombresAgregados = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbxTombola = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.gbxTombola.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreGanador
            // 
            this.lblNombreGanador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreGanador.AutoSize = true;
            this.lblNombreGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGanador.Location = new System.Drawing.Point(101, 94);
            this.lblNombreGanador.Name = "lblNombreGanador";
            this.lblNombreGanador.Size = new System.Drawing.Size(145, 46);
            this.lblNombreGanador.TabIndex = 0;
            this.lblNombreGanador.Text = "Sorteo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(490, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(378, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblAgregarNombre
            // 
            this.lblAgregarNombre.AutoSize = true;
            this.lblAgregarNombre.Location = new System.Drawing.Point(12, 17);
            this.lblAgregarNombre.Name = "lblAgregarNombre";
            this.lblAgregarNombre.Size = new System.Drawing.Size(85, 13);
            this.lblAgregarNombre.TabIndex = 3;
            this.lblAgregarNombre.Text = "Agregar nombre:";
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.Location = new System.Drawing.Point(15, 72);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(214, 264);
            this.listBoxNombres.TabIndex = 4;
            // 
            // lblNombresAgregados
            // 
            this.lblNombresAgregados.AutoSize = true;
            this.lblNombresAgregados.Location = new System.Drawing.Point(12, 56);
            this.lblNombresAgregados.Name = "lblNombresAgregados";
            this.lblNombresAgregados.Size = new System.Drawing.Size(102, 13);
            this.lblNombresAgregados.TabIndex = 5;
            this.lblNombresAgregados.Text = "Nombres agregados";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(154, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbxTombola
            // 
            this.gbxTombola.Controls.Add(this.lblNombreGanador);
            this.gbxTombola.Location = new System.Drawing.Point(235, 72);
            this.gbxTombola.Name = "gbxTombola";
            this.gbxTombola.Size = new System.Drawing.Size(330, 241);
            this.gbxTombola.TabIndex = 7;
            this.gbxTombola.TabStop = false;
            this.gbxTombola.Text = "Tombola";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(235, 319);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(490, 319);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 9;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(421, 49);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 10;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(500, 49);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(65, 17);
            this.rbRandom.TabIndex = 11;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 352);
            this.Controls.Add(this.rbRandom);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.gbxTombola);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNombresAgregados);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.lblAgregarNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Sorteo";
            this.gbxTombola.ResumeLayout(false);
            this.gbxTombola.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreGanador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAgregarNombre;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.Label lblNombresAgregados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbxTombola;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbRandom;
    }
}

