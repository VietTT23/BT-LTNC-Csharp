using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TInh_tien_dien.DataAccess
{
	public class Data
	{
		public SqlConnection getConnect()
		{
			return new SqlConnection(@"Data Source=thang-pc;Initial Catalog=tinhtiendien;Integrated Security=True");
		}

		public DataTable getTable(string sql)
		{
			SqlConnection conn = getConnect();
			SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
			DataTable table = new DataTable();
			adp.Fill(table);
			return (table);
		}

		public void ExcuteNonQuery(string sql)
		{
			SqlConnection connect = getConnect();
			SqlCommand cmd = new SqlCommand(sql, connect);
			cmd.Connection.Open();
			cmd.ExecuteNonQuery();
			cmd.Dispose();
		}
	}
}
