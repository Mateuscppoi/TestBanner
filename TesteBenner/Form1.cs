using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBenner
{
	public partial class Form1 : Form
	{
		Microwave microwave = new Microwave();
		List<PreDefinedFunctions> preDefinedFunctions = new List<PreDefinedFunctions>();


		public Form1()
		{
			InitializeComponent();

			preDefinedFunctions.Add(new PreDefinedFunctions("frango", "cozinhar frango", 1.2, 8, "!"));
			preDefinedFunctions.Add(new PreDefinedFunctions("carne", "cozinhar carne", 1, 10, "#"));
			preDefinedFunctions.Add(new PreDefinedFunctions("peixe", "cozinhar peixe", 0.7, 7, "*"));
			preDefinedFunctions.Add(new PreDefinedFunctions("batata", "cozinhar batata", 1.9, 9, "*"));
			preDefinedFunctions.Add(new PreDefinedFunctions("descongelar", "Descongelar alimentos", 2.0, 10, "&"));

			preDefinido.DataSource = preDefinedFunctions;
			preDefinido.DisplayMember = "name";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}


		private void button1_Click(object sender, EventArgs e)
		{
			string[] fields = informacoes.Text.Split(',');
			microwave.power = Convert.ToInt32(fields[0]);
			microwave.time = Convert.ToDouble(fields[1]);
			if (fields.Count() > 2)
			{
				bool hasPreDefined = false;
				for (int x = 0; x < preDefinedFunctions.Count; x++)
				{
					if (preDefinedFunctions[x].name.Equals(fields[2]))
					{
						microwave.power = preDefinedFunctions[x].power;
						microwave.time = preDefinedFunctions[x].time;
						microwave.character = preDefinedFunctions[x].character;
						hasPreDefined = true;
					}
				}
				if (!hasPreDefined)
				{
					throw new Exception("Alimento incompatível com o programa.");
				}
			} else
			{
				microwave.character = ".";
			}
			microwave.isPowerAllowed();
			microwave.isTimeAlowed();
			for(int x = 0; x < (microwave.convertMinToSeconds() * microwave.power); x++)
			{
				informacoes.Text += microwave.character;
			}
			informacoes.Text = microwave.finishHeating();
		}

		private void quickStart_Click(object sender, EventArgs e)
		{
			microwave.power = 8;
			microwave.time = 0.3;
			for (int x = 0; x < (microwave.convertMinToSeconds() * microwave.power); x++)
			{
				informacoes.Text += ".";
			}
			informacoes.Text = microwave.finishHeating();
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void test_TextChanged(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (newName.Text != null && newInfo.Text != null && newChar.Text != null && newPower.Text != null && newTime.Text != null) {
				preDefinedFunctions.Add(new PreDefinedFunctions(newName.Text, newInfo.Text, Convert.ToDouble(newTime.Text), Convert.ToInt32(newPower.Text), newChar.Text));
				preDefinido.Items.Add(newName.Text);
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
