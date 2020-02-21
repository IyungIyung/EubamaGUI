using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EubamaGui
{
	public partial class Form1 : Form
	{
		private int activeRow,maxRow;

		public Form1()
		{
			InitializeComponent();
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			Helper.productionOrder = new OrderDataModel();
			try
			{
				if(DBManager.readOrderData())
				{
					Form1_Load();
				}
			}
			catch (Exception ecc)
			{

			}
		}

		private void Form1_Load()
		{
			DataTable table = new DataTable();

			table.Columns.Add("idProductionOrder", typeof(string));
			table.Columns.Add("targetPieces", typeof(int));
			table.Columns.Add("machineRecipe", typeof(string));
			table.Columns.Add("priority", typeof(int));
			table.Columns.Add("timeStampInsert", typeof(string));
			table.Columns.Add("status", typeof(int));
			table.Columns.Add("order", typeof(int));
			table.Columns.Add("orderModified", typeof(int));

			foreach (OrderDataModel order in Helper.productionOrderList)
			{
				table.Rows.Add(order.IdProductionOrder, order.TargetPieces, order.MachineRecipe, order.Priority, order.InsertingTime, order.Status, order.Order, order.OrderModified);
			}

			dataGridView1.DataSource = table;
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < dataGridView1.NewRowIndex - 1)
				{
					switch (dataGridView1.Columns[e.ColumnIndex].Name)
					{
						case "idProductionOrder":
							Helper.productionOrderList[e.RowIndex].IdProductionOrder = (string)dataGridView1.CurrentCell.Value;
							break;
						case "targetPieces":
							Helper.productionOrderList[e.RowIndex].TargetPieces = (int)dataGridView1.CurrentCell.Value;
							break;
						case "machineRecipe":
							Helper.productionOrderList[e.RowIndex].MachineRecipe = (string)dataGridView1.CurrentCell.Value;
							break;
						case "priority":
							Helper.productionOrderList[e.RowIndex].Priority = (int)dataGridView1.CurrentCell.Value;
							break;
						case "timeStampInsert":
							Helper.productionOrderList[e.RowIndex].InsertingTime = Convert.ToDateTime(dataGridView1.CurrentCell.Value);
							break;
						case "status":
							Helper.productionOrderList[e.RowIndex].Status = (int)dataGridView1.CurrentCell.Value;
							break;
						default:
							Console.WriteLine("Default case");
							break;
					}
				}
				else
				{
					OrderDataModel temp_order = new OrderDataModel();


				}
			}
			catch (Exception ecc)
			{
				MessageBox.Show(ecc.ToString());
			}
		}

		private void topButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (activeRow != 0)
				{
					exchangeRow(activeRow, 0);
					Form1_Load();
				}
				else
				{
					MessageBox.Show("Please choose another row");
				}
			}
			catch (Exception ecc)
			{
				MessageBox.Show(ecc.ToString());
			}
			
		}

		private void upButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (activeRow != 0)
				{
					exchangeRow(activeRow, activeRow-1);
					Form1_Load();
				}
				else
				{
					MessageBox.Show("Please choose another row");
				}
			}
			catch (Exception ecc)
			{
				MessageBox.Show(ecc.ToString());
			}
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void bottomButton_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			activeRow = e.RowIndex;
		}

		private void exchangeRow(int rowInit, int rowDest)
		{
			OrderDataModel temp = Helper.productionOrderList[rowDest];
			Helper.productionOrderList[rowDest] = Helper.productionOrderList[rowInit];
			Helper.productionOrderList[rowInit] = temp;

			//return false;
		}
	}
}
