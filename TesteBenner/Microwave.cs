namespace TesteBenner
{
	internal class Microwave
	{
		public double time { get; set; }
		public int power { get; set; } = 10;
		public string character { get; set; }

		public void isTimeAlowed()
		{
			if (this.time > 2 || this.time < 0.1)
			{
				throw new System.Exception("O tempo não pode ser maior que 2 minutos ou menor que 1 segundo.");
			}
		}

		public void isPowerAllowed()
		{
			if (this.power < 1 || this.power > 10)
			{
				throw new System.Exception("A potência não pode ser maior que 10 minutos ou menor que 1.");
			}
		}

		public double convertMinToSeconds()
		{
			return this.time * 60;
		}

		public string finishHeating()
		{
			return "aquecido";
		}
	}
}