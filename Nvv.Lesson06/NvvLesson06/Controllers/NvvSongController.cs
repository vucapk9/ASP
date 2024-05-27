using NvvLesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NvvLesson06.Controllers
{
    public class NvvSongController : Controller
    {
        private static List<NvvSong> nvvSongs = new List<NvvSong>()
        {
         new NvvSong{Id=221090081,NvvTitle="Nguyễn Văn Vũ",NvvAuthor="K2CNTT2",NvvArtist="Vũ",NvvYearRelease=2022},
          new NvvSong{Id=1122002,NvvTitle="Nguyễn Bùi Như Ngọc",NvvAuthor="Sư Phạm Hà Nội",NvvArtist="Ngọc",NvvYearRelease=2020},
        };
        // GET: NvvSong
        public ActionResult NvvIndex()
        {
            return View(nvvSongs);
        }
        // get: Nvvcreate
        public ActionResult NvvCreate()
        {
            var NvvSong = new NvvSong();
            return View(NvvSong);
        }
        //post: NvvCreate
        public ActionResult NvvCreate(NvvSong nvvSong)
        {
            if(!ModelState.IsValid)//nếu có lỗi 
            {
                return View(nvvSong);
            }    

            // nếu dữ liệu đúng 
            nvvSongs.Add(nvvSong);
            return RedirectToAction("NvvIndex");
        }
    }
}