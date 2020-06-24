using QLKhachSan.Model;
using System.Data;
using System.Linq;

namespace QLKhachSan.DAO
{
    public class LoginDao
    {
        ConnectQLKS connectQLKS = null;
        public LoginDao()
        {
            connectQLKS = new ConnectQLKS();
        }
        public bool check(string tk, string mk)
        {
            int c = connectQLKS.NHANVIENs.Count(x => x.TenDangNhap.Equals(tk) && x.MatKhau.Equals(mk));
            if (c > 0)
                return true;
            else
                return false;
        }
        public DataTable quyen(string tenDN)
        {
            string str = "SELECT idChucVu FROM NHANVIEN WHERE TenDangNhap = '" + tenDN + "'";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }
    }
}
