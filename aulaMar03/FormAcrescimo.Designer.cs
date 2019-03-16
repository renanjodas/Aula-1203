namespace aulaMar03
{
	partial class FormAcrescimo
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
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtAcrescimo = new System.Windows.Forms.TextBox();
			this.lblAcrescimo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(39, 54);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 20);
			this.txtNumero.TabIndex = 0;
			// 
			// txtResultado
			// 
			this.txtResultado.BackColor = System.Drawing.Color.Yellow;
			this.txtResultado.Location = new System.Drawing.Point(199, 54);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.ReadOnly = true;
			this.txtResultado.Size = new System.Drawing.Size(100, 20);
			this.txtResultado.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(199, 102);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(100, 23);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(39, 35);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(50, 13);
			this.lblNumero.TabIndex = 4;
			this.lblNumero.Text = "Número";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(196, 35);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(68, 13);
			this.lblResultado.TabIndex = 6;
			this.lblResultado.Text = "Resultado:";
			// 
			// txtAcrescimo
			// 
			this.txtAcrescimo.Location = new System.Drawing.Point(39, 105);
			this.txtAcrescimo.Name = "txtAcrescimo";
			this.txtAcrescimo.Size = new System.Drawing.Size(100, 20);
			this.txtAcrescimo.TabIndex = 7;
			// 
			// lblAcrescimo
			// 
			this.lblAcrescimo.AutoSize = true;
			this.lblAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcrescimo.Location = new System.Drawing.Point(36, 89);
			this.lblAcrescimo.Name = "lblAcrescimo";
			this.lblAcrescimo.Size = new System.Drawing.Size(86, 13);
			this.lblAcrescimo.TabIndex = 8;
			this.lblAcrescimo.Text = "Acréscimo (%)";
			// 
			// FormAcrescimo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 160);
			this.Controls.Add(this.lblAcrescimo);
			this.Controls.Add(this.txtAcrescimo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtNumero);
			this.Name = "FormAcrescimo";
			this.Text = "FormAcrescimo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtAcrescimo;
		private System.Windows.Forms.Label lblAcrescimo;
	}
}