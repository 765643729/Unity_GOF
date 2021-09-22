using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.script.command
{
    public class InputHandler : MonoBehaviour
    {
        private ICommand _ButtonJ;
        private ICommand _ButtonK;

        public InputHandler()
        {
            _ButtonJ = new AttackCommand();
            _ButtonK = new DefenceCommand();
        }

        private void Update()
        {
            GameActor actor = new GameActor()
            {
                Name = "玩家"
            };
            if (Input.GetKeyDown(KeyCode.J))
            {
                _ButtonJ.Execute(actor);
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                _ButtonK.Execute(actor);
            }

        }

    }
}