﻿using QLKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class NhanVienDao
    {
        ConnectQLKS connectQLKS = null;
        public NhanVienDao()
        {
            connectQLKS = new ConnectQLKS();
        }

        public int addNV(NHANVIEN nv)
        {
            connectQLKS.NHANVIENs.Add(nv);
            connectQLKS.SaveChanges();
            return nv.MaNV;
        }
        public DataTable DSNV()
        {
            string str = "SELECT * FROM NHANVIEN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public DataTable DSCV()
        {
            string str = "SELECT * FROM CHUCVU";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public bool xoaNV(int ma)
        {
            try
            {
                var nv = connectQLKS.NHANVIENs.Find(ma);
                connectQLKS.NHANVIENs.Remove(nv);
                connectQLKS.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool updateNV(NHANVIEN nv)
        {
            try
            {
                var nhanvien = connectQLKS.NHANVIENs.Find(nv.MaNV);
                nhanvien.TenNV = nv.TenNV;
                nhanvien.GioiTinh = nv.GioiTinh;
                nhanvien.NgaySinh = nv.NgaySinh;
                nhanvien.DiaChi = nv.DiaChi;
                nhanvien.SoDT = nv.SoDT;
                nhanvien.CMT = nv.CMT;
                nhanvien.idChucVu = nv.idChucVu;
                nhanvien.TenDangNhap = nv.TenDangNhap;
                nhanvien.MatKhau = nv.MatKhau;
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
