using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
	public class OutputNeuron : Neuron
	{
		public List<Connection> Connections { get; }

		public OutputNeuron(string name)
		{
			Name = name;
			Connections = new List<Connection>();
		}
		
		public override double GetValue()
		{
			return Sigmoid(Connections.Sum(connection => connection.GetValue()));
		}
	}
}
