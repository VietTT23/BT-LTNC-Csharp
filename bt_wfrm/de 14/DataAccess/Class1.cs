using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace de_14.DataAccess
{
	class Data
	{
		public SqlConnection getConnect()
		{
			return new SqlConnection("Data Source=thang-pc;Initial Catalog=de_14;Integrated Security=True");
		}

		public DataTable getTable(string sql)
		{
			SqlConnection connect = getConnect();
			SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
			DataTable data = new DataTable();
			adapter.Fill(data);
			return (data);
		}

		public void ExecuteNonQuery(string sql)
		{
			SqlConnection connect = getConnect();
			SqlCommand cmd = new SqlCommand(sql, connect);
			cmd.Connection.Open();
			cmd.ExecuteNonQuery();
			cmd.Dispose();
		}
	}
}
