using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EubamaGui
{
	class GuiHandler
	{
		public static bool ScheduleTable()
		{
			try
			{
				return true;
			}
			catch(Exception ecc)
			{
				return false;
			}
		}
	}
}
