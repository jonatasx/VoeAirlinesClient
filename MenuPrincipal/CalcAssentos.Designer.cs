namespace MenuPrincipal
{
    partial class CalcAssentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcAssentos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdeAssentos = new System.Windows.Forms.TextBox();
            this.btnCalcularCat = new System.Windows.Forms.Button();
            this.lblResultAssento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Assentos";
            // 
            // txtQtdeAssentos
            // 
            this.txtQtdeAssentos.Location = new System.Drawing.Point(49, 50);
            this.txtQtdeAssentos.Name = "txtQtdeAssentos";
            this.txtQtdeAssentos.Size = new System.Drawing.Size(394, 20);
            this.txtQtdeAssentos.TabIndex = 1;
            // 
            // btnCalcularCat
            // 
            this.btnCalcularCat.Location = new System.Drawing.Point(49, 98);
            this.btnCalcularCat.Name = "btnCalcularCat";
            this.btnCalcularCat.Size = new System.Drawing.Size(394, 23);
            this.btnCalcularCat.TabIndex = 2;
            this.btnCalcularCat.Text = "Mostrar Categoria";
            this.btnCalcularCat.UseVisualStyleBackColor = true;
            this.btnCalcularCat.Click += new System.EventHandler(this.btnCalcularCat_Click);
            // 
            // lblResultAssento
            // 
            this.lblResultAssento.AutoSize = true;
            this.lblResultAssento.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultAssento.ForeColor = System.Drawing.Color.Red;
            this.lblResultAssento.Location = new System.Drawing.Point(81, 134);
            this.lblResultAssento.Name = "lblResultAssento";
            this.lblResultAssento.Size = new System.Drawing.Size(0, 30);
            this.lblResultAssento.TabIndex = 3;
            // 
            // CalcAssentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 183);
            this.Controls.Add(this.lblResultAssento);
            this.Controls.Add(this.btnCalcularCat);
            this.Controls.Add(this.txtQtdeAssentos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcAssentos";
            this.Text = "CalcAssentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdeAssentos;
        private System.Windows.Forms.Button btnCalcularCat;
        private System.Windows.Forms.Label lblResultAssento;
    }
}