using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAI
{
	internal abstract class Entity
	{
		public int X { get; set; }
		public int Y { get; set; }

		public bool CheckHit(Entity entity)
		{
			return this.X == entity.X && this.Y == entity.Y;
		}
	}
}
