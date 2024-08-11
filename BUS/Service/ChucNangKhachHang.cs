using BUS.IService;
using DAL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ChucNangKhachHang : IChucNangKhachHang
    {
        private readonly IQuanLyKhachHang _repo;
        public ChucNangKhachHang(IQuanLyKhachHang repo)
        {
            _repo = repo;
        }

        public bool AddKhachHang(KhachHang kh)
        {
            return _repo.AddKhachHang(kh);
        }

        public async Task<IEnumerable<KhachHang>> GetAllKHachHang()
        {
           return await _repo.GetAllKHachHang();
        }

        public KhachHang GetKhachHang(string sdt)
        {
            return _repo.GetKhachHang(sdt);
        }

        public bool UpdateKhachHang(KhachHang kh)
        {
            return _repo.UpdateKhachHang(kh);
        }
    }
}
