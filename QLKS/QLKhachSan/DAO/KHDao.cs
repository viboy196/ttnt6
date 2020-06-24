using QLKhachSan.Model;
using System;
using System.Data;

namespace QLKhachSan.DAO
{
    public class KHDao
    {
        ConnectQLKS connectQLKS = null;
        public KHDao()
        {
            connectQLKS = new ConnectQLKS();
        }

        public int addKH(KHACHHANG kh)
        {
            connectQLKS.KHACHHANGs.Add(kh);
            connectQLKS.SaveChanges();
            return kh.MaKH;
        }
        public DataTable DSKh()
        {
            string str = "SELECT * FROM KHACHHANG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);        
            return dt;
        }
        public bool xoaKH(int ma)
        {
            try
            {
                var kh = connectQLKS.KHACHHANGs.Find(ma);
                connectQLKS.KHACHHANGs.Remove(kh);
                connectQLKS.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
           
        }

        public bool updateKH(KHACHHANG kh)
        {
            try
            {
                var khachhang = connectQLKS.KHACHHANGs.Find(kh.MaKH);
                khachhang.TenKH = kh.TenKH;
                khachhang.GioiTinh = kh.GioiTinh;
                khachhang.NgaySinh = kh.NgaySinh;
                khachhang.DiaChi = kh.DiaChi;
                khachhang.SoDT = kh.SoDT;
                khachhang.CMT = kh.CMT;
                khachhang.GhiChu = kh.GhiChu;
                connectQLKS.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
