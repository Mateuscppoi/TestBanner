using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBenner
{
	class PreDefinedFunctions
	{
		public string name { get; }
		public string description { get; }
		public double time { get; }
		public int power { get; }

		public string character { get; }

		public PreDefinedFunctions(string name, string description, double time, int power, string character)
		{
			this.name = name;
			this.description = description;
			this.time = time;
			this.power = power;
			this.character = character;
		}


	}
}
