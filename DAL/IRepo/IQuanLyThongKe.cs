using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IQuanLyThongKe
    {
        IEnumerable<HoaDon> Find(Expression<Func<HoaDon, bool>> predicate);
        HoaDon Get(int id);
        void Add(HoaDon entity);
        void Remove(HoaDon entity);

        List<HoaDon> LayHoaDonsTheoNgay(DateTime startDate, DateTime endDate);
        decimal LayTongTienTheoNgay(DateTime startDate, DateTime endDate);
    }
}
