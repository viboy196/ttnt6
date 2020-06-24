using QLKhachSan.Model;
using System;
using System.Data;
using System.Linq;

namespace QLKhachSan.DAO
{
    public class MainDao
    {
        ConnectQLKS connectQLKS = null;
        public MainDao()
        {
            connectQLKS = new ConnectQLKS();
        }
        public int loadSPT()
        {
            int sp = connectQLKS.PHONGs.Count(x=>x.TinhTrang.Equals("Trong"));
            return sp;
        }
        public int loadSPDD()
        {
            int sp = connectQLKS.PHONGs.Count(x => x.TinhTrang.Equals("Da dat"));
            return sp;
        }
        public int loadSPDT()
        {
            int sp = connectQLKS.PHONGs.Count(x => x.TinhTrang.Equals("Da thue"));
            return sp;
        }

        public bool updatePass(string tenDN, string mkmoi)
        {
            try
            {
                var nhanvien = connectQLKS.NHANVIENs.Where(x=> x.TenDangNhap.Equals(tenDN)).FirstOrDefault();              
                nhanvien.MatKhau = mkmoi;
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable DSP()
        {
            string str = "SELECT MaPhong, TinhTrang FROM PHONG";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }
    }
}
