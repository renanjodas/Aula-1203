using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaMar03
{
	public partial class FormDesconto : Form
	{
		public FormDesconto()
		{
			InitializeComponent();
		}

		private double Calculo(RadioButton rbnDesconto, double valor, double desconto)
		{
			double total = 0;
			switch (rbnDesconto.Text)
			{
				case "Porcentagem (%)":
					total = valor - (desconto / 100 * valor);
					break;
				case "Valor Direto":
					total = valor - desconto;
					break;
			}
			return total;
		}

		private void btnCalcular_Click_1(object sender, EventArgs e)
		{
			double resultado;
			RadioButton rbnDesconto = gbFormaDesconto.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
			resultado = Calculo(rbnDesconto, Convert.ToDouble(txtValor.Text), Convert.ToDouble(txtDesconto.Text));
			txtResultado.Text = resultado.ToString();
		}
	}
}

