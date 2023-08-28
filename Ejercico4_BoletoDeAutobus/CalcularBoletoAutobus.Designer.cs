namespace Ejercico3_BoletoDeAutobus
{
    partial class CalcularBoletoAutobus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcularBoletoAutobus));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.TXT_Asiento = new System.Windows.Forms.TextBox();
            this.TXT_Edad = new System.Windows.Forms.TextBox();
            this.CBX_Origen = new System.Windows.Forms.ComboBox();
            this.CBX_Destino = new System.Windows.Forms.ComboBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TXT_Costo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBX_TIPO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CHB_Alimentos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Asiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Origen";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(84, 42);
            this.TXT_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(473, 25);
            this.TXT_Nombre.TabIndex = 5;
            this.TXT_Nombre.Text = "Maria Garcia Romero";
            // 
            // TXT_Asiento
            // 
            this.TXT_Asiento.Location = new System.Drawing.Point(122, 117);
            this.TXT_Asiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Asiento.Name = "TXT_Asiento";
            this.TXT_Asiento.Size = new System.Drawing.Size(121, 25);
            this.TXT_Asiento.TabIndex = 7;
            this.TXT_Asiento.Text = "33";
            // 
            // TXT_Edad
            // 
            this.TXT_Edad.Location = new System.Drawing.Point(122, 77);
            this.TXT_Edad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Edad.MaxLength = 3;
            this.TXT_Edad.Name = "TXT_Edad";
            this.TXT_Edad.Size = new System.Drawing.Size(121, 25);
            this.TXT_Edad.TabIndex = 8;
            this.TXT_Edad.Text = "20";
            // 
            // CBX_Origen
            // 
            this.CBX_Origen.FormattingEnabled = true;
            this.CBX_Origen.Items.AddRange(new object[] {
            "Hermosillo",
            "Guadalajara",
            "H. Nogales",
            "Monterey"});
            this.CBX_Origen.Location = new System.Drawing.Point(84, 155);
            this.CBX_Origen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBX_Origen.Name = "CBX_Origen";
            this.CBX_Origen.Size = new System.Drawing.Size(160, 28);
            this.CBX_Origen.TabIndex = 9;
            // 
            // CBX_Destino
            // 
            this.CBX_Destino.FormattingEnabled = true;
            this.CBX_Destino.Items.AddRange(new object[] {
            "Hermosillo",
            "Guadalajara",
            "H. Nogales",
            "Monterey",
            "Culiacan"});
            this.CBX_Destino.Location = new System.Drawing.Point(84, 197);
            this.CBX_Destino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBX_Destino.Name = "CBX_Destino";
            this.CBX_Destino.Size = new System.Drawing.Size(160, 28);
            this.CBX_Destino.TabIndex = 10;
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Calcular.Location = new System.Drawing.Point(328, 288);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(158, 33);
            this.Calcular.TabIndex = 11;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(262, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 153);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // TXT_Costo
            // 
            this.TXT_Costo.Location = new System.Drawing.Point(123, 274);
            this.TXT_Costo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Costo.Name = "TXT_Costo";
            this.TXT_Costo.Size = new System.Drawing.Size(121, 25);
            this.TXT_Costo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Costo Boleto:";
            // 
            // CBX_TIPO
            // 
            this.CBX_TIPO.FormattingEnabled = true;
            this.CBX_TIPO.Items.AddRange(new object[] {
            "Normal",
            "Maestro",
            "Estudiante"});
            this.CBX_TIPO.Location = new System.Drawing.Point(83, 236);
            this.CBX_TIPO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBX_TIPO.Name = "CBX_TIPO";
            this.CBX_TIPO.Size = new System.Drawing.Size(160, 28);
            this.CBX_TIPO.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo: ";
            // 
            // CHB_Alimentos
            // 
            this.CHB_Alimentos.AutoSize = true;
            this.CHB_Alimentos.Location = new System.Drawing.Point(84, 346);
            this.CHB_Alimentos.Name = "CHB_Alimentos";
            this.CHB_Alimentos.Size = new System.Drawing.Size(142, 24);
            this.CHB_Alimentos.TabIndex = 17;
            this.CHB_Alimentos.Text = "Incluye alimentos";
            this.CHB_Alimentos.UseVisualStyleBackColor = true;
            // 
            // CalcularBoletoAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 402);
            this.Controls.Add(this.CHB_Alimentos);
            this.Controls.Add(this.CBX_TIPO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXT_Costo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.CBX_Destino);
            this.Controls.Add(this.CBX_Origen);
            this.Controls.Add(this.TXT_Edad);
            this.Controls.Add(this.TXT_Asiento);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalcularBoletoAutobus";
            this.Text = "Calcular boletos de Aubus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.TextBox TXT_Asiento;
        private System.Windows.Forms.TextBox TXT_Edad;
        private System.Windows.Forms.ComboBox CBX_Origen;
        private System.Windows.Forms.ComboBox CBX_Destino;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TXT_Costo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBX_TIPO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CHB_Alimentos;
    }
}

