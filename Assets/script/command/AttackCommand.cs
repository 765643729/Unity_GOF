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
        public void Execute()
        {
        }

        public void Execute(GameActor actor)
        {

            Debug.Log(actor.Name + " 攻击一下");

        }
    }
}
