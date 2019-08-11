using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAI
{
	public static class Extension
	{
		internal static void DrawSnake(this System.Drawing.Graphics graphics, Snake snake)
		{
			graphics.FillRectangle(GameSettings.HeadBrush, snake.Head.X * GameSettings.UnitSize, snake.Head.Y * GameSettings.UnitSize, GameSettings.UnitSize, GameSettings.UnitSize);
			snake.TailParts.ForEach(x => graphics.FillRectangle(GameSettings.TailBrush, x.X * GameSettings.UnitSize, x.Y * GameSettings.UnitSize, GameSettings.UnitSize, GameSettings.UnitSize));
		}
	}
}
