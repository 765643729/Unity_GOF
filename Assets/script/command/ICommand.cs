using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.script.command
{
	/// <summary>
	/// 命令接口
	/// </summary>
	public interface ICommand
	{
		/// <summary>
		/// 执行命令
		/// </summary>
		public void Execute();
		/// <summary>
		/// 撤销命令
		/// </summary>
		public void Undo();

	}
}
