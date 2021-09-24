using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.script.command
{
	public class GameActor
	{
		private int _x;
		private int _y;

		public int X { get => _x; }

		public int Y { get => _y; }

		public string Name { get; set; }

		public GameActor(string name, int x, int y)
		{
			this.Name = name;
			this._x = x;
			this._y = y;
		}

		public void MoveTo(int xOffset, int yOffset)
		{
			_x += xOffset;
			_y += yOffset;
			Debug.Log($"{Name} 移动到 {X},{Y}");
		}
	}
}
