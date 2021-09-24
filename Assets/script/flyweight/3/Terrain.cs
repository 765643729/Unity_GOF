using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.script.flyweight._3
{
	struct Terrain
	{
		private int _movementCost;
		private bool _isWater;
		private Texture _texture;

		public Terrain(int movementCost, bool isWater, Texture texture)
		{
			this._movementCost = movementCost;
			this._isWater = isWater;
			this._texture = texture;
		}

		public int GetMovementCost { get => _movementCost; }
		public bool GetIsWater { get => _isWater; }

		public Texture GetTexture { get => _texture; }
	}
}
