using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeAI
{
	static class GameSettings
	{
		public static readonly int UnitSize;
		public static readonly System.Drawing.Brush HeadBrush;
		public static readonly System.Drawing.Brush TailBrush;

		static GameSettings()
		{
			if (!File.Exists("config.cfg")) throw new FileNotFoundException();
			StreamReader strR = new StreamReader("config.cfg", Encoding.UTF8);
			List<string> configStrings = new List<string>();
			while (strR.Peek() != -1)
			{
				configStrings.Add(strR.ReadLine());
			}
			if (configStrings.Count < 2) throw new ArgumentException();
			UnitSize = Convert.ToInt32(configStrings[0]);
			HeadBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromName(configStrings[1]));
			TailBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromName(configStrings[2]));
		}
	}
}
