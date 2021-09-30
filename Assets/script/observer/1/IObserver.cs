using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.script.observer._1
{
	enum EventType
	{
		EVENT_START_FALL
	}

	interface IObserver
	{

		public void OnNotify(Entity entity, EventType eventType);
	}
}
