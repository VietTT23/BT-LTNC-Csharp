using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using de_14.DataAccess;

namespace de_14.Query
{
	public class SV
	{
		Data sv = new Data();

		public DataTable Show()
		{
			string sql = "Select * from SV";
			DataTable dt = new DataTable();
			dt = sv.getTable(sql);
			return dt;
		}

		public void Insertsv(string ma, string ten, string gt, string qq)
		{

			string sql = "insert into SV (MaSV,TenSV ,GioiTinh, QueQuan) values(N'" + ma + "',N'" + ten + "',N'" + gt + "',N'" + qq + "')";
			sv.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
			//N phòng trường hợp lỗi font tiếng việt
		}

		public void Updatesv(string ma, string ten, string gt, string qq)
		{
			string sql = "update SV set TenSV=N'" + ten + "' ,GioiTinh=N'" + gt + "',QueQuan=N'" + qq + "'  where MaSV=N'" + ma + "'";
			sv.ExecuteNonQuery(sql);
			//lệnh thực thi không trả về bảng đã viết bên lớp 1
			//N phòng trường hợp lỗi font tiếng việt
		}
		public void Deletesv(string ml)
		{
			string sql = "delete SV where MaSV=N'" + ml + "'";
			sv.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
			//N phòng trường hợp lỗi font tiếng việt
		}
	}
}

