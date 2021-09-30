using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.script.observer._1
{
	class Achievements : IObserver
	{
		public void OnNotify(Entity entity, EventType eventType)
		{
			switch(eventType)
			{
				case EventType.EVENT_START_FALL:
					if(entity.IsHero())
					{

					}
					break;
			}
		}
	}
}
