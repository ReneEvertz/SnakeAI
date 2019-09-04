﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
	public class InputNeuron : Neuron
	{
		public double Input { get; set; }

		public InputNeuron(string name)
		{
			Name = name;
		}

		public override double GetValue()
		{
			return Input;
		}
	}
}
