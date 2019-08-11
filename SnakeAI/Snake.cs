using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAI
{
	internal class Snake
	{
		public SnakePart Head { get; set; }
		public SnakePart[] TailParts { get; set; }
		public Direction LookingDirection { get; set; }

		public Snake(int x, int y, Direction lookingDirection)
		{
			Head = new SnakePart(x, y);
			LookingDirection = lookingDirection;
			TailParts = new SnakePart[0];
		}
	}
}
