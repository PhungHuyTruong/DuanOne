﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IChucNangDangNhap
    {
        NhanVien KiemTra(string tk, string mk);
    }
}
