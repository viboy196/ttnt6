using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLDIEM
{
    public class KetNoiDB
    {
       
        public static SqlConnection conn;
        public static SqlCommand cm;
        public static SqlDataAdapter da;
        public static void MoKetNoi()
        {
            KetNoiDB.conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=QL_DIEM_TRUONGTHCS;Integrated Security=True");
            conn.Open();
        }
        public static void DongKetNoi()
        {
            conn.Close();
        }
        public static void ExcuteNonQR(string sql)
        {
            MoKetNoi();
            cm = new SqlCommand(sql,conn);
            cm.ExecuteNonQuery();
            DongKetNoi();
        }
        public static DataTable Getdatatable(string sql)
        {
            MoKetNoi();
            DataTable dt = new DataTable();
            cm = new SqlCommand(sql,conn);
            da = new SqlDataAdapter(cm);
            da.Fill(dt);
            DongKetNoi();
            return dt;
         
        }

    }
}
