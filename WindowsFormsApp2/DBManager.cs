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

		public static bool readOrderData()
		{
			try
			{
				if (Connect())
				{
					List<long> tmpList = new List<long>();
					string sql = "select * from productionOrders where status=0;";
					using (SqlCommand cmd = new SqlCommand(sql, m_dbConnection))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							
							while (reader.Read())
							{
								OrderDataModel item = new OrderDataModel((string)reader["idProductionOrder"], (string)reader["machineRecipe"], (int)reader["targetPieces"], (int)reader["priority"], (int)reader["status"], (System.DateTime)reader["timestampInsert"], (int)reader["orderNum"], (bool)reader["orderModified"]);
								Helper.productionOrderList.Add(item);
							}
						}
					}
					return true;
				}
				else
				{
					MessageBox.Show("Unable to connect to DB");
					return false;
				}
			}
			catch (Exception ecc)
			{
				MessageBox.Show("Error during OrderGuiData: " + ecc.Message);
				MessageBox.Show(ecc.ToString());
				return false;
			}
		}
	}
}
