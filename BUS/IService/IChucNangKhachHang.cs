using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IChucNangKhachHang
    {
        Task<IEnumerable<KhachHang>> GetAllKHachHang();
        bool AddKhachHang(KhachHang kh);
        bool UpdateKhachHang(KhachHang kh);
        KhachHang GetKhachHang(string sdt);
    }
}
