using QLKhachSan.Model;
using System;
using System.Data;

namespace QLKhachSan.DAO
{
    public class DichVuDao
    {
        ConnectQLKS connectQLKS = null;
        public DichVuDao()
        {
            connectQLKS = new ConnectQLKS();
        }

        public int addDV(DICHVU dv)
        {
            connectQLKS.DICHVUs.Add(dv);
            connectQLKS.SaveChanges();
            return dv.MaDV;
        }
        public DataTable DSDV()
        {
            string str = "SELECT * FROM DICHVU";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public bool xoaDV(int ma)
        {
            try
            {
                var dichvu = connectQLKS.DICHVUs.Find(ma);
                connectQLKS.DICHVUs.Remove(dichvu);
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool updateDV(DICHVU dv)
        {
            try
            {
                var dichvu = connectQLKS.DICHVUs.Find(dv.MaDV);
                dichvu.TenDichVu = dv.TenDichVu;
                dichvu.Gia = dv.Gia;
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
