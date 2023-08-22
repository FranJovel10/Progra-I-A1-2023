
namespace ConversorDeMonedasFran
{
    partial class Form1
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
            this.cboaconversores = new System.Windows.Forms.ComboBox();
            this.cbodeconversores = new System.Windows.Forms.ComboBox();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.txtcantidadcoversores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboaconversores
            // 
            this.cboaconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaconversores.FormattingEnabled = true;
            this.cboaconversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Cordoba",
            "Colon SV",
            "Colon CR",
            "Yenes",
            "Rupias India",
            "Libras Esterlinas"});
            this.cboaconversores.Location = new System.Drawing.Point(211, 132);
            this.cboaconversores.Name = "cboaconversores";
            this.cboaconversores.Size = new System.Drawing.Size(121, 21);
            this.cboaconversores.TabIndex = 14;
            // 
            // cbodeconversores
            // 
            this.cbodeconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeconversores.FormattingEnabled = true;
            this.cbodeconversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Cordoba",
            "Colon SV",
            "Colon CR",
            "Yenes",
            "Rupias India",
            "Libras Esterlinas"});
            this.cbodeconversores.Location = new System.Drawing.Point(211, 79);
            this.cbodeconversores.Name = "cbodeconversores";
            this.cbodeconversores.Size = new System.Drawing.Size(121, 21);
            this.cbodeconversores.TabIndex = 13;
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(115, 207);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(89, 18);
            this.lblRespuestaConversores.TabIndex = 12;
            this.lblRespuestaConversores.Text = "Cantidad: ?";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(145, 131);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(23, 18);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "A:";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.Location = new System.Drawing.Point(133, 78);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(35, 18);
            this.lblDE.TabIndex = 10;
            this.lblDE.Text = "DE:";
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(305, 185);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(140, 61);
            this.btnConvertirConversores.TabIndex = 9;
            this.btnConvertirConversores.Text = "CONVERTIR";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click);
            // 
            // txtcantidadcoversores
            // 
            this.txtcantidadcoversores.Location = new System.Drawing.Point(136, 255);
            this.txtcantidadcoversores.Name = "txtcantidadcoversores";
            this.txtcantidadcoversores.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadcoversores.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboaconversores);
            this.Controls.Add(this.cbodeconversores);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.btnConvertirConversores);
            this.Controls.Add(this.txtcantidadcoversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboaconversores;
        private System.Windows.Forms.ComboBox cbodeconversores;
        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnConvertirConversores;
        private System.Windows.Forms.TextBox txtcantidadcoversores;
    }
}

