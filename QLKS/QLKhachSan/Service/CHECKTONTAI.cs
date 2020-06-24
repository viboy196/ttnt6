using QLKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Service
{
    class CHECKTONTAI
    {
        ConnectQLKS connectQLKS = null;
        public CHECKTONTAI()
        {
            connectQLKS = new ConnectQLKS();
        }

        public bool search(NHANVIEN nv)
        {
            try
            {
                var nhanvien = connectQLKS.NHANVIENs.Find(nv.MaNV);
                if (nhanvien == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
