namespace aulaMar03
{
	partial class FormDesconto
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
			this.txtValor = new System.Windows.Forms.TextBox();
			this.txtDesconto = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblValor = new System.Windows.Forms.Label();
			this.lblDesconto = new System.Windows.Forms.Label();
			this.gbFormaDesconto = new System.Windows.Forms.GroupBox();
			this.rbnValorDireto = new System.Windows.Forms.RadioButton();
			this.rbnPorcentagem = new System.Windows.Forms.RadioButton();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.gbFormaDesconto.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(48, 33);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 20);
			this.txtValor.TabIndex = 0;
			this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDesconto
			// 
			this.txtDesconto.Location = new System.Drawing.Point(169, 33);
			this.txtDesconto.Name = "txtDesconto";
			this.txtDesconto.Size = new System.Drawing.Size(100, 20);
			this.txtDesconto.TabIndex = 1;
			this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(194, 73);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 100);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(45, 17);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(31, 13);
			this.lblValor.TabIndex = 3;
			this.lblValor.Text = "Valor";
			// 
			// lblDesconto
			// 
			this.lblDesconto.AutoSize = true;
			this.lblDesconto.Location = new System.Drawing.Point(166, 17);
			this.lblDesconto.Name = "lblDesconto";
			this.lblDesconto.Size = new System.Drawing.Size(53, 13);
			this.lblDesconto.TabIndex = 4;
			this.lblDesconto.Text = "Desconto";
			// 
			// gbFormaDesconto
			// 
			this.gbFormaDesconto.Controls.Add(this.rbnValorDireto);
			this.gbFormaDesconto.Controls.Add(this.rbnPorcentagem);
			this.gbFormaDesconto.Location = new System.Drawing.Point(48, 73);
			this.gbFormaDesconto.Name = "gbFormaDesconto";
			this.gbFormaDesconto.Size = new System.Drawing.Size(126, 100);
			this.gbFormaDesconto.TabIndex = 5;
			this.gbFormaDesconto.TabStop = false;
			this.gbFormaDesconto.Text = "Forma Desconto";
			// 
			// rbnValorDireto
			// 
			this.rbnValorDireto.AutoSize = true;
			this.rbnValorDireto.Location = new System.Drawing.Point(7, 65);
			this.rbnValorDireto.Name = "rbnValorDireto";
			this.rbnValorDireto.Size = new System.Drawing.Size(80, 17);
			this.rbnValorDireto.TabIndex = 1;
			this.rbnValorDireto.TabStop = true;
			this.rbnValorDireto.Text = "Valor Direto";
			this.rbnValorDireto.UseVisualStyleBackColor = true;
			// 
			// rbnPorcentagem
			// 
			this.rbnPorcentagem.AutoSize = true;
			this.rbnPorcentagem.Location = new System.Drawing.Point(7, 29);
			this.rbnPorcentagem.Name = "rbnPorcentagem";
			this.rbnPorcentagem.Size = new System.Drawing.Size(105, 17);
			this.rbnPorcentagem.TabIndex = 0;
			this.rbnPorcentagem.TabStop = true;
			this.rbnPorcentagem.Text = "Porcentagem (%)";
			this.rbnPorcentagem.UseVisualStyleBackColor = true;
			// 
			// txtResultado
			// 
			this.txtResultado.BackColor = System.Drawing.Color.Yellow;
			this.txtResultado.Location = new System.Drawing.Point(112, 200);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.ReadOnly = true;
			this.txtResultado.Size = new System.Drawing.Size(90, 20);
			this.txtResultado.TabIndex = 6;
			this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(130, 184);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(55, 13);
			this.lblResultado.TabIndex = 7;
			this.lblResultado.Text = "Resultado";
			// 
			// FormDesconto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 244);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.gbFormaDesconto);
			this.Controls.Add(this.lblDesconto);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtDesconto);
			this.Controls.Add(this.txtValor);
			this.Name = "FormDesconto";
			this.Text = "FormDesconto";
			this.gbFormaDesconto.ResumeLayout(false);
			this.gbFormaDesconto.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.TextBox txtDesconto;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblDesconto;
		private System.Windows.Forms.GroupBox gbFormaDesconto;
		private System.Windows.Forms.RadioButton rbnValorDireto;
		private System.Windows.Forms.RadioButton rbnPorcentagem;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Label lblResultado;
	}
}