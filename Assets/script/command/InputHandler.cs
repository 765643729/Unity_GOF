using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.script.command
{
	public class InputHandler : MonoBehaviour
	{

		private Stack<ICommand> commandHistroy;

		public InputHandler()
		{
			commandHistroy = new Stack<ICommand>();
		}

		private void Update()
		{
			var command = InputCommand();
			if(command != null)
			{
				command.Execute();
				commandHistroy.Push(command);
			}
			if(Input.GetKeyDown(KeyCode.Z))
			{
				if(commandHistroy.Count > 0)
				{
					commandHistroy.Pop();
				}
			}
		}

		private ICommand InputCommand()
		{
			var unit = GetSelectUnit();

			ICommand command = null;
			if(Input.GetKeyDown(KeyCode.J))
			{
				command = new AttackCommand(unit);
			}
			else if(Input.GetKeyDown(KeyCode.K))
			{
				command = new DefenceCommand(unit);

			}
			else if(Input.GetKeyDown(KeyCode.W))
			{
				command = new MoveUnitCommand(unit, 0, 1);
			}
			else if(Input.GetKeyDown(KeyCode.S))
			{
				command = new MoveUnitCommand(unit, 0, -1);
			}
			else if(Input.GetKeyDown(KeyCode.A))
			{
				command = new MoveUnitCommand(unit, -1, 0);
			}
			else if(Input.GetKeyDown(KeyCode.D))
			{
				command = new MoveUnitCommand(unit, 1, 0);
			}

			return command;
		}

		private GameActor _unit = new GameActor("玩家", 0, 0);
		private GameActor GetSelectUnit()
		{
			return _unit;
		}
	}
}