using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAI
{
	public partial class GameView : Form
	{
		Snake snake;
		Timer gameTick;

		public GameView()
		{
			InitializeComponent();
			DoubleBuffered = true;

			snake = new Snake(5, 5, Direction.Right);

			gameTick = new Timer() { Interval = 100 };
			gameTick.Tick += GameTick_Tick;
			gameTick.Start();
		}

		private void GameTick_Tick(object sender, EventArgs e)
		{
			switch (snake.LookingDirection)
			{
				case Direction.Left:
					snake.Head.X--;
					break;
				case Direction.Top:
					snake.Head.Y--;
					break;
				case Direction.Right:
					snake.Head.X++;
					break;
				case Direction.Bottom:
					snake.Head.X--;
					break;
				default:
					break;
			}

			Refresh();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.DrawSnake(snake);
		}
	}
}
