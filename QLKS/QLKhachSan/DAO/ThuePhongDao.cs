using System;
using QLKhachSan.Model;
using System.Data;

namespace QLKhachSan.DAO
{
    public class ThuePhongDao
    {
        ConnectQLKS connectQLKS = null;
        public ThuePhongDao()
        {
            connectQLKS = new ConnectQLKS();
        }

        public DataTable GetKH(string ma)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE MaKH = '" + ma + "'";
            DataTable khachhang = DataProvider.Instance.ExecuteQuery(sql);
            return khachhang;
        }
        public DataTable DSPChon(string ma)
        {
            string str = "SELECT MaPhong, TenLoai, SoNguoi, Gia FROM PHONG, LOAIPHONG WHERE PHONG.idLoaiPhong = LOAIPHONG.MaLoai AND MaPhong = " +ma;
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }

        public DataTable DSPT()
        {
            string str = "SELECT MaPhong FROM PHONG WHERE TinhTrang = 'Trong'";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }

        public DataTable DSThuePhong()
        {
            string str = "SELECT * FROM THUEPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public int addPT(THUEPHONG tp)
        {
            try
            {
                connectQLKS.THUEPHONGs.Add(tp);
                connectQLKS.SaveChanges();
                return tp.MaThue;
            }
            catch (Exception ex)
            {
                Console.Write("Loi!!" + ex);
                return -1;
            }

        }

        public bool updateRoom(int maPhong, string tinhtrang)
        {
            try
            {
                PHONG p = connectQLKS.PHONGs.Find(maPhong);
                p.TinhTrang = tinhtrang;
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool xoaPT(int ma)
        {
            try
            {
                var pt = connectQLKS.THUEPHONGs.Find(ma);
                connectQLKS.THUEPHONGs.Remove(pt);
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
