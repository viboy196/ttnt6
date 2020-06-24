using QLKhachSan.Model;
using System;
using System.Data;

namespace QLKhachSan.DAO
{
    public class DatPhongDao
    {
        ConnectQLKS connectQLKS = null;
        public DatPhongDao()
        {
            connectQLKS = new ConnectQLKS();
        }

        public DataTable GetKH(string ma)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE MaKH = '"+ma+"'";
            DataTable khachhang = DataProvider.Instance.ExecuteQuery(sql);            
            return khachhang;
        }
        public DataTable DSPT(string songuoi)
        {
            string str = "SELECT MaPhong, TenLoai, SoNguoi, Gia FROM PHONG, LOAIPHONG WHERE PHONG.idLoaiPhong = LOAIPHONG.MaLoai AND TinhTrang = 'Trong' AND SoNguoi >= "+ songuoi;
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public DataTable DSDatPhong()
        {
            string str = "SELECT * FROM DATPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public int addDP(DATPHONG dp)
        {
            connectQLKS.DATPHONGs.Add(dp);
            connectQLKS.SaveChanges();
            return dp.MaPhieuDat;
        }

        public bool updateRoom(int maPhong)
        {
            try
            {
                PHONG p = connectQLKS.PHONGs.Find(maPhong);
                p.TinhTrang = "Da dat";
                connectQLKS.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool xoaPD(int ma)
        {
            try
            {
                var pd = connectQLKS.DATPHONGs.Find(ma);
                connectQLKS.DATPHONGs.Remove(pd);
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
