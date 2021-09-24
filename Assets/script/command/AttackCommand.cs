using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.script.command
{
	class AttackCommand : ICommand
	{
		private GameActor _actor;

		public AttackCommand(GameActor actor)
		{
			_actor = actor;
		}

		public void Execute()
		{

			Debug.Log(_actor.Name + " 攻击一下");

		}


		public void Undo()
		{
			Debug.Log(_actor.Name + " 撤销攻击");
		}
	}
}
