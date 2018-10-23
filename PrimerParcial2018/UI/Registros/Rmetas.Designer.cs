namespace PrimerParcial2018.UI.Registros
{
    partial class Rmetas
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
            this.MetasnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionmetastextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.CuotanumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MetasnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MetasnumericUpDown
            // 
            this.MetasnumericUpDown.Location = new System.Drawing.Point(81, 12);
            this.MetasnumericUpDown.Name = "MetasnumericUpDown";
            this.MetasnumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.MetasnumericUpDown.TabIndex = 0;
            // 
            // DescripcionmetastextBox
            // 
            this.DescripcionmetastextBox.Location = new System.Drawing.Point(81, 45);
            this.DescripcionmetastextBox.Multiline = true;
            this.DescripcionmetastextBox.Name = "DescripcionmetastextBox";
            this.DescripcionmetastextBox.Size = new System.Drawing.Size(213, 32);
            this.DescripcionmetastextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuota";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(118, 156);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 60);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // CuotanumericUpDown
            // 
            this.CuotanumericUpDown.Location = new System.Drawing.Point(81, 106);
            this.CuotanumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.CuotanumericUpDown.Name = "CuotanumericUpDown";
            this.CuotanumericUpDown.Size = new System.Drawing.Size(213, 20);
            this.CuotanumericUpDown.TabIndex = 7;
            // 
            // Rmetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 252);
            this.Controls.Add(this.CuotanumericUpDown);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripcionmetastextBox);
            this.Controls.Add(this.MetasnumericUpDown);
            this.Name = "Rmetas";
            this.Text = "Rmetas";
            ((System.ComponentModel.ISupportInitialize)(this.MetasnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotanumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MetasnumericUpDown;
        private System.Windows.Forms.TextBox DescripcionmetastextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.NumericUpDown CuotanumericUpDown;
    }
}