using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.script.command
{
	class MoveUnitCommand : ICommand
	{
		private GameActor _actor;

		private int _xOffset;
		private int _yOffset;

		public MoveUnitCommand(GameActor actor, int xOffset, int yOffset)
		{
			_actor = actor;
			_xOffset = xOffset;
			_yOffset = yOffset;
		}

		public void Execute()
		{
			_actor.MoveTo(_xOffset, _yOffset);
		}

		public void Undo()
		{
			_actor.MoveTo(-_xOffset, -_yOffset);
		}
	}
}
