using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TInh_tien_dien.DataAccess;

namespace TInh_tien_dien.LopData
{
	public class baocao 
	{
		Data bc = new Data();

		public DataTable show()
		{
			DataTable tb = new DataTable();
			string sql = "Seclect * from baocao";
			tb = bc.getTable(sql);
			return (tb);
		}

		public void insertBaoCao(string ten, string phong, string thang, string tieuthu, string tongtien, string sodien)
		{
			string sql = " insert into baocao (ten, phong, thang, tieuthu, thanhtien, sodien) values(N'" + ten + "', N'" + phong + "', N'" + thang + "', N'" + tieuthu + "', N'" + tongtien + "', N'" + sodien + "')";
			bc.ExcuteNonQuery(sql);
		}

		public void DeleteBaoCao(string ten)
		{
			string sql = "delete baocao where ten=N'" + ten + "'";
			bc.ExcuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
			//N phòng trường hợp lỗi font tiếng việt
		}
	}
}
