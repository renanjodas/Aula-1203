namespace aulaMar03
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnDesconto = new System.Windows.Forms.Button();
			this.btnAcrescimo = new System.Windows.Forms.Button();
			this.btnCalculadora = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDesconto
			// 
			this.btnDesconto.Image = global::aulaMar03.Properties.Resources.iconfinder_minus_1814110;
			this.btnDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDesconto.Location = new System.Drawing.Point(220, 183);
			this.btnDesconto.Name = "btnDesconto";
			this.btnDesconto.Size = new System.Drawing.Size(97, 58);
			this.btnDesconto.TabIndex = 3;
			this.btnDesconto.Text = "Desconto";
			this.btnDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDesconto.UseVisualStyleBackColor = true;
			this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
			// 
			// btnAcrescimo
			// 
			this.btnAcrescimo.Image = global::aulaMar03.Properties.Resources.iconfinder_free_10_463016;
			this.btnAcrescimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAcrescimo.Location = new System.Drawing.Point(90, 183);
			this.btnAcrescimo.Name = "btnAcrescimo";
			this.btnAcrescimo.Size = new System.Drawing.Size(97, 58);
			this.btnAcrescimo.TabIndex = 2;
			this.btnAcrescimo.Text = "Acréscimo";
			this.btnAcrescimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAcrescimo.UseVisualStyleBackColor = true;
			this.btnAcrescimo.Click += new System.EventHandler(this.btnAcrescimo_Click);
			// 
			// btnCalculadora
			// 
			this.btnCalculadora.Image = global::aulaMar03.Properties.Resources.iconfinder_calculator_3131957;
			this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCalculadora.Location = new System.Drawing.Point(220, 99);
			this.btnCalculadora.Name = "btnCalculadora";
			this.btnCalculadora.Size = new System.Drawing.Size(97, 58);
			this.btnCalculadora.TabIndex = 1;
			this.btnCalculadora.Text = "Calculadora";
			this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCalculadora.UseVisualStyleBackColor = true;
			this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
			// 
			// button1
			// 
			this.button1.Image = global::aulaMar03.Properties.Resources.iconfinder_simpline_43_2305619__1_;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(89, 99);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 58);
			this.button1.TabIndex = 0;
			this.button1.Text = "Abrir Form2";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 344);
			this.Controls.Add(this.btnDesconto);
			this.Controls.Add(this.btnAcrescimo);
			this.Controls.Add(this.btnCalculadora);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCalculadora;
		private System.Windows.Forms.Button btnAcrescimo;
		private System.Windows.Forms.Button btnDesconto;
	}
}

