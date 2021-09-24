using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.script.flyweight._2
{
	enum Terrain
	{
		TERRAIN_GRASS,
		TERRAIN_HILL,
		TERRAIN_RIVER,
	}
	class World
	{
		private int _height;
		private int _width;
		private Terrain[,] _tiles;

		int GetMovementCost(int x, int y)
		{
			switch(_tiles[x, y])
			{
				case Terrain.TERRAIN_GRASS:
					return 1;
				case Terrain.TERRAIN_HILL:
					return 3;
				case Terrain.TERRAIN_RIVER:
					return 2;
				default:
					return 1;
			}
		}
		bool IsWater(int x, int y)
		{
			switch(_tiles[x, y])
			{
				case Terrain.TERRAIN_RIVER:
					return true;
				default:
					return false;
			}
		}
	}
}
