namespace aulaMar03
{
	partial class FormCalculadora
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
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnAdicao = new System.Windows.Forms.Button();
			this.btnSubtracao = new System.Windows.Forms.Button();
			this.btnDivisao = new System.Windows.Forms.Button();
			this.btnMultiplicacao = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumero1
			// 
			this.lblNumero1.AutoSize = true;
			this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero1.Location = new System.Drawing.Point(45, 77);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(62, 15);
			this.lblNumero1.TabIndex = 0;
			this.lblNumero1.Text = "Número 1";
			// 
			// lblNumero2
			// 
			this.lblNumero2.AutoSize = true;
			this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero2.Location = new System.Drawing.Point(192, 77);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(62, 15);
			this.lblNumero2.TabIndex = 1;
			this.lblNumero2.Text = "Número 2";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(336, 77);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(79, 16);
			this.lblResultado.TabIndex = 2;
			this.lblResultado.Text = "Resultado";
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(39, 96);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 20);
			this.txtNumero1.TabIndex = 3;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(195, 96);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 20);
			this.txtNumero2.TabIndex = 4;
			// 
			// txtResultado
			// 
			this.txtResultado.BackColor = System.Drawing.Color.Yellow;
			this.txtResultado.Location = new System.Drawing.Point(339, 96);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.ReadOnly = true;
			this.txtResultado.Size = new System.Drawing.Size(100, 20);
			this.txtResultado.TabIndex = 5;
			// 
			// btnAdicao
			// 
			this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdicao.Location = new System.Drawing.Point(39, 149);
			this.btnAdicao.Name = "btnAdicao";
			this.btnAdicao.Size = new System.Drawing.Size(75, 55);
			this.btnAdicao.TabIndex = 6;
			this.btnAdicao.Text = "+";
			this.btnAdicao.UseVisualStyleBackColor = true;
			this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
			// 
			// btnSubtracao
			// 
			this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubtracao.Location = new System.Drawing.Point(148, 149);
			this.btnSubtracao.Name = "btnSubtracao";
			this.btnSubtracao.Size = new System.Drawing.Size(75, 55);
			this.btnSubtracao.TabIndex = 7;
			this.btnSubtracao.Text = "-";
			this.btnSubtracao.UseVisualStyleBackColor = true;
			this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
			// 
			// btnDivisao
			// 
			this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDivisao.Location = new System.Drawing.Point(258, 149);
			this.btnDivisao.Name = "btnDivisao";
			this.btnDivisao.Size = new System.Drawing.Size(75, 55);
			this.btnDivisao.TabIndex = 8;
			this.btnDivisao.Text = "/";
			this.btnDivisao.UseVisualStyleBackColor = true;
			this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
			// 
			// btnMultiplicacao
			// 
			this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicacao.Location = new System.Drawing.Point(364, 149);
			this.btnMultiplicacao.Name = "btnMultiplicacao";
			this.btnMultiplicacao.Size = new System.Drawing.Size(75, 55);
			this.btnMultiplicacao.TabIndex = 9;
			this.btnMultiplicacao.Text = "x";
			this.btnMultiplicacao.UseVisualStyleBackColor = true;
			this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
			// 
			// FormCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 323);
			this.Controls.Add(this.btnMultiplicacao);
			this.Controls.Add(this.btnDivisao);
			this.Controls.Add(this.btnSubtracao);
			this.Controls.Add(this.btnAdicao);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.lblNumero1);
			this.Name = "FormCalculadora";
			this.Text = "FormCalculadora";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNumero1;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Button btnAdicao;
		private System.Windows.Forms.Button btnSubtracao;
		private System.Windows.Forms.Button btnDivisao;
		private System.Windows.Forms.Button btnMultiplicacao;
	}
}