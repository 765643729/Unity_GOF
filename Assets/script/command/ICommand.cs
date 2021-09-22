using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.script.command
{
    public interface ICommand
    {
        public void Execute(GameActor actor);
    }
}
