using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
	public abstract class Neuron
	{
		public string Name { get; set; }

		public abstract double GetValue();


		public static double Sigmoid(double value)
		{
			return 1.0f / (1.0f + Math.Exp(-value));
		}
	}
}
