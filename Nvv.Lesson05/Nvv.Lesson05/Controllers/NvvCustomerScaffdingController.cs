using Nvv.Lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Nvv.Lesson05.Controllers
{
    public class NvvCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<NvvCustomer> listCustomer = new List<NvvCustomer>()
        {
             new NvvCustomer()
        {
            CustomerId = 1,
                FirstName = "Nguyễn Văn",
                LastName = "Vũ",
                Address = "K22CNT2",
                YearOfBirth = 2004
                },
                new NvvCustomer()
        {
            CustomerId = 2,
                FirstName = "Nguyễn Như",
                LastName = "Ngọc",
                Address = "Sư phạm 1",
                YearOfBirth = 2002
                },
                 new NvvCustomer()
        {
            CustomerId = 3,
                FirstName = "Nguyễn Bùi",
                LastName = "Phượng",
                Address = "Sư phạm 2",
                YearOfBirth = 2002
                },
                  new NvvCustomer()
        {
            CustomerId = 4,
                FirstName = "Nguyễn Linh",
                LastName = "Chi",
                Address = "Sư phạm 3",
                YearOfBirth = 2002
                }
    };
        // GET: NvvCustomerScaffding
        // listcustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpPost]
        public ActionResult NvvCreate()
        {
            var model = new NvvCustomer();
            return View(model);
        } 
            [HttpPost]
            public ActionResult NvvCreate(NvvCustomer model)
        { 
            // thêm mới đối tượng khách hàng vào danh sách dữ liệu
            listCustomer.Add(model);
            //return View(model);
            // chuyển về trang danh sách
            return RedirectToAction("Index");
        }
        public ActionResult NvvEdit(int id)
        { 
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId== id);
            return View(customer);
        }
    }
}