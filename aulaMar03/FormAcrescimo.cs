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
	public partial class FormAcrescimo : Form
	{
		public FormAcrescimo()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			double resultado;
			resultado = Acrescimo(Convert.ToDouble(txtNumero.Text), Convert.ToDouble(txtAcrescimo.Text));
			txtResultado.Text = resultado.ToString();
		}

		private double Acrescimo(double n1, double n2)
		{
			double total;
			total = n1 + (n2 / 100 * n1);
			return total;
		}
	}
}
