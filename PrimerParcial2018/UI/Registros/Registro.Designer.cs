namespace PrimerParcial2018.UI.Registros
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.VendedornumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SueldonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PorRetencionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VendedoreserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RetencionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.VendedornumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorRetencionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendedoreserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(305, 342);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 86);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(161, 342);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 86);
            this.Guardarbutton.TabIndex = 10;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(16, 342);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 86);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(243, 25);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 63);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // VendedornumericUpDown
            // 
            this.VendedornumericUpDown.Location = new System.Drawing.Point(103, 46);
            this.VendedornumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VendedornumericUpDown.Name = "VendedornumericUpDown";
            this.VendedornumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.VendedornumericUpDown.TabIndex = 12;
            this.VendedornumericUpDown.ValueChanged += new System.EventHandler(this.VendedornumericUpDown_ValueChanged);
            // 
            // SueldonumericUpDown
            // 
            this.SueldonumericUpDown.DecimalPlaces = 2;
            this.SueldonumericUpDown.Location = new System.Drawing.Point(80, 222);
            this.SueldonumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SueldonumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.SueldonumericUpDown.Name = "SueldonumericUpDown";
            this.SueldonumericUpDown.Size = new System.Drawing.Size(299, 22);
            this.SueldonumericUpDown.TabIndex = 13;
            this.SueldonumericUpDown.ValueChanged += new System.EventHandler(this.SueldonumericUpDown_ValueChanged);
            // 
            // PorRetencionnumericUpDown
            // 
            this.PorRetencionnumericUpDown.DecimalPlaces = 2;
            this.PorRetencionnumericUpDown.Location = new System.Drawing.Point(293, 247);
            this.PorRetencionnumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PorRetencionnumericUpDown.Name = "PorRetencionnumericUpDown";
            this.PorRetencionnumericUpDown.Size = new System.Drawing.Size(87, 22);
            this.PorRetencionnumericUpDown.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "% Retencion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Retencion";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(92, 121);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NombretextBox.Multiline = true;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(213, 48);
            this.NombretextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre";
            // 
            // VendedoreserrorProvider
            // 
            this.VendedoreserrorProvider.ContainerControl = this;
            // 
            // RetencionnumericUpDown
            // 
            this.RetencionnumericUpDown.DecimalPlaces = 2;
            this.RetencionnumericUpDown.Location = new System.Drawing.Point(103, 279);
            this.RetencionnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.RetencionnumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.RetencionnumericUpDown.Name = "RetencionnumericUpDown";
            this.RetencionnumericUpDown.ReadOnly = true;
            this.RetencionnumericUpDown.Size = new System.Drawing.Size(276, 22);
            this.RetencionnumericUpDown.TabIndex = 14;
            this.RetencionnumericUpDown.ValueChanged += new System.EventHandler(this.RetencionnumericUpDown_ValueChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PorRetencionnumericUpDown);
            this.Controls.Add(this.RetencionnumericUpDown);
            this.Controls.Add(this.SueldonumericUpDown);
            this.Controls.Add(this.VendedornumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VendedornumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorRetencionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendedoreserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown VendedornumericUpDown;
        private System.Windows.Forms.NumericUpDown SueldonumericUpDown;
        private System.Windows.Forms.NumericUpDown PorRetencionnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider VendedoreserrorProvider;
        private System.Windows.Forms.NumericUpDown RetencionnumericUpDown;
    }
}