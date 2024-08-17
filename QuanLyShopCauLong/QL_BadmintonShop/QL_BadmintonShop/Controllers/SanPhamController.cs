using QL_BadmintonShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_BadmintonShop.Models;
using PagedList.Mvc;

using PagedList;
using System.Web.UI;

namespace QL_BadmintonShop.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        DbBadmintonShopDataContext db = new DbBadmintonShopDataContext();

        public ActionResult ShowAllSanPham(int? page, string search = "")
        {
            if (page == null)
                page = 1;
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            List<SANPHAM> sp = db.SANPHAMs.Where(s => s.TENSP.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(sp.ToPagedList(pageNumber, pageSize));
        }
        
        public ActionResult ChiTietSanPham(int id)
        {

            SANPHAM detail = db.SANPHAMs.Single(s => s.MASP == id);
            if (detail == null)
            {
                return HttpNotFound();
            }
            return View(detail);
        }
        public ActionResult ThuongHieu() 
        {
            var listTH = db.NHASANXUATs.ToList();
            return View(listTH);
        }

        public ActionResult ThuongHieuSanPham(int maLoai, int maNSX, int? page)
        {
            if (page == null)
                page = 1;
            int pageSize = 12;
            int pageNumber = (page ?? 1);

            ViewBag.MaLoai = maLoai;

            var listTH = db.SANPHAMs.Where(s => s.MANSX == maNSX && s.MALOAI == maLoai).ToList();
            LOAI cd = db.LOAIs.Single(x => x.MALOAI == maLoai);

            return View(listTH.ToPagedList(pageNumber, pageSize));
        }

        //new option
        //public ActionResult ThuongHieuSanPham(int maLoai, int maNSX, int? page)
        //{
        //    if (page == null)
        //        page = 1;
        //    int pageSize = 12;
        //    int pageNumber = (page ?? 1);

        //    var listTH = (from sp in db.SANPHAMs
        //                  join nsx in db.NHASANXUATs on sp.MANSX equals nsx.MANSX
        //                  join loai in db.LOAIs on sp.MALOAI equals loai.MALOAI
        //                  where sp.MALOAI == maLoai && sp.MANSX == maNSX
        //                  select sp).ToList();

        //    ViewBag.MaLoai = maLoai;

        //    return View(listTH.ToPagedList(pageNumber, pageSize));
        //}

    }
}