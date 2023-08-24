namespace Ejercicio1
{
    partial class FRM_Calculadora2
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
            this.LB_Resultado = new System.Windows.Forms.Label();
            this.LB_N1 = new System.Windows.Forms.Label();
            this.LB_N2 = new System.Windows.Forms.Label();
            this.TB_N2 = new System.Windows.Forms.TextBox();
            this.TB_N1 = new System.Windows.Forms.TextBox();
            this.BTT_MULTI = new System.Windows.Forms.Button();
            this.BTT_RESTA = new System.Windows.Forms.Button();
            this.BTT_DIVICION = new System.Windows.Forms.Button();
            this.BTT_SUMA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Resultado
            // 
            this.LB_Resultado.AutoSize = true;
            this.LB_Resultado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Resultado.Location = new System.Drawing.Point(150, 216);
            this.LB_Resultado.Name = "LB_Resultado";
            this.LB_Resultado.Size = new System.Drawing.Size(77, 22);
            this.LB_Resultado.TabIndex = 17;
            this.LB_Resultado.Text = "Resultado";
            // 
            // LB_N1
            // 
            this.LB_N1.AutoSize = true;
            this.LB_N1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_N1.Location = new System.Drawing.Point(92, 48);
            this.LB_N1.Name = "LB_N1";
            this.LB_N1.Size = new System.Drawing.Size(78, 22);
            this.LB_N1.TabIndex = 16;
            this.LB_N1.Text = "Numero 1";
            // 
            // LB_N2
            // 
            this.LB_N2.AutoSize = true;
            this.LB_N2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_N2.Location = new System.Drawing.Point(214, 48);
            this.LB_N2.Name = "LB_N2";
            this.LB_N2.Size = new System.Drawing.Size(78, 22);
            this.LB_N2.TabIndex = 15;
            this.LB_N2.Text = "Numero 2";
            // 
            // TB_N2
            // 
            this.TB_N2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_N2.Location = new System.Drawing.Point(201, 73);
            this.TB_N2.Name = "TB_N2";
            this.TB_N2.Size = new System.Drawing.Size(100, 26);
            this.TB_N2.TabIndex = 14;
            // 
            // TB_N1
            // 
            this.TB_N1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_N1.Location = new System.Drawing.Point(82, 73);
            this.TB_N1.Name = "TB_N1";
            this.TB_N1.Size = new System.Drawing.Size(100, 26);
            this.TB_N1.TabIndex = 13;
            // 
            // BTT_MULTI
            // 
            this.BTT_MULTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BTT_MULTI.Location = new System.Drawing.Point(96, 154);
            this.BTT_MULTI.Name = "BTT_MULTI";
            this.BTT_MULTI.Size = new System.Drawing.Size(75, 38);
            this.BTT_MULTI.TabIndex = 12;
            this.BTT_MULTI.Text = "X";
            this.BTT_MULTI.UseVisualStyleBackColor = true;
            this.BTT_MULTI.Click += new System.EventHandler(this.BTT_MULTI_Click);
            // 
            // BTT_RESTA
            // 
            this.BTT_RESTA.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTT_RESTA.Location = new System.Drawing.Point(199, 112);
            this.BTT_RESTA.Name = "BTT_RESTA";
            this.BTT_RESTA.Size = new System.Drawing.Size(75, 38);
            this.BTT_RESTA.TabIndex = 11;
            this.BTT_RESTA.Text = "-";
            this.BTT_RESTA.UseVisualStyleBackColor = true;
            this.BTT_RESTA.Click += new System.EventHandler(this.BTT_RESTA_Click);
            // 
            // BTT_DIVICION
            // 
            this.BTT_DIVICION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BTT_DIVICION.Location = new System.Drawing.Point(199, 154);
            this.BTT_DIVICION.Name = "BTT_DIVICION";
            this.BTT_DIVICION.Size = new System.Drawing.Size(75, 38);
            this.BTT_DIVICION.TabIndex = 10;
            this.BTT_DIVICION.Text = "/";
            this.BTT_DIVICION.UseVisualStyleBackColor = true;
            this.BTT_DIVICION.Click += new System.EventHandler(this.BTT_DIVICION_Click);
            // 
            // BTT_SUMA
            // 
            this.BTT_SUMA.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTT_SUMA.Location = new System.Drawing.Point(96, 112);
            this.BTT_SUMA.Name = "BTT_SUMA";
            this.BTT_SUMA.Size = new System.Drawing.Size(75, 38);
            this.BTT_SUMA.TabIndex = 9;
            this.BTT_SUMA.Text = "+";
            this.BTT_SUMA.UseVisualStyleBackColor = true;
            this.BTT_SUMA.Click += new System.EventHandler(this.BTT_SUMA_Click);
            // 
            // FRM_Calculadora2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 289);
            this.Controls.Add(this.LB_Resultado);
            this.Controls.Add(this.LB_N1);
            this.Controls.Add(this.LB_N2);
            this.Controls.Add(this.TB_N2);
            this.Controls.Add(this.TB_N1);
            this.Controls.Add(this.BTT_MULTI);
            this.Controls.Add(this.BTT_RESTA);
            this.Controls.Add(this.BTT_DIVICION);
            this.Controls.Add(this.BTT_SUMA);
            this.Name = "FRM_Calculadora2";
            this.Text = "FRM_Calculadora2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Resultado;
        private System.Windows.Forms.Label LB_N1;
        private System.Windows.Forms.Label LB_N2;
        private System.Windows.Forms.TextBox TB_N2;
        private System.Windows.Forms.TextBox TB_N1;
        private System.Windows.Forms.Button BTT_MULTI;
        private System.Windows.Forms.Button BTT_RESTA;
        private System.Windows.Forms.Button BTT_DIVICION;
        private System.Windows.Forms.Button BTT_SUMA;
    }
}