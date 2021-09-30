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
		private Terrain[,] _tile;
		private Terrain _grassTerrain;
		private Terrain _hillTerrain;
		private Terrain _riverTerrain;

		public World(int height, int width)
		{
			this._height = height;
			this._width = width;

			_grassTerrain = new Terrain(1, false, null);
			_hillTerrain = new Terrain(3, false, null);
			_riverTerrain = new Terrain(2, true, null);

			_tile = new Terrain[_height, _width];

			void GenerateTerrain()
			{
				Random random = new Random();
				for(int x = 0; x < _width; x++)
				{
					for(int y = 0; y < _height; y++)
					{
						if(random.Next(10) == 0)
						{
							_tile[x, y] = _hillTerrain;
						}
						else
						{
							_tile[x, y] = _grassTerrain;
						}
					}
				}
				int x1 = random.Next(_width);
				for(int y1 = 0; y1 < height; y1++)
				{
					_tile[x1, y1] = _riverTerrain;
				}
			}
			Terrain GetTile(int x, int y)
			{
				return _tile[x, y];
			}
		}
	}
}
