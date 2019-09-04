using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
	public class Connection
	{
		public double Weigth { get; set; }
		public Neuron Neuron { get; set; }

		public Connection(double weigth, Neuron neuron)
		{
			Weigth = weigth;
			Neuron = neuron;
		}

		public double GetValue()
		{
			return Neuron.GetValue() * Weigth;
		}
	}
}
