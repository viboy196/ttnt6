using QLKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class ThietBiDao
    {
        ConnectQLKS connectQLKS = null;
        public ThietBiDao()
        {
            connectQLKS = new ConnectQLKS();
        }

        public DataTable DSPhong()
        {
            string str = "SELECT MaPhong FROM PHONG";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }
        public DataTable DsTBTheoPhong(string ma)
        {
            string str = "SELECT TenThietBi, SoLuong FROM THIETBI WHERE idPhong =" + ma;
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }

        public int addTB(THIETBI tb)
        {
            connectQLKS.THIETBIs.Add(tb);
            connectQLKS.SaveChanges();
            return tb.SoLuong;
        }

        public bool xoaTB(THIETBI tb)
        {
            try
            {
                connectQLKS.THIETBIs.Remove(tb);
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
      
    }
}
