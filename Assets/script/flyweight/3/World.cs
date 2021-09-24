using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.script.flyweight._3
{
	class World
	{
		private int _height;
		private int _width;
		private Terrain[,] _terrains;
		public World(int height, int width)
		{
			this._height = height;
			this._width = width;
			_terrains = new Terrain[_height, _width];
		}
	}
}
