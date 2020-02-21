using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EubamaGui
{
	public class OrderDataModel
	{
		private string idProductionOrder, machineRecipe;
		private int targetPieces, priority, status, order;
		private DateTime insertingTime;
		private bool orderModified;

		public OrderDataModel()
		{

		}

		public OrderDataModel(string idProductionOrder, string machineRecipe, int targetPieces, int priority, int status, DateTime insertingTime, int order, bool orderModified)
		{
			this.idProductionOrder = idProductionOrder;
			this.machineRecipe = machineRecipe;
			this.targetPieces = targetPieces;
			this.priority = priority;
			this.status = status;
			this.insertingTime = insertingTime;
			this.order = order;
			this.orderModified = orderModified;
		}

		public string IdProductionOrder { get => idProductionOrder; set => idProductionOrder = value; }
		public string MachineRecipe { get => machineRecipe; set => machineRecipe = value; }
		public int TargetPieces { get => targetPieces; set => targetPieces = value; }
		public int Priority { get => priority; set => priority = value; }
		public int Status { get => status; set => status = value; }
		public DateTime InsertingTime { get => insertingTime; set => insertingTime = value; }
		public int Order { get => order; set => order = value; }
		public bool OrderModified { get => orderModified; set => orderModified = value; }
	}
}
