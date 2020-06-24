using QLKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class PhongDao
    {
        ConnectQLKS connectQLKS = null;
        public PhongDao()
        {
            connectQLKS = new ConnectQLKS();
        }
       //------------------------------
        public DataTable DSLoaiPhong()
        {
            string str = "SELECT * FROM LOAIPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }

        public int addLP(LOAIPHONG lp)
        {
            connectQLKS.LOAIPHONGs.Add(lp);
            connectQLKS.SaveChanges();
            return lp.MaLoai;
        }
        public bool xoaLP(int ma)
        {
            try
            {
                var lp = connectQLKS.LOAIPHONGs.Find(ma);
                connectQLKS.LOAIPHONGs.Remove(lp);
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool updateLP(LOAIPHONG p)
        {
            try
            {
                var lp = connectQLKS.LOAIPHONGs.Find(p.MaLoai);
                lp.TenLoai = p.TenLoai;
                lp.SoNguoi = p.SoNguoi;
                lp.Gia = p.Gia;
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //------------------------------
        public DataTable DSPhong()
        {
            string str = "SELECT * FROM PHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }

        public int addPhong(PHONG p)
        {
            connectQLKS.PHONGs.Add(p);
            connectQLKS.SaveChanges();
            return p.MaPhong;
        }
        public bool xoaPhong(int ma)
        {
            try
            {
                var p = connectQLKS.PHONGs.Find(ma);
                connectQLKS.PHONGs.Remove(p);
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool updatePhong(PHONG p)
        {
            try
            {
                var phong = connectQLKS.PHONGs.Find(p.MaPhong);
                phong.idLoaiPhong = p.idLoaiPhong;
                phong.TinhTrang = p.TinhTrang;
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
