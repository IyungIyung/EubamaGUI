using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace EubamaGui
{
	class DBManager
	{
		private static SqlConnection m_dbConnection;
		static DBManager()
		{
			m_dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ICTSCPDB"].ConnectionString);
		}
		public static System.Data.ConnectionState GetConnectionState()
		{
			return m_dbConnection.State;
		}

		public static bool Connect()
		{
			try
			{
				if (m_dbConnection.State != System.Data.ConnectionState.Open)
				{
					m_dbConnection.Open();
				}

				if (m_dbConnection.State == System.Data.ConnectionState.Open)
				{
					// Console.WriteLine("--->Connection established to " + m_dbConnection.ToString() + " <---");
					return true;
				}
				Console.WriteLine("--->Connection refused <---");
				return false;
			}
			catch (SqlException sqle)
			{
				Console.WriteLine("--->Connection Problem: " + sqle.ToString() + " <---");

				return false;
			}
		}

		public static bool Disconnect()
		{
			try
			{
				m_dbConnection.Close();
			}
			catch (SqlException sqle)
			{
				Console.WriteLine("--->Disconnection Problem: " + sqle.ToString() + " <---");
				return false;
			}
			return true;
		}

		//only for the status
		public static bool updateOrderDB(OrderDataModel orderToBeUpdated, int newStatus)
		{
			try
			{
				if (Connect())
				{
					string query = "update productionOrders set status=@Status where idProductionOrder like @IdProductionOrder and machineRecipe like @MachineRecipe and targetPieces like @TargetPieces and priority like @Priority";
					using (SqlCommand cmd = new SqlCommand(query, m_dbConnection))
					{
						cmd.Parameters.AddWithValue("@Status", newStatus);
						cmd.Parameters.AddWithValue("@IdProductionOrder",orderToBeUpdated.IdProductionOrder);
						cmd.Parameters.AddWithValue("@MachineRecipe", orderToBeUpdated.MachineRecipe);
						cmd.Parameters.AddWithValue("@TargetPieces", orderToBeUpdated.TargetPieces);
						cmd.Parameters.AddWithValue("@Priority", orderToBeUpdated.Priority);
						cmd.ExecuteNonQuery();
					}
					return true;
				}
				else
				{
					MessageBox.Show("Unable to update DB");
					return false;
				}
			}
			catch (Exception ecc)
			{
				MessageBox.Show(ecc.ToString());
				return false;
			}
		}

		public static bool readOrderDB(int status, out List<OrderDataModel> tempOrderListout)
		{
			List<OrderDataModel> tempOrderList = new List<OrderDataModel>();
			try
			{
				if (Connect())
				{
					string query = "select * from productionOrders where status=@Status;";
					using (SqlCommand cmd = new SqlCommand(query, m_dbConnection))
					{
						cmd.Parameters.AddWithValue("@Status", status);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								OrderDataModel item = new OrderDataModel((string)reader["idProductionOrder"], (string)reader["machineRecipe"], (int)reader["targetPieces"], (int)reader["priority"], (int)reader["status"], (System.DateTime)reader["timestampInsert"], (int)reader["orderNum"], (bool)reader["orderModified"]);
								tempOrderList.Add(item);
							}
						}
					}
					tempOrderListout = tempOrderList;
					return true;
				}
				else
				{
					MessageBox.Show("Unable to read DB");
					tempOrderListout = tempOrderList;
					return false;
				}
			}
			catch (Exception ecc)
			{
				MessageBox.Show("Error during OrderGuiData: " + ecc.ToString());
				tempOrderListout = tempOrderList;
				return false;
			}
		}
	}
}
